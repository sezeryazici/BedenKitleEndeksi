using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Beden Kitle İndeksi (BMI) Hesaplama");

        // Kullanıcıdan boyu ve kiloyu al
        Console.Write("Lütfen boyunuzu (metre cinsinden) girin: ");
        double boy = Convert.ToDouble(Console.ReadLine());

        Console.Write("Lütfen kilonuzu girin: ");
        double kilo = Convert.ToDouble(Console.ReadLine());

        // BMI hesapla
        double bmi = kilo / (boy * boy);

        // BMI sonucunu ekrana yazdır
        Console.WriteLine($"Beden Kitle İndeksi (BMI): {bmi}");

        // BMI yorumunu ekrana yazdır
        if (bmi < 18.5)
        {
            Console.WriteLine("Zayıf");
        }
        else if (bmi < 24.9)
        {
            Console.WriteLine("Normal");
        }
        else if (bmi < 29.9)
        {
            Console.WriteLine("Fazla Kilolu");
        }
        else
        {
            Console.WriteLine("Obez");
        }

        Console.ReadLine(); // Konsol penceresinin hemen kapanmaması için bekleme
    }
}
