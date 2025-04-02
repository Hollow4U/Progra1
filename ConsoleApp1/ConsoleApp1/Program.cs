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
       

        static void Main(string[] args)
        {
            character.Add(new Characters("David",20,3,2));
            character.Add(new Characters("Victor",10, 5, 8));

            character[1].attack(0);
        }
        
    }
}
