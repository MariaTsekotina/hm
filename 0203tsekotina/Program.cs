using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0203tsekotina
{
    class Program
    {
        static void Main(string[] args)
        {
            Inimene naine1 = new Inimene("Kirja", 21, Emakeel.saksa, 60);
            naine1.Tervitame();

            Inimene[] inimesed = new Inimene[3];
            for (int i = 0; i < 3; i++)
            {
                inimesed[i] = new Inimene();
                Console.WriteLine("Nimi: ");
                inimesed[i].Eesnimi = Console.ReadLine();
                Console.WriteLine("Vanus: ");
                inimesed[i].Vanus = int.Parse(Console.ReadLine());
            }
            foreach (Inimene inimene in inimesed)
            {
                inimene.Tervitame();
            }

            Inimene mees = new Inimene();
            mees.Eesnimi = "Mark";
            Console.WriteLine("Ma olen {0}. Kui vana ma olen?", mees.Eesnimi);
            mees.Vanus = int.Parse(Console.ReadLine());
            mees.Tervitame();
            Inimene naine2 = new Inimene("Alenka", 18, Emakeel.vene, 55);
            naine2.Tervitame();

            Console.ReadLine();
        }
    }
}



















////string eesnimi;
//string perenimi;
//string staatus;
//int vanus;
//public int palk;
//Emakeel emakeel;
////public int Pikkus;
////public int Kaal;
//public Inimene() { }
//public Inimene(string Perenimi/*,Emakeel, emakeel*/)
//        public Inimene(string Perenimi/*,Emakeel, emakeel*/)

//{
//    perenimi = Perenimi;
//    //this.emakeel = emakeel;
//}
//public string Perenimi
//{
//    set { if (perenimi == null) perenimi = value; }
//    get { return perenimi; }
//}
//public int Palk
//{
//    set
//    {
//        Console.WriteLine("Mis on teie brutopalk?");
//        int vastama = int.Parse(Console.ReadLine());
//        if (vastama == 0)
//        {
//            Console.WriteLine("Okey. Sul pole palka.");
//        }
//        else if (vastama < 500)
//        {
//            Console.WriteLine("Teil on miinimumpalk.");
//        }
//        else
//        {

//        }
//    }
//    get { return palk; }
//}
//public int Vanus
//{
//    set
//    {
//        vanus = value;
//        if (vanus < 7)
//        {
//            staatus = "laps";
//        }
//        else if (vanus < 17)
//        {
//            staatus = "koolilaps";
//        }
//        else if (vanus < 24)
//        {
//            staatus = "ülikoolilaps";
//        }
//        else
//        {
//            staatus = "tööline";
//        }
//    }
//    get { return vanus; }
//}
//public string Staatus
//{
//    get { return staatus; }
//}
//public void Tervitamine()
//{
//    Console.WriteLine("Tere! Minu perenimi on " + perenimi);
//    Console.WriteLine("Ma olen {0} aastat vana, olen {1}", vanus, staatus);
//}
//    }
//}

