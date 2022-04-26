using Restauracja.Widok;
using System;
using System.Windows.Forms;

namespace Restauracja
{
    static class MainClass
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BaseView());
            //using (var db = new RestauracjaModelContainer())
            //{
            //    var test = db.ItemSet;
            //    foreach (var item in test)
            //    {
            //        Console.WriteLine($"Id: {item.Id}");
            //    }
            //}
            //using (var db = new RestauracjaModelContainer())
            //{
            //    Menu dp = new Menu { name = "Woda", picture = "water_test.png", price = 4 };
            //    db.MenuSet.Add(dp);
            //    db.SaveChanges();
            //}



        }
    }
}