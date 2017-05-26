using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService2;

namespace TicketShop
{
    public class Basket
    {
        public Guid BasketId { get; set; }
        public TicketReservationPresentation Reservation { get; set; }

        public static Basket GetBasket()
        {
            if (HttpContext.Current.Session["Basket"] == null) HttpContext.Current.Session["Basket"] = new Basket { BasketId = Guid.NewGuid() };

            return (Basket)HttpContext.Current.Session["Basket"];            
        }

        public static void ClearBasket()
        {
            HttpContext.Current.Session["Basket"] = null;
        }
    }
}