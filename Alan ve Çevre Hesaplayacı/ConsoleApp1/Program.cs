using System;
using System.Text.RegularExpressions;
public class Program
{

    public static void Main()
    { 
        don:
        try
        {
            int giris, islem, secim, tipi;
            double kenaruzunluk, tabanuzunluk, alan, yukseklik, cevre;
        git:
            Console.WriteLine("====================================================================================");
            Console.WriteLine(" Ne Yapacaksınız ?");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine(" Giriş için 1 / Çıkış için 0");
            giris = Convert.ToInt32(Console.ReadLine());

            if (giris == 1)
            {
                Console.WriteLine(" İşlem Türünü Seçiniz");
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine("Alan için 1 / Çevre için 2 ");
                islem = Convert.ToInt32(Console.ReadLine());
                if (islem == 1)
                {
                    Console.WriteLine(" Hangisini Hesaplayacaksınız");
                    Console.WriteLine("------------------------------------------------------------------------------------");
                    Console.WriteLine("Üçgen için 1 / Kare için 2 / Dikdörtgen için 3 / Daire için 4");
                    secim = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("------------------------------------------------------------------------------------");
                    if (secim == 1)//Üçgen alan hesapla
                    {
                        Console.WriteLine(" Üçgen Tipini Seçiniz");
                        Console.WriteLine("------------------------------------------------------------------------------------");
                        Console.WriteLine("Eşkanar Üçgen için 1 / İkizkenar Üçgen için 2 / Çeşitkenar Üçgen için 3 ");
                        tipi = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("------------------------------------------------------------------------------------");
                        if (tipi == 1)//Eşkanar Üçgen Alan
                        {
                            Console.WriteLine("Kenar Uzunluğunu Giriniz");
                            kenaruzunluk = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Taban Uzunluğunu Giriniz");
                            tabanuzunluk = Convert.ToDouble(Console.ReadLine());
                            alan = (tabanuzunluk * kenaruzunluk * Math.Sqrt(3)) / 4;
                            Console.WriteLine("Eşkenar Üçgenin Alanı :" + alan);
                            goto git;
                        }
                        if (tipi == 2)//İkizkenar Üçgen Alan
                        {
                            Console.WriteLine("Kenar Uzunluğunu Giriniz");
                            kenaruzunluk = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Taban Uzunluğunu Giriniz");
                            tabanuzunluk = Convert.ToDouble(Console.ReadLine());
                            yukseklik = Math.Sqrt(Math.Pow(kenaruzunluk, 2) - Math.Pow(tabanuzunluk / 2, 2));
                            alan = (tabanuzunluk * yukseklik) / 2;
                            Console.WriteLine("İkizkenar Üçgenin Alanı :" + alan);
                            goto git;
                        }
                        if (tipi == 3) //Çeşitkenar Üçgen Alan
                        {
                            double kenar1, kenar2, kenar3;
                            Console.WriteLine("1.Kenarı Giriniz");
                            kenar1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("2.Kenarı Giriniz");
                            kenar2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("3.Kenarı Giriniz");
                            kenar3 = Convert.ToDouble(Console.ReadLine());
                            double s = (kenar1 + kenar2 + kenar3) / 2;
                            alan = Math.Sqrt(s * (s - kenar1) * (s - kenar2) * (s - kenar3));
                            Console.WriteLine("Çeşitkenar üçgenin alanı: " + alan);
                            goto git;
                        }
                    }
                    if (secim == 2)//Kare alan hesapla
                    {
                        double kenar;
                        Console.Write("Karenin bir kenar uzunluğunu girin: ");
                        kenar = Convert.ToDouble(Console.ReadLine());
                        alan = kenar * kenar;
                        Console.WriteLine("Karenin alanı: " + alan);
                        goto git;

                    }
                    if (secim == 3)//Dikdörtgen alan hesapla
                    {
                        double uzunKenar, kisaKenar;

                        Console.Write("Dikdörtgenin uzun kenarını girin: ");
                        uzunKenar = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Dikdörtgenin kısa kenarını girin: ");
                        kisaKenar = Convert.ToDouble(Console.ReadLine());

                        alan = uzunKenar * kisaKenar;

                        Console.WriteLine("Dikdörtgenin alanı: " + alan);
                        goto git;
                    }
                    if (secim == 4)//Daire alan hesapla
                    {
                        double r;
                        Console.Write("Dairenin yarıçapını girin: ");
                        r = Convert.ToDouble(Console.ReadLine());
                        alan = Math.PI * Math.Pow(r, 2);
                        Console.WriteLine("Dairenin alanı: " + alan);
                        goto git;
                    }
                }
                if (islem == 2)
                {
                    Console.WriteLine(" Hangisini Hesaplayacaksınız");
                    Console.WriteLine("------------------------------------------------------------------------------------");
                    Console.WriteLine("Üçgen için 1 / Kare için 2 / Dikdörtgen için 3 / Daire için 4");
                    secim = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("------------------------------------------------------------------------------------");
                    if (secim == 1) //Üçgen Çevre Hesapla
                    {
                        Console.WriteLine(" Üçgen Tipini Seçiniz");
                        Console.WriteLine("------------------------------------------------------------------------------------");
                        Console.WriteLine("Eşkanar Üçgen için 1 / İkizkenar Üçgen için 2 / Çeşitkenar Üçgen için 3 ");
                        tipi = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("------------------------------------------------------------------------------------");
                        if (tipi == 1)//Eşkanar Üçgen Çevre
                        {
                            Console.Write("Kenar Uzunluğunu Giriniz:");
                            kenaruzunluk = Convert.ToDouble(Console.ReadLine());
                            cevre = 3 * kenaruzunluk;
                            Console.WriteLine("Eşkenar üçgenin çevresi: " + cevre);
                            goto git;
                        }
                        if (tipi == 2)//İkizkenar Üçgen Çevre
                        {
                            double esitKenarUzunlugu;
                            Console.Write("Eşit Kenar Uzunluğunu Giriniz: ");
                            esitKenarUzunlugu = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Taban Kenar Uzunluğunu Giriniz: ");
                            tabanuzunluk = Convert.ToDouble(Console.ReadLine());
                            cevre = 2 * esitKenarUzunlugu + tabanuzunluk;
                            Console.WriteLine("İkizkenar üçgenin çevresi: " + cevre);
                            goto git;
                        }
                        if (tipi == 3) //Çeşitkenar Üçgen Çevre
                        {
                            double kenar1, kenar2, kenar3;

                            Console.Write("Üçgenin ilk kenarını girin: ");
                            kenar1 = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Üçgenin ikinci kenarını girin: ");
                            kenar2 = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Üçgenin üçüncü kenarını girin: ");
                            kenar3 = Convert.ToDouble(Console.ReadLine());

                            cevre = kenar1 + kenar2 + kenar3;

                            Console.WriteLine("Üçgenin çevresi: " + cevre);
                            goto git;
                        }
                    }
                    if (secim == 2) //Kare Çevre Hesapla
                    {
                        Console.Write("Karenin kenar uzunluğunu girin: ");
                        kenaruzunluk = Convert.ToDouble(Console.ReadLine());
                        cevre = 4 * kenaruzunluk;
                        Console.WriteLine("Karenin çevresi: " + cevre);
                        goto git;
                    }
                    if (secim == 3) //Dikdörtgen Çevre Hesapla
                    {
                        Console.Write("Dikdörtgenin uzun kenarını girin: ");
                        double uzunKenar = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Dikdörtgenin kısa kenarını girin: ");
                        double kisaKenar = Convert.ToDouble(Console.ReadLine());
                        cevre = 2 * (uzunKenar + kisaKenar);
                        Console.WriteLine("Dikdörtgenin çevresi: " + cevre);
                        goto git;
                    }
                    if (secim == 4) // Daire Çevre Hesapla
                    {
                        double yaricap;

                        Console.Write("Lütfen dairenin yarıçapını giriniz: ");
                        yaricap = Convert.ToDouble(Console.ReadLine());

                        cevre = 2 * Math.PI * yaricap;

                        Console.WriteLine("Dairenin çevresi: " + cevre);
                        goto git;
                    }
                }
            }
            else if (giris == 0)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Yanlış Tuşlama !!!");
                goto git;
            }
        }
        catch (FormatException) 
        {
            Console.WriteLine("Yanlış Tuşlama!!!");
            goto don;
        }
        Console.ReadKey();
    }
}