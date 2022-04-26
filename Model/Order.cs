using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja.Model
{
   public class Order
    {
        private int id;
        private List<Item> food;
        private DateTime time;
        private Table choosen_table;

        public Order(){
            choosen_table = null;
        }
        public Order(int i,List<Item> f, DateTime t, Table ct)
        {
            id = i;
            food = f;
            time = t;
            choosen_table = ct;
        }
        public Order(int i, DateTime t)
        {
            id = i;
            food = new List<Item>();
            time = t;
            choosen_table = null;
        }
        public int Id
        {
            get
            { return id; }
        }
        public List<Item> Food
        {
            get
            { return food; }
        }
        public DateTime Time
        {
            get 
            { return time; }
        }
        public Table Choosen_table
        {
            get { return choosen_table; }
        }
        public void setTable(Table t)
        {
            choosen_table = t;
        }
    }
}
