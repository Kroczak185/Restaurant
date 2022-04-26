using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja.Model
{
    class Chef
    {
        private List<Order> ordersToCook;

        public Chef() 
        {
            ordersToCook = new List<Order>();
            readOrders();
        }
        public void addToFinished(int orderid)
        {          
            using (var db = new RestauracjaModelContainer())
            {
                // pobieramy element, który chcemy zmienić
                Restauracja.Order orDB = db.OrderSet.Single(a => a.Id == orderid);
                orDB.is_finished = true;
                db.SaveChanges();          
            }
        }
        private void readOrders()
        {
            using (var db = new RestauracjaModelContainer())
            {
                var orderset = db.OrderSet;
                foreach (var i in orderset)
                {
                    if (i.is_finished == false)
                    {
                        Order o = new Order(i.Id,i.time);
                        var m = db.ItemSet.Where(a => a.Order.Id == i.Id);
                        foreach (var dishes in m)
                        {
                                o.Food.Add(new Item(dishes.Menu.Id, dishes.Menu.name, (float)dishes.Menu.price, dishes.Menu.picture));
                        }
                        ordersToCook.Add(o);
                    }
                }
            }
        }
        public List<Order> getOrdersToCook()
        {
            return ordersToCook;
        }

    }
}
