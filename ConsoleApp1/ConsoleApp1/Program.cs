using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static  List<Characters> character = new List<Characters>();
        public static List<PC> pc = new List<PC>();

        static void Main(string[] args)
        {
            Console.WriteLine("¿Como te llamas?");
            string name = Console.ReadLine();

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("¿Que arma te gusta mas? Escribe el numero");
                Console.WriteLine("1. Hacha de mano");
                Console.WriteLine("2. Espada Corta");
                Console.WriteLine("3. Arco corto");

                string option = Console.ReadLine();
                int weapondmg = 0;
                int weaponhit = 0;

                switch (option)
                {
                    case "1":
                        weapondmg = 6;
                        weaponhit = 2;
                        salir = true;
                        break;
                    case "2":
                        weapondmg = 4;
                        weaponhit = 4;
                        salir = true;
                        break;
                    case "3":
                        weapondmg = 2;
                        weaponhit = 6;
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
               pc.Add(new PC(name,20,weapondmg,10,weaponhit));
            }

            character.Add(new Characters("Victor",10, 5, 8));

            pc[0].attack(0);
        }
        
    }
}
