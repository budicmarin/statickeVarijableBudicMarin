using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statickeVarijableBudicMarin
{
    class Program
    {
        static void Main(string[] args)
        {
            PrvaKlasa x = new PrvaKlasa("Mirko", "Mirković");
     
            PrvaKlasa y= new PrvaKlasa("Ivica", "Ivić");
            PrvaKlasa z = new PrvaKlasa();
            z.Ime = "Mile";
            z.Prezime = "Milorad";
            Console.WriteLine(x+"\n"+y+"\n"+z);
            
            Console.ReadKey();
        }
    }
}
