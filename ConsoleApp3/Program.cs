using System.ComponentModel;
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");
/*
Kullanıcı bilgisayara taş/kağıt/makas'dan birini yazsın. 
Bilgisayarda rastgele bunlardan birini söylesin. 
Klavyeden kullanıcı bitti yazana kadar oyun tekrar etsin. Bitirirken oyun kaç kare oynandı ekrana yazdırın. 
Kim kazandıysa ekrana kazananı yazsın. 
Oyun bitince kullanıcı kaç kere kazandı bilgisayar kaç kere kazandı yazın.
*/

String[] objeler = new string[3] { "tas", "kagit", "makas" };
List<string> ekleme = new List<string>();
Boolean ObjeSectiMi = false;
int tur = 0;
string girilen = "";
int bilgisayarKazanmaAdeti = 0;
int berabere = 0;
int kullaniciKazanmaAdeti = 0;
while (true)
{
    ObjeSectiMi = false;
    do
    {
        Console.Write("hangisini seçiyorsun?: ");
        girilen = Console.ReadLine();
        if (girilen.ToLower() == "bitti")
        {
            break;
        }
        for (int i = 0; i < objeler.Length; i++)
        {
            if (girilen.ToLower() == objeler[i].ToLower())
            {
                ObjeSectiMi = true;
                break;

            }
        }
        if (ObjeSectiMi == false)
        {
            Console.WriteLine("Lütfen taş, kağıt, makas dan birini yazın.");
        }
    } while (ObjeSectiMi == false);
    if (ObjeSectiMi == false)
    {
        break;
    }

    tur += 1;
    int rastgeleSayi = Random.Shared.Next(0, 3);
    Console.WriteLine("Bilgisayarın seçimi : " + objeler[rastgeleSayi]);


    if (objeler[rastgeleSayi].ToLower() == "tas" && girilen.ToLower() == "makas"
        || objeler[rastgeleSayi].ToLower() == "makas" && girilen.ToLower() == "kagit"
        || objeler[rastgeleSayi].ToLower() == "kagit" && girilen.ToLower() == "tas")
    {
        ekleme.Add("bilgisayar kazandı ");

        Console.WriteLine("bilgisayar kazandı   " + tur.ToString() + ".oyun sonucu");
        bilgisayarKazanmaAdeti++;
    }
    else if (objeler[rastgeleSayi].ToLower() == girilen.ToLower())
    {
        ekleme.Add("berabere ");

        Console.WriteLine("berabere   " + tur.ToString() + ".oyun sonucu");
        berabere++;
    }
    else
    {
        ekleme.Add("kullanıcı kazandı");
        Console.WriteLine("kullanıcı kazandı   " + tur.ToString() + ".oyun sonucu");
        kullaniciKazanmaAdeti++;
    }
    {

    }
}

Console.WriteLine("Oyun kaç kere oynandı: " + tur.ToString());
Console.WriteLine("Oyuncu kazanma sayısı: " + kullaniciKazanmaAdeti.ToString());
Console.WriteLine("Bilgisayar kazanma sayısı: " + bilgisayarKazanmaAdeti.ToString());
Console.WriteLine("berabere sonucu  :" + berabere.ToString());
foreach (string sonuc in ekleme)
{
    Console.WriteLine(sonuc);
}


Console.WriteLine("Hello, World!");
