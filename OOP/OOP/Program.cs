using OOP.Models;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(ShipStatus.Name + "Kargo Sirketi");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Sipariş Alındı");
            Task.Delay(1000).Wait();
            Console.WriteLine("Siparişiniz Hazırlandı");
            Task.Delay(2000).Wait();
            Console.WriteLine("Siparişiniz Kargoye Verildi");
            Task.Delay(3000).Wait();
            Console.WriteLine("Siparişin Teslimat Noktasında");
            Task.Delay(1000).Wait();
            Console.WriteLine("Siparişiniz Teslimat İçin Yolda");
            Task.Delay(4000).Wait();
            Console.WriteLine("Siparişiniz Teslim Edildi");


        }
    }
}