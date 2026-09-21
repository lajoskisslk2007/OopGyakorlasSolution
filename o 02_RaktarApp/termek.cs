using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace o_02_RaktarApp
{
    public class termek
    {
        public string Nev {get; set;}
        public int egysegar { get; private set; }

        public static int termekszamlalo
        {
            get; private set
            {
                termekszamlalo++;
            }
        }

     
    }
}
