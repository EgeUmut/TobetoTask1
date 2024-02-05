//Pair 6
Start:
Console.WriteLine("\n\n------------------------\n\n");

Console.WriteLine("Hangi ödevi görmek istersiniz ?: ");
Console.WriteLine("1- Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.\r\n2- kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.(döngü için for döngüsü kullanınız)\r\n3- Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.\r\n4- Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.\r\n5- String metotlarını araştırınız. Her bir metot için örnek yapınız.\r\n6- Bir mağazada alınan ürünün fiyatı 300 tl üzerinde ise 50 tl olan kargo ücreti alınmamaktadır. ürünün fiyatı girildiğinde toplam ödemesi gereken tutarı gösteren programı yazınız.\r\n7- iki ürünün kullanıcı tarafından fiyatı girildiğinde toplam fiyat 500 tl'den fazla ise 2.üründen %40 indirim yaparak ödenecek tutarı gösteren uygulamayı yazınız.\r\n8- 1-200 arası içinde 3'e veya 5'e tam bölünebilen sayıları listeleyen ve kaç adet olduğunu yazdıran programı yazınız.\n 9- Çıkmak için");
int homeWorkNumber = Convert.ToInt32(Console.ReadLine());
Console.Clear();
if (homeWorkNumber == 1)
{
    int orderNumber = Convert.ToInt32(Console.ReadLine());
    switch (orderNumber)
    {
        case 1:
            Console.WriteLine("1.Numaralı siparişinizin ürünleri şunlardır.");
            break;
        case 2:
            Console.WriteLine("2.Numaralı siparişinizin ürünleri şunlardır.");
            break;
        case 3:
            Console.WriteLine("3.Numaralı siparişinizin ürünleri şunlardır.");
            break;
        case 4:
            Console.WriteLine("4.Numaralı siparişinizin ürünleri şunlardır.");
            break;
        case 5:
            Console.WriteLine("5.Numaralı siparişinizin ürünleri şunlardır.");
            break;
        default:
            Console.WriteLine("Yanlış değer girdiniz!");
            break;
    }
}
else if (homeWorkNumber == 2)
{
    Console.WriteLine("Lütfen kaç ürün almak istediğinizi giriniz: ");
    int productCount = Convert.ToInt32(Console.ReadLine());
    double result = 0;
    for (int i = 1; i <= productCount; i++)
    {
        Console.WriteLine(i + ".ürünün fiyatını giriniz: ");
        result += Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine("Toplam alışveriş tutarı: " + result);

}
else if (homeWorkNumber == 3)
{
    int number = 0;
    int sayac = 0;
    do
    {
        Console.WriteLine("Lütfen " + (number + 1) + ". kişinin yaşını giriniz: ");
        int yas = Int32.Parse(Console.ReadLine());

        if (yas >= 20)
        {
            sayac++;
        }
        number++;
    } while (number < 10);

    Console.WriteLine("Askere gidebilen kişi sayısı=" + sayac);
    Console.WriteLine("Askere gidemeyen kişi sayısı=" + (10 - sayac));
    Console.ReadLine();

}
else if (homeWorkNumber == 4)
{
    Console.WriteLine("Sayı giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());
    int toplam = 0;
    for (int i = 1; i < sayi; i++)
    {
        if (sayi % i == 0)
        {
            toplam = toplam + i;
        }
    }
    if (toplam == sayi)
    {
        Console.WriteLine(sayi + " sayısı Mükemmel Sayıdır");
    }
    else
    {
        Console.WriteLine(sayi + " sayısı Mükemmel Sayı Değildir");
    }
}
else if (homeWorkNumber == 5)
{
    string metin = "     Bugün .NET FullStack eğitimimizin .Net bölümünün ilk dersine başladık ve ödevi yapmak için çok çalışıyoruz.         ";
    string metin2 = "Tobeto Mometo alarko kombi gerçek kombi gerçek komfor. Tut Şunun Ucunu Döşiyelim abi. Deneme";
    string[] text = { "C#", "Java", "C++" };
    char[] charList;
    bool isTrue;

    Console.WriteLine(metin.Trim());
    Console.WriteLine(metin.ToLower());
    Console.WriteLine(metin.ToUpper());
    Console.WriteLine(metin.Any());
    Console.WriteLine(metin.Replace(".", ","));
    Console.WriteLine(metin.LastIndexOf("a"));
    Console.WriteLine(String.Compare(metin, metin2));
    Console.WriteLine(String.Concat(metin,metin2));
    Console.WriteLine(metin.Contains(".NET"));
    Console.WriteLine(metin.Contains(".ASD"));
    Console.WriteLine(metin2.EndsWith("Deneme"));
    Console.WriteLine(String.Equals(metin, metin2));
    Console.WriteLine(String.Format("Format: {0}",metin));
    Console.WriteLine(metin2.IndexOf("Deneme"));
    Console.WriteLine(String.Join(" ", text));
    Console.WriteLine(metin2.PadLeft(9));
    Console.WriteLine(metin2.PadRight(9));
    Console.WriteLine(metin2.Remove(5));
    Console.WriteLine(metin2.StartsWith("Tobeto"));
    Console.WriteLine(metin2.Substring(0,15));
    charList = metin2.ToCharArray();
    foreach (var item in charList)
    {
        Console.Write(item + ",");
    }

}
else if (homeWorkNumber == 6)
{
    Console.WriteLine("Ürün fiyatını giriniz: ");

    int sayiForSix = Convert.ToInt32(Console.ReadLine());
    if (sayiForSix > 300)
        Console.WriteLine("toplam tutar: " + sayiForSix);
    else
        Console.WriteLine("toplam tutar (kargo dahil): " + (sayiForSix + 50));
}
else if (homeWorkNumber == 7)
{
    Console.WriteLine("1.Ürün fiyatını giriniz: ");
    double productOnePrice = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("2.Ürün fiyatını giriniz: ");
    double productTwoPrice = Convert.ToDouble(Console.ReadLine());
    double resultForSeven;
    if (productOnePrice + productTwoPrice > 500)
    {
        resultForSeven = productOnePrice + (productTwoPrice * 0.4);
        Console.WriteLine("1. ürün fiyatı: " + productOnePrice + " 2.ürün fiyatı(%40 indirimli): " + (productTwoPrice * 0.4) + " Toplam fiyat: " + resultForSeven);
    }
    else
    {
        resultForSeven = productOnePrice + productTwoPrice;
        Console.WriteLine("1. ürün fiyatı: " + productOnePrice + " 2.ürün fiyatı: " + productTwoPrice + " Toplam fiyat: " + resultForSeven);
    }
}
else if (homeWorkNumber == 8)
{
    List<int> list = new List<int>();
    for (int i = 1; i <= 200; i++)
    {
        if (i % 3 == 0 || i % 5 == 0)
        {
            list.Add(i);
        }
    }
    Console.WriteLine("toplam sayı sayısı: " + list.Count());
    Console.WriteLine("List: ");
    foreach (int i in list)
        Console.WriteLine(i);
}
else
{
    return;
}

goto Start;

//1 - Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.

//2 - kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.(döngü için for döngüsü kullanınız)

//3 - Do - While ve While döngüsü nedir? Bununla ilgili örnek yapınız.




//4 - Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.



//5 - String metotlarını araştırınız. Her bir metot için örnek yapınız.



//6 - Bir mağazada alınan ürünün fiyatı 300 tl üzerinde ise 50 tl olan kargo ücreti alınmamaktadır.ürünün fiyatı girildiğinde toplam ödemesi gereken tutarı gösteren programı yazınız.


//7 - iki ürünün kullanıcı tarafından fiyatı girildiğinde toplam fiyat 500 tl'den fazla ise 2.üründen %40 indirim yaparak ödenecek tutarı gösteren uygulamayı yazınız.


//8 - 1 - 200 arası içinde 3'e veya 5'e tam bölünebilen sayıları listeleyen ve kaç adet olduğunu yazdıran programı yazınız.


//Ödevleri yaptıktan sonra github adresinize atıp sisteme yükleyebilirsiniz. Github linkinizi txt dosyasına atıp sisteme yükleyiniz. 





