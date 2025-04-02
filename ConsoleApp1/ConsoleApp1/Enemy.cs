using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Enemy : Characters
    {
        public Enemy(string name, int vida, int daño, int ac) : base (name,vida,daño,ac)
        {
            this.name = name;
            this.vida = vida;
            this.daño = daño;
        } 
    }
}
