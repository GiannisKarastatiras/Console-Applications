using System;
using System.Collections.Generic;

namespace OOP
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public virtual void Purchase()          
        {                                       

            Console.WriteLine($"Purchasing {Name}");
        }

        public static Item GetBestItem()     
        {
            var newItem = new Item()
            {
                ID = 101,
                Name = "MyItem"
            };
            return newItem;
        }

        public static List<Item> GetItems(int numToGet)
        {
            var random = new Random();
            var newList = new List<Item>();
            for (int i = 0; i < numToGet; i++)
            {
                Item newItem = new Item()
                {
                    ID = random.Next(),
                    Name = "myItem" + i.ToString()          //i.ToString like string interpolation
                };
                newList.Add(newItem);
            }

            return newList;
        }
    }
}