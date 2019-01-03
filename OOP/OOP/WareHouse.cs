using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class WareHouse
    {
        public int ID { get; set; }
        public string WareHouseName { get; set; }

        //Constructor
        public WareHouse(string name, int ID)
        {
            WareHouseName = name;
            this.ID = ID;
        }         

        public Item FindAndReturnItem(int itemID)       
        {
            //Initialization Constructor
            Item returnItem = new Item()
            {
                ID = itemID,
                Name = "PC"
            };

            //returnItem.ID = itemID;

            return returnItem;
        }
      
    }
}
