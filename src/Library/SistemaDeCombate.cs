using Library.Interface;

namespace Library
{
    public class SistemaDeCombate
    {
        public void Combatir()
        {
            Print impresion = new Print();
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

            impresion.finDelJuego(); //Finaliza el juego
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
        Console.WriteLine($"{contador} - {habilidad.GetNombre()}");
    }

    int ataqueElegido = 0;
    bool ataqueValido = false;

    while (!ataqueValido)
    {
        Console.Write("Introduce el número de ataque: ");
        string entrada = Console.ReadLine();

        try
        {
            ataqueElegido = Convert.ToInt32(entrada);

            // Verificar el rango
            if (ataqueElegido < 1 || ataqueElegido > habilidadesActuales.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            IAtaque habilidadElegida = habilidadesActuales[ataqueElegido - 1];
            int damage = ProcesamientoDaño(pokemonEnTurno, pokemonEnemigo, habilidadElegida);
            pokemonEnemigo.RecibirDaño(damage);

            if (pokemonEnemigo.GetHealth() <= 0)
            {
                playerEnemigo.EliminarPokemon(pokemonEnemigo);
            }

            ataqueValido = true; // Solo se establece si la entrada es válida
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada no válida. Por favor, introduce un número entero.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("El número es demasiado grande. Por favor, introduce un número válido.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine($"Entrada no válida. Por favor, elige un número entre 1 y {habilidadesActuales.Count}.");
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("La habilidad seleccionada no existe. Por favor, inténtalo de nuevo.");
        }
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
            Console.WriteLine("Pulsa A para atacar o cualquier otra letra para cambiar a el pokemon");

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
