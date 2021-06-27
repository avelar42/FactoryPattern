using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FACTORY PATTERN");
            Console.WriteLine("(1) BALA REVOLVER");
            Console.WriteLine("(2) BALA DOZE");
            Console.WriteLine("(3) BALA RIFLE");
            var tipoArma = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("SELECIONE TIPO DE BALA");
            Console.WriteLine("(1) NORMAL");
            Console.WriteLine("(2) APP");
            var tipoBala = Convert.ToInt32(Console.ReadLine());

            if(tipoBala == 1)
            {
                switch (tipoArma)
                {
                    case 1:
                        Console.WriteLine(new BalaRevolver().FabricarBalas());
                        break;
                    case 2:
                        Console.WriteLine(new BalaDeDoze().FabricarBalas());
                        break;
                    case 3:
                        Console.WriteLine(new BalaRifle().FabricarBalas());
                        break;
                }
            }
            else
            {
                switch (tipoArma)
                {
                    case 1:
                        Console.WriteLine(new BalaRevolver().FabricarBalasAP());
                        break;
                    case 2:
                        Console.WriteLine(new BalaDeDoze().FabricarBalasAP());
                        break;
                    case 3:
                        Console.WriteLine(new BalaRifle().FabricarBalasAP());
                        break;
                }
            }
            Console.Read();
        }
    }
}
