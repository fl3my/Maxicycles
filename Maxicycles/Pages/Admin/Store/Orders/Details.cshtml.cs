using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Maxicycles.Data;
using Maxicycles.Models;

namespace Maxicycles.Pages.Admin.Store.Orders
{
    public class DetailsModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public DetailsModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

      public Order Order { get; set; } = default!;
      public Card Card { get; set; } = default!;
      public IList<OrderItemModel> OrderItem { get; set; } = default!;
      public MaxicyclesUser MaxicyclesUser { get; set; } = default!;

      public class OrderItemModel
      {
          public string? Title { get; set; } 
          public int Quantity { get; set; }
          public decimal ItemPrice { get; set; }
          public decimal LinePrice { get; set; }
      }
      
      public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.OrderItems)
                .Include(o => o.Payment)
                .Include(o => o.MaxicyclesUser)
                .Include(o => o.DeliveryMethod)
                .FirstOrDefaultAsync(m => m.Id == id);
            
            if (order == null)
            {
                return NotFound();
            }
            else 
            {
                Order = order;
                
                MaxicyclesUser = order.MaxicyclesUser;
                
                if (Order.Payment is Card card)
                {
                    Card = card;
                }

                OrderItem = new List<OrderItemModel>();
                
                foreach (var item in order.OrderItems)
                {
                    OrderItem.Add(new OrderItemModel
                    {
                        Title = item.Title,
                        ItemPrice = item.ItemPrice,
                        Quantity = item.Quantity,
                        LinePrice = item.ItemPrice * item.Quantity
                    });
                }
            }
            return Page();
        }
    }
}
