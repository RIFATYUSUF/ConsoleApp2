namespace methodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proudact urun1 = new Proudact();
            urun1.Id = 1;
            urun1.UrunAdi = "Elma";
            urun1.Fiyati = 21;
            urun1.Aciklama = "Amasya elması ";

            Proudact urun2 = new Proudact();
            urun2.Id = 1;
            urun2.UrunAdi = "Karpuz";
            urun2.Fiyati = 21;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Proudact[] urunler = new Proudact[] {urun1 ,urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi);
            }

            Console.WriteLine("------------------Metodlar------------------");
            sepetManager sepet = new sepetManager();
            sepet.Ekle(urun1);
            sepet.Ekle(urun2);
        }
    }
}
