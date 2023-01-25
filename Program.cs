using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Napišite program koji će za definirani niz tipa double pronaći član koji najmanje odstupa od 
            prosječne vrijednosti niza. Program mora raditi ispravno za proizvoljni broj članova niza.*/

            Console.WriteLine("Upisi te niz decimalnih brojeva: ");
            double[] niz = new double[10];
            double zbroj = 0;
            for (int i = 0; i < niz.Length; i++)
            {
                niz[i] = Convert.ToDouble(Console.ReadLine());
                zbroj =+ niz[i];
            }
            double avg = zbroj / niz.Length;
            double najmanje_odstupanje= 1, temp, broj_najmanjeg_odstupanja = 1;

            for(int j = 0; j < niz.Length; j++)
            {
                temp = niz[j] - avg;
                if(temp == 0)
                {
                    broj_najmanjeg_odstupanja = niz[j];
                    break;
                }
                if (temp < 1 && temp > -1)
                {
                    if(temp++ < 1)
                    {
                        if(temp < najmanje_odstupanje)
                        {
                            najmanje_odstupanje = temp;
                            broj_najmanjeg_odstupanja = niz[j];

                        }
                    }else
                    {
                        if(temp < najmanje_odstupanje)
                        {
                            najmanje_odstupanje++;
                            broj_najmanjeg_odstupanja = niz[j];
                        }
                    }
                }
            }
            Console.WriteLine("Član koji odstupa od prosječne vrijednosti niza({0}) je jednak: {1}", avg, broj_najmanjeg_odstupanja);
            Console.ReadKey();
        }
    }
}
