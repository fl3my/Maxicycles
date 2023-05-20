using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Maxicycles.Data;
using Maxicycles.Models;

namespace Maxicycles.Pages.Admin.Store
{
    public class IndexModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public IndexModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

        public IList<OrderIndexModel> Order { get; set; } = default!;
        public IList<BarChartModel> DataList { get; set; } = default!;
        public decimal TotalSalesLast7Days { get; set; }
        public int TotalItemsSoldLast7Days { get; set; }
        
        public class OrderIndexModel
        {
            [Display(Name = "Order ID")]
            public int Id { get; set; }
            
            [Display(Name = "Order Date")]
            [DataType(DataType.Date)]
            public DateTime OrderDate { get; set; }
            
            [Display(Name = "Total Price")]
            public decimal TotalPrice { get; set; }
            
            [Display(Name = "Total Items")]
            public int TotalItems { get; set; }
        }

        public class BarChartModel
        {
            public string? Data { get; set; }
            public string? Label { get; set; }
        }
        
        public async Task OnGetAsync()
        {
            
            // Create a list of the dates of the last 7 days and reverse.
            var last7Days = Enumerable.Range(0, 7).Select(i => DateTime.UtcNow.Date.AddDays(-i)).OrderBy(d => d.Date);
            
            // Create a list of all orders in the last 7 days.
            var orders = await _context.Orders
                .Include(o => o.OrderItems)
                .Include(o => o.DeliveryMethod)
                .Include(o => o.MaxicyclesUser)
                .Where(s => last7Days.Contains(s.OrderDate.Date))
                .ToListAsync();

            Order = new List<OrderIndexModel>();
            
            // Iterate over each order in the order list.
            foreach (var order in orders)
            {
                // Add the order to the list.
                Order.Add(new OrderIndexModel
                {
                    Id = order.Id,
                    OrderDate = order.OrderDate.ToLocalTime(),
                    TotalPrice = order.TotalPrice,
                    TotalItems = order.OrderItems.Count
                });

                TotalSalesLast7Days += order.TotalPrice;
                TotalItemsSoldLast7Days += order.OrderItems.Count;
            }
            
            // Group bu the order total price and sum for each day.
            var salesByDay = last7Days
                .GroupJoin(orders,
                    d => d,
                    s => s.OrderDate.Date,
                    (d, order) => new BarChartModel { Label = d.ToShortDateString(), Data = order.Sum(s => s.TotalPrice).ToString() })
                .ToList();
            
            // Create a bar chart model.
            DataList = new List<BarChartModel>();
            
            // Add the sales to the bar chart model.
            DataList = salesByDay;
        }
    }
}
