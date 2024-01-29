using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlat03
{
    internal class Program
    {
        public static void Feladat1()
        {
            Console.WriteLine("Kérem adja meg az első számot: ");
            int egyikSzam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem adja meg a második számot: ");
            int masikSzam = Convert.ToInt32(Console.ReadLine());

            bool b = false;
            bool igazE = false;
            bool a = false;
            bool c = false;
            bool d = false;
            bool e = false;

            //igaz e hogy pozitív mind a 2 szám
            if (b = masikSzam > 0 & egyikSzam > 0)  
            {
                Console.WriteLine($"A két szám pozitív? {b}");
            }
            else
            {
                Console.WriteLine($"A két szám pozitív? {b}");
            }
            
            //igaz e hogy az egyik szám az kisebb mint 4 és másik szám nem egyenlő 6-al
            if (igazE = egyikSzam < 4 & masikSzam != 6)
            {
                Console.WriteLine($"(igazE) Válasz:{igazE}");
            }
            else
            {
                Console.WriteLine($"(IgazE) Válasz:{igazE}");
            }

            //bármelyik szám egyenlő egyenlő e nullával
            if (a = egyikSzam == 0 & masikSzam == 0)
            {
                Console.WriteLine($"(a) Válasz:{a}");
            }
            else
            {
                Console.WriteLine($"(a) Válasz:{a}");
            }


            //első szám egyenlő e 5-tel vagy a másik szám nem egyenlő 4-el
            if (c = egyikSzam == 5 || masikSzam != 4)
            {
                Console.WriteLine($"(c) Válasz: {c}");
            }
            else
            {
                Console.WriteLine($"(c) Válasz: {c}");
            }


            //első szám nem nagyobb 5-nél vagy a másik szám nem kisebb mint 13
            if (d =  egyikSzam > 5 || masikSzam > 13 )
            {
                Console.WriteLine($"(d) Válasz: {d}");
            }
            else
            {
                Console.WriteLine($"(d) Válasz: {d}");
            }


            //egyik szám pozitív a másik negatív 
            if (e == egyikSzam > 0 || masikSzam < 0) 
            {
                Console.WriteLine($"(e) válasz: {e}");
            }
            else
            {
                Console.WriteLine($"(e) válasz: {e}");
            }
        }
        public static void Feladat2()
        {
            bool A = false;
            bool B = false;
            Console.WriteLine($"\tA\t|\tB\t|\tA and b");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine($"\t{A}\t|\t{B}\t|\t{A && B}");
            A = true;
            Console.WriteLine($"\t{A}\t|\t{B}\t|\t{A && B}");
            B = true;
            A = false;
            Console.WriteLine($"\t{A}\t|\t{B}\t|\t{A && B}");
            A = true;
            Console.WriteLine($"\t{A}\t|\t{B}\t|\t{A && B}");
        }
        public static void Feladat3()
        {
            Console.Write("Kérem adja meg a számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int oszt = szam % 10;
            Console.WriteLine(oszt);

            if (oszt == 0)
            {
                Console.WriteLine("A szám osztható 10-zel");
            }
            else
            {
                Console.WriteLine("A szám nem osztható 10-zel");
            }


        }
        public static void Feladat4()
        {
            Console.Write("Kérem adja meg az első számot: ");
            int szamlalo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg a második számot: ");
            int nevezo = Convert.ToInt32(Console.ReadLine());

            if (nevezo == 0)
            {
                Console.WriteLine("Hiba: a nevező nem lehet 0-la");
            }
        }
        public static void Feladat5()
        {
          
        } //nincs kész
        public static void Feladat6()
        {
            Console.Write("Kérem adjon meg egy egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());    

            bool A = false;
            bool B = false;
            bool C = false;
            bool D = false;
            bool E = false;
            bool F = false;

            //A bekért szám az egyelő 4-el
            if (A = szam == 4)
            {
                Console.WriteLine();
                Console.WriteLine(A);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(A);
            }

            //A megadott szám kisebb mint 10
            if (B = szam < 10) 
            {
                Console.WriteLine();
                Console.WriteLine(B);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(B);
            }

            //A megadott szám páros
            if (C = szam % 2 == 0) 
            {
                Console.WriteLine();
                Console.WriteLine(C);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(C);
            }

            //A megadott szám 0 és 10 közé esik
            if (D = szam > 0 & szam < 10) 
            {
                Console.WriteLine();
                Console.WriteLine(D);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(D);
            }

            //A megadott szám osztható 3-mal és 5-tel
            if (E = szam % 3  == 0 & szam % 5 == 0) 
            {
                Console.WriteLine();
                Console.WriteLine(E);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(E);
            }

            //A megadott szám nem a 10 és 20 között esik 
            if (F = szam < 10 & szam > 20)
            {
                Console.WriteLine();
                Console.WriteLine(F);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(F);
            }
        }
        public static void Feladat7()
        {
            Console.WriteLine("Kérem adja meg az első számot: ");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem adja meg az második számot: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            bool A = false;
            bool B = false;
            bool C = false;
            bool D = false;
            bool E = false;

            //mind2 szám egyenlő
            if (A = szam1 == szam2)
            {
                Console.WriteLine();
                Console.WriteLine(A);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(A);
            }

            //Mind2 szám páratlan 
            if (B = szam2 % 2 == 1 & szam1 % 2 == 1)
            {
                Console.WriteLine();
                Console.WriteLine(B);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(B);
            }

            //Legalább az egyik osztható 3-mal
            if (C = szam1 % 3 == 0 ||  szam2 % 3 == 0)
            {
                Console.WriteLine();
                Console.WriteLine(C);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(C);
            }

            //mind2 szám negatív
            if (D = szam1 < 0 & szam2 < 0)
            {
                Console.WriteLine();
                Console.WriteLine(D);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(D);
            }

            //Az egyik szám negatív és a másik pozitív 
            if (E = szam1 < 0 & szam2 > 0 || szam1 > 0 & szam2 < 0)
            {
                Console.WriteLine();
                Console.WriteLine(E);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(E);
            }
        }
        public static void Feladat8()
        {
            Console.Write("Kérem ajda meg a téglalap A oldalát: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg téglalap B oldalát: ");
            int B = Convert.ToInt32(Console.ReadLine());

            if (A == B) 
            {
                Console.WriteLine("Ez egy négyzet");
            }
            else
            {
                Console.WriteLine("Ez egy téglalap");
            }
        }
        public static void Feladat9()
        {
            Console.Write("Kérem adja meg a háromszög A oldalát: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg a háromszög B oldalát: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg a háromszög C oldalát: ");
            int C = Convert.ToInt32(Console.ReadLine());

            if (A == B && B == C)
            {
                Console.WriteLine("Ez egy szabályos háromszög");
            }
            else
            {
                Console.WriteLine("Nem szabályos háromszög");
            }
        }
        public static void Feladat10()
        {
            Console.Write("Kérem adjon meg egy egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            if (szam == 10 || szam == 100 || szam == 1000)
            {
                Console.WriteLine("A szám egyenlő a megadott egyik számmal");
            }
            else
            {
                Console.WriteLine("A szám nem egyenlő egyik három közül se");
            }
        }
        public static void Feladat11()
        {
            Console.WriteLine("Kérem adjon meg egy egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            if (szam >= 1 &&  szam <= 9)
            {
                Console.WriteLine("A szám 1 és 9 közötti intervallumban van");
            }
            else
            {
                Console.WriteLine("A szám nincs 1 és 9 közötti intervallumban");
            }
        }
        public static void Feladat12()
        {
            Console.WriteLine("Kérem adjon meg egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            if (szam < 0 && szam % 2 == 1)
            {
                Console.WriteLine("A szám negatív és páratlan is");
            }
            else
            {
                Console.WriteLine("Egyik feltétel nem teljesült vagy mind2");
            }
            
        }
        public static void Feladat13()
        {
            Console.WriteLine("Kérem adja meg az első számot: ");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem adja meg az második számot: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            if (szam2 != 0)
            {
                if (szam1 % szam2 == 0)
                {
                    Console.WriteLine("Az első szám osztója a második számnak");
                }
                else
                {
                    Console.WriteLine("Az első szám nem osztója a másodiknak");
                }
            }
            else
            {
                Console.WriteLine("A második szám nem lehet nulla, nem lehet vele osztani");
            }

        }
        public static void Feladat14()
        {
            Console.WriteLine("Kérem adjon meg egy egész számot: ");
            double szam = Convert.ToDouble(Console.ReadLine());

            if (szam >= 0)
            {
                double gyok = Math.Sqrt(szam);
                Console.WriteLine("A(z) {0} szám gyöke: {1}", szam , gyok);
            }
            else 
            {
                Console.WriteLine("A megadott szának nem lehet gyöke, mert negatív");
            }
        }
        public static void Feladat15()
        {
            Console.Write("Kérem adja meg a háromszög A oldalát: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg a háromszög B oldalát: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg a háromszög C oldalát: ");
            int C = Convert.ToInt32(Console.ReadLine());


            if (A > 0 && B > 0 && C > 0)
            {
                Console.WriteLine($"A háromszög kerülete: {A + B + C}");
            }
            else
            {
                Console.WriteLine("Hibás adatok");
            }

        }
        public static void Feladat16()
        {
            Console.Write("Kérem adja meg hogy hány kilómétert tett meg (km): ");
            int km = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg hogy mennyi idő alatt (ó):  ");
            int ora = Convert.ToInt32(Console.ReadLine());

            double sebesseg = km / ora;

            if (sebesseg > 145 || sebesseg < 80)
            {
                Console.WriteLine("Nem megfelelő sebességel közlekedett.");
            }
            else
            {
                Console.WriteLine("Minden rendben");
            }


        }
        public static void Feladat17()
        {
            Console.Write("Kérem adjon meg egy egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            if (szam > 0)
            {
                Console.WriteLine("A megadott szám Pozitív");
            }
            else if (szam < 0)
            {
                Console.WriteLine("A megadott szám Negatív");
            }
            else 
            {
                Console.WriteLine("A megadott szám nulla");
            }
        }
        public static void Feladat18()
        {
            Console.Write("Kérem adja meg az első számot: ");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg az második számot: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            if (szam1 > szam2)
            {
                Console.WriteLine($"{szam1} > {szam2}");
            }
            else if (szam1 < szam2)
            {
                Console.WriteLine($"{szam1} < {szam2}");
            }
            else
            {
                Console.WriteLine($"{szam1} = {szam2}");
            }
        }
        public static void Feladat19()
        {
            Console.Write("Kérem adja meg a víz hőmérsékletét: ");
            int hom = Convert.ToInt32(Console.ReadLine());

            if (hom <= 0)
            {
                Console.WriteLine("Szilárd (jég)");
            }
            else if (hom > 0 && hom < 100)
            {
                Console.WriteLine("Folyékony (víz)");
            }
            else
            {
                Console.WriteLine("Légnemű (gőz)");
            }
        }
        public static void Feladat20()
        {
            Console.Write("Kérem adja meg az első számot: ");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg az első számot: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            if (szam1 > 0 && szam2 > 0)
            {
                Console.WriteLine("Első síknegyed");
            }
            else if (szam1 < 0 && szam2 > 0)
            {
                Console.WriteLine("Második síknegyed");
            }
            else if (szam1 < 0 && szam2 < 0)
            {
                Console.WriteLine("Harmadik síknegyed");
            }
            else
            {
                Console.WriteLine("Negyedik síknegyed");
            }

        }
        public static void Feladat21()
        {
            Console.Write("Kérem adjam meg a pontszámot: ");
            int pontszam = Convert.ToInt32(Console.ReadLine());

            if (pontszam >= 0 && pontszam <= 42) 
            {
                Console.WriteLine("Elégtelen");
            }
            else if (pontszam >= 43 && pontszam <= 57)
            {
                Console.WriteLine("Elégséges");
            }
            else if (pontszam >= 58 && pontszam <= 72)
            {
                Console.WriteLine("közepes");
            }
            else if (pontszam >= 73 && pontszam <= 87)
            {
                Console.WriteLine("jó");
            }
            else
            {
                Console.WriteLine("kitűnő");
            }
        }
        public static void Feladat22()
        {
            Console.Write("Kérem az adjon meg egy ember életkorát: ");
            int eletkor = Convert.ToInt32(Console.ReadLine());

            if (eletkor < 0)
            {
                Console.WriteLine("Nem lehet az életkor nulla alatt");
            }
            else if (eletkor >= 0 && eletkor <= 13)
            {
                Console.WriteLine("Gyerek");
            }
            else if (eletkor >= 14 &&  eletkor <= 17)
            {
                Console.WriteLine("Fiatal korú");
            }
            else if (eletkor >= 18 && eletkor <= 23)
            {
                Console.WriteLine("Ifjú");
            }
            else if (eletkor >= 24 &&  eletkor <= 59)
            {
                Console.WriteLine("Felnőtt");
            }
            else
            {
                Console.WriteLine("Idős");
            }
        }
        public static void Feladat23()
        {
            Console.Write("Kérem adja meg a tárgynak a sűrűségét: ");
            int targy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg a folyadéknak a sűrűségét: ");
            int folyadek = Convert.ToInt32(Console.ReadLine());

            if (targy > folyadek)
            {
                Console.Write("Elmerül");
            }
            else if (targy < folyadek)
            {
                Console.Write("Úszik");
            }
            else
            {
                Console.Write("Lebeg");
            }
        }
        public static void Feladat24()
        {
            Console.Write("kérem adja meg a diák igazolatlan hiányzásainak számát: ");
            int hianyzas = Convert.ToInt32(Console.ReadLine());

            if (hianyzas < 0)
            {
                Console.Write("Nem megfelelő érték");
            }
            else if (hianyzas == 0) 
            {
                Console.Write("Magatartás: 5");
            }
            else if (hianyzas >= 1 && hianyzas <= 3)
            {
                Console.Write("Magatartás: 4");
            }
            else if (hianyzas >= 4 &&  hianyzas <= 9)
            {
                Console.Write("Magatartás: 3");
            }
            else if (hianyzas >= 10)
            {
                Console.Write("Magatartás: 2");
                Console.WriteLine();
                Console.Write("Kérem adja a meg a tanuló korát: ");
                int eletkor = Convert.ToInt32(Console.ReadLine());

                if (eletkor < 18)
                {
                    Console.Write("Szülői értesítés szükséges");
                }
                else if (eletkor >= 18)
                {
                    Console.Write("felszólítás kiküldése szükséges");
                }
            }
        }
        static void Main(string[] args)
        {
            //Feladat1();
            //Feladat2();
            //Feladat3();
            //Feladat4();
            //Feladat5();
            //Feladat6();
            //Feladat7();
            //Feladat8();
            //Feladat9();
            //Feladat10();
            //Feladat11();
            //Feladat12();
            //Feladat13();
            //Feladat14();
            //Feladat15();
            //Feladat16();
            //Feladat17();
            //Feladat18();
            //Feladat19();
            //Feladat20();
            //Feladat21();
            //Feladat22();
            //Feladat23();
            Feladat24();

          Console.ReadLine();
        }
    }
}
