using System;
using System.Collections.Generic;
using System.Text;

namespace o_03_JatekApp
{
    public class karakter
    {
        public string Nev { get; set; }
        public int eletero
        {
            get; private set
            {
                eletero = 100;
            }
        }


    public void sebzodik(int pont)
        {
            eletero = eletero - pont;
            if (eletero<0)
            {
                Console.WriteLine("nem mehet negativba");
                eletero = 0;
            }
        }
        public override string ToString()
        {
            return ("$[Nev] - Életerő: [Eletero] HP");
        }
    }

}
