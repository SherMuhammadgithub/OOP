
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop
{
    internal class MenuItemDL
    {
        public static List<MenuItem> MenuItems;

        public MenuItemDL()
        {
            MenuItems = new List<MenuItem>();
        }

        public bool AddMenuItem(MenuItem menuItem)
        {
            if(menuItem != null)
            {
            MenuItems.Add(menuItem);
            return true;
            }
            return false;
        }
        public static void StoreMenuItems(string path, MenuItem item)
        {
            StreamWriter streamWriter = new StreamWriter(path, true);
                streamWriter.WriteLine(item.Name + "," + item.Type + "," + item.Price);
            streamWriter.Flush();
            streamWriter.Close();

        }
        public static void LoadMenuItems(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            string line = streamReader.ReadLine();
            while (line != null)
            {
                string[] splittedString = line.Split(',');
                string name = splittedString[0];
                string type = splittedString[1];
                int price = Convert.ToInt32(splittedString[2]);
                MenuItems.Add(new MenuItem(name, type, price));
                line = streamReader.ReadLine();
            }
            streamReader.Close();
        }
      
    }
}
