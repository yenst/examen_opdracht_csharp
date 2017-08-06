using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace examen_opdracht_csharp
{
    public class Doos
    {
     
      


        public Doos(int aantal_gele, int aantal_blauwe)
        {
            //dit is een arraylist, is makkelijker om dingen aan te te voegen en te verwijderen dan een gwne list, je kan hier ook met een stack werken
            ballen = new List<Bal>();
            
            genereer_ballen(aantal_gele, "geel");
            genereer_ballen(aantal_blauwe, "blauw");


        }

        private void genereer_ballen(int aantal,string kleur)
        {
            for (int i = 0; i < aantal; i++)
            {
                ballen.Add(new Bal(kleur));
            }
        }

        public Bal neem_willekeurige_bal()
        {
            Random r = new Random();

            //random syntax in c#
            int random_int = r.Next(0, ballen.Count);
            Bal gekozen_bal= ballen[random_int];
            ballen.Remove(gekozen_bal);
            return gekozen_bal;
        }

        public void neem_meerdere_ballen(int aantal)
        {
            for(int i = 0;i < aantal; i++)
            {
                Console.WriteLine(neem_willekeurige_bal().ToString());
            }
        }


        private List<Bal> ballen { get; set; }


    }
}
