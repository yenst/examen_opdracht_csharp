using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_opdracht_csharp
{
    public class Bal
    {
        public string kleur { get; set; }

        public Bal(string kleur)
        {
            this.kleur = kleur;
        }


        public override string ToString()
        {
            return kleur;
        }

    }

    
}
