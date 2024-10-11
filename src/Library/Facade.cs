using System;
using Library.Interface;

namespace Library
{
    public class Facade
    {
        public Facade() { }
        public void Start()
        {
            while (true)
            {
                Print impresion = new Print();
                impresion.startPrint();
                string inicialInput = Console.ReadLine();
                int inicial = Convert.ToInt32(inicialInput);
                
                if (inicial == 2)
                {
                    impresion.endPrint();
                    break;
                }
                else if (inicial == 1)
                {
                    SistemaDeCombate combate = new SistemaDeCombate();
                    combate.Combatir();
                }
                else
                {
                    Console.WriteLine("Por favor, introduce un número válido (1 o 2).");
                    Console.WriteLine("Presiona cualquier tecla para intentar de nuevo...");
                    Console.ReadKey(); // Esperar a que el usuario presione una tecla antes de continuar
                }
            }
        }
    }
}
