using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja.Model
{
    class Customer
    {
        private List<Item> cart;
        private Order order;
        private List<Item> menu;
        private List<Table> tableList;
        public Customer()
        {
            tableList = new List<Table>();
            menu = new List<Item>();
            cart = new List<Item>();
            readMenu();
            readTableList();
        }
        public void createOrder(DateTime tim, Table ct)
        {
            order = new Order(0,cart,tim,ct);
            using (var db = new RestauracjaModelContainer())
            {
                Restauracja.Table t;
                if (ct == null)
                {
                    t = null;
                }
                else
                {
                    t = db.TableSet.Single(a => a.Id == order.Choosen_table.Id);
                    t.table_status = 2;
                }
                    Restauracja.Order dp = new Restauracja.Order { time = order.Time, is_finished = false, Table = t };
                    db.OrderSet.Add(dp);
                    foreach (Item i in cart)
                    {
                        Restauracja.Menu m = db.MenuSet.Single(a => a.Id == i.Id);
                        Restauracja.Item xd = new Restauracja.Item {Order = dp, Menu = m };
                        db.ItemSet.Add(xd);
                    }
                    db.SaveChanges();
                }
        }
        private void readMenu()
        {
            using (var db = new RestauracjaModelContainer())
            {
                var x = db.MenuSet;               
                foreach (var i in x) { menu.Add(new Item(i.Id, i.name, (float)i.price, i.picture)); }    
            }
        }
        private void readTableList()
        {
            using (var db = new RestauracjaModelContainer())
            {
                Status s;
                var x = db.TableSet;
                foreach (var i in x) {
                    if (i.table_status == 1) s = Status.Free;
                    else if (i.table_status == 2) s = Status.Reserved;
                    else if (i.table_status == 3) s = Status.Occupied;
                    else s = Status.Not_existing;
                    tableList.Add(new Table(i.Id,s,i.people)); 
                }
            }
        }
        public void setCart(List<Item> c)
        {
            cart = c;
        }
        public List<Item> getMenu()
        {
            return menu;
        }
        public List<Table> getTableList()
        {
            return tableList;
        }
    }
}
