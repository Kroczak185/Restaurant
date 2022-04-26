using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja.Model
{
    public enum Status{ 
        Not_existing = 0,
        Free = 1,
        Reserved = 2,
        Occupied = 3
        }
   public class Table
    {
       private int id;
       private Status table_status;
       private int people;

        public Table()
        {
            id = -1;
            table_status = Status.Not_existing;
            people = 0;
        }
       public Table(int i, Status s, int p)
        {
            id = i;
            table_status = s;
            people = p;
        }
        public int Id {
            get
            {
                return id;
            } 
        }
        public Status status
        {
            get
            {
                return table_status;
            }
        }
        public int People
        {
            get
            {
                return people;
            }
        }

    }

}
