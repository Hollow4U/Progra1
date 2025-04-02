﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Characters
    {
        protected string name;
        protected int vida;
        protected int daño;
        protected int ac;

        public Characters(string name, int vida, int daño, int ac)
        {
            this.name = name;   
            this.vida = vida;
            this.daño = daño;
            this.ac = ac;
        }

        public virtual void lostLife(int hp)
        {
            vida -= hp;
            Console.WriteLine($"{name} ha perdido {hp} de vida");
            Console.WriteLine($"Ahorta tiene {vida}");
        }

        public virtual void attack(int i)
        {
            Console.WriteLine($"{name} ataca a {Program.character[i].name}");
            Random random = new Random();
            int ranNum  = random.Next(1, 21);

            if (ranNum >= Program.character[i].ac)
            {
                Console.WriteLine($"{name} impacta a {Program.character[i].name}");
                Program.character[i].lostLife(damageCheck());
            }
            else
            {  
                Console.WriteLine($"{name} falla al atacar a {Program.character[i].name}");
            }
        }

        public virtual int damageCheck()
        {
            int damagelimit = 0;
            Random random = new Random();

            for (int i = 0; i<daño; i++)
            {        
                damagelimit += random.Next(1, 5);
            }
            Console.WriteLine($"Tiras {daño}d4 ={damagelimit}");
            return damagelimit;
        } 
    }
}

