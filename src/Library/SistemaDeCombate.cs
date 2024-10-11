using System;
using System.Collections.Generic;
using Library.Interface;

namespace Library
{
    public class SistemaDeCombate
    {
        public void Combatir()
        {
            InicializarPlayers ejemplo = new InicializarPlayers();
            ejemplo.NombresPlayers();
            ejemplo.EquipoPlayers();
            ejemplo.PokemonInicial();
            Player jugador1 = ejemplo.Jugador();
            Player rival = ejemplo.Rival();

            while (jugador1.QuedanPokemons() && rival.QuedanPokemons())
            {
                turno(jugador1, rival);
                if (rival.QuedanPokemons())
                {
                    turno(rival, jugador1);
                }
            }

            Console.WriteLine("El juego ha terminado");
            Console.ReadLine();
        }

        public void Atacar(Player playerEnTurno, Player playerEnemigo)
        {
            IPokemon pokemonEnTurno = playerEnTurno.getSelectedPokemon();
            IPokemon pokemonEnemigo = playerEnemigo.getSelectedPokemon();
            List<IAtaque> habilidadesActuales = pokemonEnTurno.GetAbilities();

            Console.WriteLine("Elige tu Ataque:");
            int contador = 0;
            foreach (var habilidad in habilidadesActuales)
            {
                contador++;
                Console.WriteLine(contador + " - " + habilidad.GetNombre());
            }

            int ataqueElegido;
            if (int.TryParse(Console.ReadLine(), out ataqueElegido) && ataqueElegido > 0 && ataqueElegido <= 4)
            {
                IAtaque habilidadElegida = habilidadesActuales[ataqueElegido-1];
                int damage = ProcesamientoDaño(pokemonEnTurno, pokemonEnemigo, habilidadElegida);
                pokemonEnemigo.RecibirDaño(damage);
                Console.WriteLine($"Poder de ataque: {habilidadElegida.GetPower()}, Ataque del Pokémon: {pokemonEnTurno.GetAttack()}, Defensa del enemigo: {pokemonEnemigo.GetDefense()}");


                if (pokemonEnemigo.GetHealth() <= 0)
                {
                    playerEnemigo.EliminarPokemon(pokemonEnemigo);
                }
                
            }
            else
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 5);
                IAtaque habilidadElegida = habilidadesActuales[randomNumber-1];
                Console.WriteLine($"Eso no es un ataque, has usado {habilidadElegida.GetNombre()} de tu pokemon");
                
                int damage = ProcesamientoDaño(pokemonEnTurno, pokemonEnemigo, habilidadElegida);
                pokemonEnemigo.RecibirDaño(damage);
                Console.WriteLine($"Poder de ataque: {habilidadElegida.GetPower()}, Ataque del Pokémon: {pokemonEnTurno.GetAttack()}, Defensa del enemigo: {pokemonEnemigo.Defense}");

                
            }
            
        }


        public void turno(Player playerEnTurno, Player playerEnemigo)
        {
            IPokemon pokemonEnTurno = playerEnTurno.getSelectedPokemon();
            int vidaPokemonEnTurno = pokemonEnTurno.GetHealth();

            if (vidaPokemonEnTurno <= 0)
            {
                playerEnTurno.EliminarPokemon(pokemonEnTurno);
                if (playerEnTurno.QuedanPokemons())
                {
                    playerEnTurno.cambiarPokemon();
                    pokemonEnTurno = playerEnTurno.getSelectedPokemon();
                    vidaPokemonEnTurno = pokemonEnTurno.GetHealth();
                }
                else
                {
                    Console.WriteLine($"{playerEnTurno.getNombre()} no tiene más Pokémon para combatir.");
                    return; // Termina el turno si no hay más Pokémon
                }
            }

            Console.WriteLine($"Es tu turno, {playerEnTurno.getNombre()}.");
            Console.WriteLine($"Tu Pokémon es {pokemonEnTurno.GetName()} y tiene {vidaPokemonEnTurno} de vida.");
            Console.WriteLine("Pulsa A para atacar O B para cambiar");

            string entrada = Console.ReadLine()?.ToUpper();
            if (entrada == "A")
            {
                Atacar(playerEnTurno, playerEnemigo);
            }
            else 
            {
                playerEnTurno.cambiarPokemon();
                pokemonEnTurno = playerEnTurno.getSelectedPokemon();
            }
        }

        public int ProcesamientoDaño(IPokemon pokemonactual,IPokemon pokemonenemigo ,IAtaque habilidad)
        {   
            int valorDeDañoPokemon = pokemonactual.GetAttack();
            int valorDePotenciaHabilidad = habilidad.GetPower();
            int dañoTotalPokemon = Math.Max(0, valorDeDañoPokemon + valorDePotenciaHabilidad - pokemonenemigo.GetDefense());

            return dañoTotalPokemon;
        }

    }
}
