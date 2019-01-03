using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor class Dictionary                                    //string string ---pair of key value
            Dictionary<string, string> capitals = new Dictionary<string, string>();     
            capitals.Add("Attiki", "Athina");
            capitals.Add("Pieria", "Katerini");
            capitals.Add("Magnisia", "Volos");
            capitals.Add("Imathias", "Veroia");

            string capitalOfAttiki = capitals["Attiki"];    //---[magic string]
            Console.WriteLine("The capital of Attiki is {0}", capitalOfAttiki);

            var nomoi = Nomos.GetNomoi();
            var attiki = nomoi["Attiki"];
            Console.WriteLine("The capital of Attiki is {0}, population is {1}", attiki.Capital, attiki.Population);

        }                                                                             
    }
}
