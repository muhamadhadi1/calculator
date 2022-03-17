using System;

namespace calculator
{
  class program
  {
    static void Main(string[] args)
    {
      float a, b;
      int menu;

      pilihan:
      Console.WriteLine();
      Console.WriteLine("PILIHAN MENU : ");
      Console.WriteLine();

      Console.WriteLine("1.PENAMBAHAN");
      Console.WriteLine("2.PENGURANGAN");
      Console.WriteLine("3.PERKALIAN");
      Console.WriteLine("4.PEMBAGIAN");
      Console.WriteLine();

      Console.Write("MASUKKAN PILIHAN : ");
      menu = int.Parse(Console.ReadLine());

      Console.WriteLine();

      switch(menu)
      {
        case 1:
        {
          Console.Write("MASUKKAN NILAI A : ");
          a = int.Parse(Console.ReadLine());
          Console.Write("MASUKKAN NILAI B : ");
          b = int.Parse(Console.ReadLine());
          Console.WriteLine();

          Console.WriteLine("HASIL PENAMBAHAN " + a + " + " + b + " = " + (a + b));
          Console.WriteLine();
          Console.WriteLine("PROGRAM SELESAI");
          Console.ReadKey();
          Environment.Exit(0);
          break;
        }
        case 2:
        {
          Console.Write("MASUKKAN NILAI A : ");
          a = int.Parse(Console.ReadLine());
          Console.Write("MASUKKAN NILAI B : ");
          b = int.Parse(Console.ReadLine());
          Console.WriteLine();

          Console.WriteLine("HASIL PENGURANGAN " + a + " - " + b + " = " + (a - b));
          Console.WriteLine();
          Console.WriteLine("PROGRAM SELESAI");
          Console.ReadKey();
          Environment.Exit(0);
          break;
        }
        case 3:
        {
          Console.Write("MASUKKAN NILAI A : ");
          a = int.Parse(Console.ReadLine());
          Console.Write("MASUKKAN NILAI B : ");
          b = int.Parse(Console.ReadLine());
          Console.WriteLine();

          Console.WriteLine("HASIL PERKALIAN " + a + " * " + b + " = " + (a * b));
          Console.WriteLine();
          Console.WriteLine("PROGRAM SELESAI");
          Console.ReadKey();
          Environment.Exit(0);
          break;
        }
        case 4:
        {
          Console.Write("MASUKKAN NILAI A : ");
          a = int.Parse(Console.ReadLine());
          Console.Write("MASUKKAN NILAI B : ");
          b = int.Parse(Console.ReadLine());
          Console.WriteLine();

          Console.WriteLine("HASIL PEMBAGIAN " + a + " : " + b + " = " + (a / b));
          Console.WriteLine();
          Console.WriteLine("PROGRAM SELESAI");
          Console.ReadKey();
          Environment.Exit(0);
          break;
        }
        default:
        {
          Console.WriteLine("PILIHAN SALAH!");
          goto pilihan;
        }
      }
    }
  }
}
