using System;
using Library.Interface;

namespace Library
{
    public class Facade
    {
       

        public Facade() { }

        public void Start()
        {
             InicializarPlayers ejemplo = new InicializarPlayers();
             ejemplo.NombresPlayers();
             ejemplo.EquipoPlayers();
             ejemplo.PokemonInicial();

            }
        }
    }
