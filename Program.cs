using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //Soru-1
        int n = 20;
        ArrayList asal = new ArrayList();
        ArrayList nonAsal = new ArrayList();
        Console.WriteLine("20 Adet tam sayı giriniz!");
        for (int i = 0; i < n; i++)
        {
            try
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > 0)
                {
                    if (asalmi(sayi))
                    {
                        asal.Add(sayi);
                        continue;
                    }
                    else
                        nonAsal.Add(sayi);
                }
                else
                {
                    Console.WriteLine("You entered a negative number, enter a number again!");
                    i--;
                }
            }

            catch (Exception hata)
            {
                Console.WriteLine(hata.Message + "Enter number again!");
                i--;
            }

        }

        asal.Sort();
        Console.Write("\nAsal: ");
        foreach (var item in asal)
        {
            Console.Write(item + "  ");
        }
        Console.WriteLine("\nDizi {0} elemanlıdır.Dizinin ortlaması {1}'dır", asal.Count, Ort(asal));

        nonAsal.Sort();
        Console.Write("\nnonAsal: ");
        foreach (var item in nonAsal)
        {
            Console.Write(item + "  ");
        }
        Console.WriteLine("\nDizi {0} elemanlıdır.Dizinin ortalaması {1}'dır\n", nonAsal.Count, Ort(nonAsal));


        //soru-2
        Console.WriteLine("\n-Asal-");
        Max3(asal);
        Min3(nonAsal);
        Console.WriteLine("\n-nonAsal-");
        Max3(nonAsal);
        Min3(nonAsal);

        //soru-3
        Console.Write("\nCümle yazın: ");
        string cumle= Console.ReadLine().ToLower();

        char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        List<char> sesliHarf=new List<char>();
        foreach (char karakter in cumle)
            foreach (char sesli in sesliler)
                if (karakter == sesli)
                    sesliHarf.Add(sesli);

        Console.Write("Cümledeki sesli harfler: ");
        foreach (char item in sesliHarf)
        {
            Console.Write(item+" ");
        }

        sesliHarf.Sort();
        Console.Write("\nSort: ");
        foreach (char item in sesliHarf)
        {
            Console.Write(item+" ");
        }




    }


    static bool asalmi(int sayi) //Asal sayi kontrolü
    {
        bool durum = false;

        int kontrol = 0;

        for (int i = 2; i < sayi; i++)
        {
            if (sayi % i == 0)
            {
                kontrol = 1;
                break;
            }
        }
        if (kontrol == 1)
        {
            durum = false;
        }
        else
        {
            durum = true;
        }
        return durum;
    }

    static double Ort(ArrayList arr) //Koleksiyonu diziye dönüştürerek ortalama hesaplama
    {
        int top = 0;
        int[] Dizi = new int[20];
        Dizi = (int[])arr.ToArray(typeof(int));
        foreach (var item in Dizi)
        {
            if (Dizi.Length == 0)
            {
                top = 0;
                break;
            }

            top += item;
        }
        double x = Convert.ToDouble(top) / Convert.ToDouble(Dizi.Length);
        x = Math.Round(x, 2);
        return x;
    }

    static void Max3(ArrayList arr)
    {
       arr.Sort();
       arr.Reverse();
       Console.WriteLine("En büyük 3 sayi: "+arr[0]+" "+arr[1]+" "+arr[2]);
       int[] dizi=new int[arr.Count];
       dizi = (int[])arr.ToArray(typeof(int));
       int top=dizi[0]+dizi[1]+dizi[2];
       double ort=Convert.ToDouble(top)/3;
       ort=Math.Round(ort,2);
       Console.WriteLine("Ortalama: "+ort);
    }
    static void Min3(ArrayList arr)
    {
        
       arr.Sort();
       Console.WriteLine("En küçük 3 sayi: "+arr[0]+" "+arr[1]+" "+arr[2]);
       int[] dizi=new int[arr.Count];
       dizi = (int[])arr.ToArray(typeof(int));
       int top=dizi[0]+dizi[1]+dizi[2];
       double ort=Convert.ToDouble(top)/3;
       ort=Math.Round(ort,2);
       Console.WriteLine("Ortalama: "+ort);
    }



}
