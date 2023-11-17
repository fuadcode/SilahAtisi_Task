
namespace Task2_Silah_atisi.Models
{
    public class SilahAtisi
    {
        public int GulleMiqdari = 32;

        public void GulleTekAtis()
        {
            int Daraq = 32;
            GulleMiqdari--;
            Console.WriteLine($"Gulle atildigca 1 eded mermi azalir {GulleMiqdari} /{Daraq}");


            if (GulleMiqdari == 0)
            {
                Console.WriteLine("Daraqdaki gulle sayi azalir..");
                ReloadMagazine();
                return;
            }
        }
        public void ReloadMagazine()
        {
            if (GulleMiqdari==32)
            {
                Console.WriteLine("Daraq tam doludur..");
                return;
            }
            GulleMiqdari = 32;
         }
        public void UcluAtis()
        {
            int Daraq = 32;
            GulleMiqdari = GulleMiqdari - 3;
            Console.WriteLine($"Gulle atildigca uc-uc azalir {GulleMiqdari} /{Daraq}");
           
            if (GulleMiqdari == 0)
            {
                Console.WriteLine("Daraqdaki gulle sayi azalir..");
               ReloadMagazine();
                return;
            }
        }
        public void MetodCagirmaq()
        {
            while (true)
            {
                ConsoleKeyInfo Metodinfo = Console.ReadKey();
                switch (Metodinfo.Key)
                {
                    case ConsoleKey.D:
                        GulleTekAtis();
                        break;
                    case ConsoleKey.U:
                        UcluAtis();
                        break;
                    case ConsoleKey.R:
                        ReloadMagazine();
                        break;
                }
            }
        }
        public void SilahiCagirmaq()
        {
            MetodCagirmaq();
        }
    }
}
