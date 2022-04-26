using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Restauracja.Model
{
    public class Item
    {
        private int id;
        private String name;
        private float price;
        private Image picture;
        
        public Item(int i, String s, float f, String img) {
            id = i;
            name = s;
            price = f;
            System.IO.DirectoryInfo filepathtemp = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory.ToString()).ToString());
            string filepath = filepathtemp.ToString() + @"\Widok\images\";           
            picture = Image.FromFile(filepath + img);
        }
        public Item(int i, String s, float f, Image img)
        {
            id = i;
            name = s;
            price = f;
            picture = img;
        }
        public int Id{
            get{
                return id;
            }
        }
        public String Name{
            get{
                return name;
            }
        }
        public float Price{
            get{
                return price;
            }
        }
        public Image Picture
        {
            get{
                return picture;
            }
        }

    }
}
