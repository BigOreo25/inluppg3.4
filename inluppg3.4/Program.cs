using System;
namespace inluppg34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tack för att du kontaktar KrebRadiostation AB. du verkar vilja spela upp en låt. hur många minuter är den? (skriv bara antalet minuter, inte sekunder)");
            int minut = int.Parse(Console.ReadLine());
            Console.WriteLine("Ok och hur många övriga sekunder lång är den?");
            int sekund = int.Parse(Console.ReadLine());
            
            if (minut>4 || minut==4 && sekund>20 || minut<2 || minut==2 && sekund<45)
            {
                Console.WriteLine("näe jag vill inte");
            }
            else
            {
                Console.WriteLine("Mäktigt val av låt, du kan förväntas höra den inom 3.14 minuter");
            }
        }

    }

}