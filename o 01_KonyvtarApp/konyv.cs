using System;
using System.Collections.Generic;
using System.Text;

namespace o_01_KonyvtarApp
{
    public class konyv
    {
        public string Cim { get; set; }
        public int Oldalszam{get; set{ if (Oldalszam <= 0)
                {
                    Console.WriteLine("nem");

                }
                else
                {
                    this.Oldalszam =Oldalszam;
                    Cim = Cim;
                   
                }
                ;
            }
        }
        public override string ToString()
        {
            return ("$Könyv: [Cim] ([Oldalszam] oldal)");
        }
    }
}
