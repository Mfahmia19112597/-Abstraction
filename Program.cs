using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abtraction.abtractionClass;
using Abtraction.Interface;

namespace Abtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Konsep Abstraksi Menggunakan Abstract Class. ");
            Console.WriteLine();
            baju Baju;

            Baju = new kemeja();
            Baju.jenisBaju();

            Baju = new muslim();
            Baju.jenisBaju();

            Baju = new kaos();
            Baju.jenisBaju();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Konsep Abstraksi Menggunakan Interface. ");
            Console.WriteLine();
            IBahan bahanPembuatan;

            bahanPembuatan = new wol();
            bahanPembuatan.bahanDasar();

            bahanPembuatan = new sutra();
            bahanPembuatan.bahanDasar();

            bahanPembuatan = new katun();
            bahanPembuatan.bahanDasar();

            Console.ReadKey();
        }
    }
}