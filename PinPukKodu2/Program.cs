namespace PinPukKodu2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pinKodu = 1453, pukKodu = 7894, girilenPuk = 0, girilenPin = 0;

            for (int i = 3; i >= 1; i--)
            {
                Console.Write("Pin kodunu giriniz: ");
                girilenPin = int.Parse(Console.ReadLine());

                if (girilenPin != pinKodu && i != 1) Console.WriteLine("Pin kodu yanlış girildi. {0} hakkınız kaldı.", i - 1);

                else if (girilenPin != pinKodu && i == 1)
                {
                    Console.WriteLine("Pin kodunuz bloke oldu.");

                    for (int j = 10; j >= 1; j--)
                    {
                        Console.Write("Puk kodunu giriniz: ");
                        girilenPuk = int.Parse(Console.ReadLine());
                        if (girilenPuk != pukKodu && j != 1)
                        {
                            Console.WriteLine("Puk kodu yanlış girildi. {0} hakkınız kaldı.", j - 1);
                        }
                    }
                }
            }
        }
    }
}