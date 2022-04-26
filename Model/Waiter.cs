using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja.Model
{
    class Waiter
    {
        private List<Order> ordersToDelivery;
        private List<Table> tableList;
        private List<Item> items;
        public Waiter() 
        {
            ordersToDelivery = new List<Order>();
            tableList = new List<Table>();
            items = new List<Item>();
            readTableList();
            readOrdersToDelivery();
        }
        public void setTableOccupied(Table t)
        {
            using (var db = new RestauracjaModelContainer())
            {
                Restauracja.Table tabDB = db.TableSet.Single(a => a.Id == t.Id);
                tabDB.table_status=3;
                db.SaveChanges();
            }
        }
        public void setTableFree(Table t)
        {
            using (var db = new RestauracjaModelContainer())
            {
                Restauracja.Table tabDB = db.TableSet.Single(a => a.Id == t.Id);
                tabDB.table_status = 1;
                db.SaveChanges();
            }
        }
        public void setTableReserved(Table t)
        {
            using (var db = new RestauracjaModelContainer())
            {
                Restauracja.Table tabDB = db.TableSet.Single(a => a.Id == t.Id);
                tabDB.table_status = 2;
                db.SaveChanges();
            }
        }
        public List<Order> getOrdersToDelivery()
        {
            return ordersToDelivery;
        }
        public void readOrdersToDelivery()
        {
            using (var db = new RestauracjaModelContainer())
            {
                Restauracja.Table t;
                var itme = db.ItemSet;
                var menuDB = db.MenuSet;
                var x = db.OrderSet;
                foreach (var i in x)
                {
                    if(i.is_finished==true)
                    {
                        try
                        {
                            t = db.TableSet.Single(a => a.Id == i.Table.Id);
                        }
                        catch (System.Reflection.TargetException e)
                        {
                            t = null;
                        }
                        Order o = new Order(i.Id, i.time);
                        var m = db.ItemSet.Where(a => a.Order.Id == i.Id);
                        foreach (var dishes in m)
                        {
                            o.Food.Add(new Item(dishes.Menu.Id, dishes.Menu.name, (float)dishes.Menu.price, dishes.Menu.picture));
                        }
                        if (t != null)
                        {
                            foreach (var list in tableList)
                            {
                                if (list.Id == t.Id)
                                {
                                    o.setTable(list);
                                    ordersToDelivery.Add(o);
                                }
                            }
                        }
                        else
                        {
                            ordersToDelivery.Add(o);
                        }
                    }
                   
                }
            }
        }
        public List<Table> getTableList()
        {
            return tableList;
        }
        private void readTableList()
        {
            using (var db = new RestauracjaModelContainer())
            {
                Status s;
                var x = db.TableSet;
                foreach (var i in x)
                {
                    if (i.table_status == 1) s = Status.Free;
                    else if (i.table_status == 2) s = Status.Reserved;
                    else if (i.table_status == 3) s = Status.Occupied;
                    else s = Status.Not_existing;
                    tableList.Add(new Table(i.Id, s, i.people));
                }
            }
        }
        public void orderDelivered(int o)
        {
            using (var db = new RestauracjaModelContainer())
            {
                Restauracja.Order orDB = db.OrderSet.Single(a => a.Id == o);
                var itme = db.ItemSet;
                foreach (var el in itme)
                {
                    if (el.Order.Id == orDB.Id)
                        db.ItemSet.Remove(el);
                }
                db.OrderSet.Remove(orDB);
                db.SaveChanges();
            }
        }
    }
}
