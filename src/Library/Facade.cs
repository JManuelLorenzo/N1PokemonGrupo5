using System;
using Library.Interface;

namespace Library
{
    public class Facade
    {
       

        public Facade() { }

        public void Start()
        {
            
             SistemaDeCombate combate = new SistemaDeCombate();
             combate.Combatir();

        }
        }
    }
