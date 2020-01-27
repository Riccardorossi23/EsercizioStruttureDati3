using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EsercizioStruttureDati3
{
    class Dati3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome del file sorgente: ");
            string fileDati = $"{ Console.ReadLine()}";
            Console.WriteLine("Nome del file nuovo: ");
            string fileCopia = $"{ Console.ReadLine()}";
            if (File.Exists(fileDati))
            {
                try
                {
                    using (StreamReader r = new StreamReader(fileDati))
                    {
                        using (StreamWriter w = new StreamWriter(fileCopia))
                        {
                            string line;
                            while ((line = r.ReadLine()) != null)
                            {
                                w.WriteLine(line);
                            }
                        }
                    }
                }
                catch { }
            }
            else
            {
                Console.WriteLine("Il file sorgente non esiste");
            }

        }
    }
}
        