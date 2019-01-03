using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Division of responsibility
            //Separation of conserns.
            WareHouse myWareHouse = new WareHouse("Storage 1", 1);
            var myItem = myWareHouse.FindAndReturnItem(101);
            Console.WriteLine("My Item is " + myItem.Name + " with code " + myItem.ID);

            var excel = new Software();
            excel.ID = 102;
            excel.ISBN = "isbnNumber";
            excel.Purchase();
            

            var pc = new Hardware();
            pc.Name = "Troll";
            pc.Price = 876.98;
            pc.SerialNumber = "serialNumber";
            pc.Purchase();

            var myComputer = new Computer();
           
            Item mySecondComputer = new Computer(); 
            Computer myThirdComputer = mySecondComputer as Computer;     
            string cpuType = myThirdComputer.CPUType;
            Console.WriteLine(cpuType);                      
            
            Item bestItem = Item.GetBestItem();

            Console.WriteLine($"Best Item {bestItem.ID}, and Name is {bestItem.Name}");

            

            List<Item> myItems = Item.GetItems(7);
            foreach (Item item in myItems)
            {
                Console.WriteLine("New Item ID = {0}, Name is {1}", item.ID, item.Name);
            }
        }
    }
}
