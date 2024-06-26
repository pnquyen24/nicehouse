using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NiceHouse.Models;

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

            // Tìm kiếm khách sạn dựa trên các tiêu chí: địa điểm, giá min/max, tên khách sạn
            var hotels = _context.Hotels.AsQueryable(); // Tạo query linh động

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

            //Lấy thông tin giá thấp nhất và giá cao nhất từ bảng RoomType cho từng khách sạn
            var hotelIds = hotels.Select(h => h.Id).ToList();
            if (hotelIds.Any())
            {
                var roomTypes = _context.RoomTypes
                   .Where(rt => hotelIds.Contains(rt.HotelId))
                   .OrderBy(rt => rt.Price)
                   .ToList();

                hotels.ToList()?.ForEach(hotel =>
                {
                    var rts = roomTypes.Where(rt => hotel.Id == rt.HotelId);
                    if (rts.Any())
                    {
                        hotel.MinRoomPrice = rts.First()?.Price;
                        hotel.MaxRoomPrice = rts.Last()?.Price;
                    }
                    else
                    {
                        hotel.MinRoomPrice = 0;
                        hotel.MaxRoomPrice = 0;
                    }
                });
            }


            return View(hotels);
        }

        // Các action khác trong controller
    }
}
