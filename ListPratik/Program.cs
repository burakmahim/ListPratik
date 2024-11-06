// Ziyaretçi isimlerini tutmak için bir liste oluştur
List<string> ziyaretciListesi = new List<string>();

// Ziyaretçilerin isimlerini listeye ekle
ziyaretciListesi.Add("Büülent Ersoy");
ziyaretciListesi.Add("Ajda Pekkan");
ziyaretciListesi.Add("Ebru Gündeş");
ziyaretciListesi.Add("Hadise");
ziyaretciListesi.Add("Hande Yener");
ziyaretciListesi.Add("Tarkan");
ziyaretciListesi.Add("Funda Arar");
ziyaretciListesi.Add("Demet Akalın");

// foreach döngüsü ile liste içerisindeki isimleri ekrana yazdır
Console.WriteLine("Ziyaretçi Listesi:");
foreach (string isim in ziyaretciListesi)
{
    Console.WriteLine(isim);
}