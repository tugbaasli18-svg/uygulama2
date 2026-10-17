using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        List<int> sayilar = new List<int> { 12, 45, 150, 555, 789, 1024, 2048 };

        Console.Write("Aratmak istediğiniz sayıyı girin: ");
        string giris = Console.ReadLine();

        if (int.TryParse(giris, out int arananSayi))
        {
            bool sonuc = sayilar.Contains(arananSayi);
            Console.WriteLine(sonuc);
        }
        else
        {
            Console.WriteLine("Geçersiz bir değer girdiniz, lütfen bir sayı yazın.");
        }
    }
}