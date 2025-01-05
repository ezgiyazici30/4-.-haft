//3. Aşırı Yüklenmiş (Overloaded) Metot ile Farklı Türdeki Verilerin Toplamını Bulma
//Soru: Aynı isimle üç farklı CalculateSum metodu yazın.İlk metot iki int sayıyı toplasın, ikinci metot iki double sayıyı toplasın, üçüncü metot ise üç int sayıyı toplasın.
//İpucu: Metot isimleri aynı olmalı fakat parametre türleri farklı olmalıdır.

static int sayitopla(int a, int b)
{
    return a + b;
}

static double sayitopla(double a, double b)
{
    return a + b;
}

static int sayitopla(int a, int b, int c)
{
    return a + b + c;
}

//4. Recursive Metot ile Fibonacci Dizisi Hesaplama
//Soru: Bir sayının Fibonacci dizisindeki karşılığını hesaplayan özyinelemeli(recursive) bir metot yazın.
//fibonacci(5) çağrısı, dizideki 5. Fibonacci sayısını döndürmelidir.
//İpucu: int dönen ve kendini çağırarak Fibonacci dizisi üreten bir metot yazmalısınız.


static int fibonacci(int n)
{
    if (n == 0)
        return 0;
    if (n == 1)
        return 1;

    return fibonacci(n - 1) + fibonacci(n - 2);


}
//5. Params ile Sınırsız Sayıda Parametre Alarak Ortalama Hesaplama
//Soru: params anahtar kelimesini kullanarak sınırsız sayıda double parametre alabilen
//ve bu sayılar arasındaki ortalamayı hesaplayan bir metot yazın.
//İpucu: params ile dizi gibi parametre alabilir ve döngü kullanarak ortalamayı hesaplayabilirsiniz.

static double ortalama(params double[] x)
{
    double toplam = 0;
    foreach (double i in x)
    {
        toplam = toplam + i;
    }
    return toplam / x.Length;
}



//6. Dizi Elemanlarını Toplayan ve Filtreleme Şartı Ekleyen Metot
//Soru: int türünde bir dizi ve bir filtre değeri(int) alan bir metot yazın.
//Bu metot, filtre değerinden büyük olan tüm elemanları toplasın ve toplamı döndürsün.
//İpucu: int türünde bir metot tanımlayıp foreach döngüsü ile filtreyi uygulayarak toplamı hesaplayabilirsiniz.

static int dizitoplamı(int[] a, int b)
{
    int toplam = 0;
    foreach (int i in a)
    {
        if (i > b)
            toplam = toplam + i;

    }
    return toplam;
}


//7. Seçmeli (Optional) Parametre ile Belirli Yaştan Sonraki Yılları Sayma
//Soru: Bir yaş değeri alan bir metot yazın.Eğer yaş belirtilmezse varsayılan olarak
//18 olsun ve metot, verilen yaşın 18’den ne kadar fazla olduğunu döndürsün.
//İpucu: int türünde bir metot tanımlayıp varsayılan parametre kullanarak yaşı hesaplayabilirsiniz.

static int yillarisayma(int yas)
{
    if (yas >= 18)
    {
        return yas - 18;
    }
    else if (0 < yas && yas < 18)
    {
        return yas - 18;
    }
    else
    {
        yas = 18;
        return yas - 18;
    }
}

//8. Geriye Koleksiyon Döndüren ve Veriyi Filtreleyen Metot
//Soru: string türünde bir dizi alan bir metot yazın.Bu metot, sadece
//uzunluğu 5 karakterden büyük olan elemanları içeren bir List<string> döndürsün.
//İpucu: List<string> türünde bir metot tanımlayarak döngü ile filtreleme yapabilirsiniz.


static List<string> bestenbuyuk(string[] a)
{
    List<string> yeniliste = new List<string>();
    foreach (string i in a)
    {
        if (i.Length > 5)
        {
            yeniliste.Add(i);
        }
    }

    return yeniliste;
}








    }


}