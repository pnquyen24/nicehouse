using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NiceHouse.Models;
using System.Collections.Generic;

namespace NiceHouse.Controllers
{
    public class SearchController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SearchController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string location, decimal? minPrice, decimal? maxPrice, string hotelName)
        {
            var hotels = _context.Hotels
                .Include(h => h.Images)
                .AsQueryable();

            if (!string.IsNullOrEmpty(location))
            {
                hotels = hotels.Where(h => h.Location.Contains(location));
            }

            if (minPrice.HasValue)
            {
                hotels = hotels.Where(h => _context.RoomTypes.Any(rt => rt.HotelId == h.Id && rt.Price >= minPrice.Value));
            }

            if (maxPrice.HasValue)
            {
                hotels = hotels.Where(h => _context.RoomTypes.Any(rt => rt.HotelId == h.Id && rt.Price <= maxPrice.Value));
            }

            if (!string.IsNullOrEmpty(hotelName))
            {
                hotels = hotels.Where(h => h.Name.Contains(hotelName));
            }

            var hotelsList = hotels.ToList();

            // Get minimum and maximum room prices for each hotel
            foreach (var hotel in hotelsList)
            {
                var roomTypes = _context.RoomTypes.Where(rt => rt.HotelId == hotel.Id).ToList();

                if (roomTypes.Any())
                {
                    hotel.MinRoomPrice = roomTypes.Min(rt => rt.Price); // Get minimum price
                    hotel.MaxRoomPrice = roomTypes.Max(rt => rt.Price); // Get maximum price
                }
                else
                {
                    hotel.MinRoomPrice = 0;
                    hotel.MaxRoomPrice = 0;
                }
            }

            return View(hotelsList);
        }

        public IActionResult Rooms(int hotelId, decimal? minPrice, decimal? maxPrice, int? numberOfBeds)
        {
            var roomsQuery = _context.Rooms
                .Where(r => r.HotelId == hotelId)
                .Include(r => r.RoomType)
                .ThenInclude(rt => rt.Images)  // Include the RoomType images
                .Include(r => r.Hotel)
                .AsQueryable();

            if (minPrice.HasValue)
            {
                roomsQuery = roomsQuery.Where(r => r.RoomType.Price >= minPrice.Value);
            }

            if (maxPrice.HasValue)
            {
                roomsQuery = roomsQuery.Where(r => r.RoomType.Price <= maxPrice.Value);
            }

            if (numberOfBeds.HasValue)
            {
                roomsQuery = roomsQuery.Where(r => r.RoomType.NumberOfBeds == numberOfBeds.Value);
            }

            var rooms = roomsQuery.AsNoTracking().ToList();
            ViewBag.HotelId = hotelId;
            return View(rooms);
        }

    }
}
