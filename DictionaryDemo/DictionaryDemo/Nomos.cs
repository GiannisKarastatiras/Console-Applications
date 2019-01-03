using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Nomos
    {
        public string Capital { get; set; }
        public int Population { get; set; }
        public int Size { get; set; }

        public Nomos(string capital, int population, int size)
        {
            Capital = capital;
            Population = population;
            Size = size;
        }

        public static Dictionary<string, Nomos> GetNomoi()
        {
            var nomoi = new Dictionary<string, Nomos>();

            var nomos = new Nomos("Athina", 576, 334);
            nomoi.Add("Attiki", nomos);
            nomos = new Nomos("Katerini", 80, 21);
            nomoi.Add("Pieria", nomos);
            nomos = new Nomos("Volos", 56, 8);
            nomoi.Add("Magnisia", nomos);
            
            return nomoi;
        }
        
    } 
        
}
