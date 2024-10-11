using Library.Interface;
using System;
namespace Library;

public class Batalla
{
        List<IAtaque> ListaAtaque = new List<IAtaque>();
        List<IAtaque> ListaDeAtaqueFuego = new List<IAtaque>();
        List<IAtaque> ListaDeAtaqueAgua = new List<IAtaque>();
        List<IAtaque> ListaDeAtaqueTierra = new List<IAtaque>();
        List<IAtaque> ListaDeAtaquePlanta = new List<IAtaque>();
        Dictionary<string, IPokemon> pokemons1; // Quizas va en el constructor, hay que probarlo.
        Dictionary<string, IPokemon> pokemons2;


        public void CrearAtaques()
        {
                // Ataques de Agua
                Ataque Hidrobomba = new Ataque(90, false, "Hidrobomba");
                Ataque ChorroDeAgua = new Ataque(50, true, "Chorro de Agua");
                Ataque TormentaDeAgua = new Ataque(80, false, "Tormenta de Agua");
                Ataque Maremoto = new Ataque(100, false, "Maremoto");

// Ataques de Fuego
                Ataque BolaDeFuego = new Ataque(70, true, "Bola de Fuego");
                Ataque ExplosiónLlamas = new Ataque(85, true, "Explosión de Llamas");
                Ataque LlamaInfernal = new Ataque(90, true, "Llama Infernal");
                Ataque FuegoSagrado = new Ataque(75, true, "Fuego Sagrado");

// Ataques de Tierra
                Ataque Terremoto = new Ataque(100, false, "Terremoto");
                Ataque RocaCañón = new Ataque(80, false, "Roca Cañón");
                Ataque TierraTemblorosa = new Ataque(60, false, "Tierra Temblorosa");
                Ataque Estalactita = new Ataque(70, true, "Estalactita");

// Ataques de Planta
                Ataque HojaAfilada = new Ataque(60, true, "Hoja Afilada");
                Ataque RaícesAtrapantes = new Ataque(75, false, "Raíces Atrapantes");
                Ataque TormentaVerdosa = new Ataque(90, false, "Tormenta Verdosa");
                Ataque PétalosLacerantes = new Ataque(50, true, "Pétalos Lacerantes");

                // Lista de ataques de Agua
                ListaDeAtaqueAgua.Add(Hidrobomba);
                ListaDeAtaqueAgua.Add(ChorroDeAgua);
                ListaDeAtaqueAgua.Add(TormentaDeAgua);
                ListaDeAtaqueAgua.Add(Maremoto);

// Lista de ataques de Fuego
                ListaDeAtaqueFuego.Add(BolaDeFuego);
                ListaDeAtaqueFuego.Add(ExplosiónLlamas);
                ListaDeAtaqueFuego.Add(LlamaInfernal);
                ListaDeAtaqueFuego.Add(FuegoSagrado);

// Lista de ataques de Tierra
                ListaDeAtaqueTierra.Add(Terremoto);
                ListaDeAtaqueTierra.Add(RocaCañón);
                ListaDeAtaqueTierra.Add(TierraTemblorosa);
                ListaDeAtaqueTierra.Add(Estalactita);

// Lista de ataques de Planta
                ListaDeAtaquePlanta.Add(HojaAfilada);
                ListaDeAtaquePlanta.Add(RaícesAtrapantes);
                ListaDeAtaquePlanta.Add(TormentaVerdosa);
                ListaDeAtaquePlanta.Add(PétalosLacerantes);

        }

        public void CrearPokemons()
        {

                // Pokémon de fuego
                Pokemon P1Charizard = new Pokemon(5, 10, ListaDeAtaqueFuego);
                Pokemon P2Charizard = new Pokemon(5, 10, ListaDeAtaqueFuego);
                pokemons1.Add("Charizard", P1Charizard);
                pokemons2.Add("Charizard", P2Charizard);

                // Pokémon de agua
                Pokemon P1Gyarados = new Pokemon(6, 9, ListaDeAtaqueAgua);
                Pokemon P2Gyarados = new Pokemon(6, 9, ListaDeAtaqueAgua);
                pokemons1.Add("Gyarados", P1Gyarados);
                pokemons2.Add("Gyarados", P2Gyarados);

                // Pokémon de tierra
                Pokemon P1Golem = new Pokemon(7, 8, ListaDeAtaqueTierra);
                Pokemon P2Golem = new Pokemon(7, 8, ListaDeAtaqueTierra);
                pokemons1.Add("Golem", P1Golem);
                pokemons2.Add("Golem", P2Golem);

                // Pokémon de planta
                Pokemon P1Venusaur = new Pokemon(5, 10, ListaDeAtaquePlanta);
                Pokemon P2Venusaur = new Pokemon(5, 10, ListaDeAtaquePlanta);
                pokemons1.Add("Venusaur", P1Venusaur);
                pokemons2.Add("Venusaur", P2Venusaur);

                // Añadir más Pokémon
                Pokemon P1Blastoise = new Pokemon(6, 10, ListaDeAtaqueAgua);
                Pokemon P2Blastoise = new Pokemon(6, 10, ListaDeAtaqueAgua);
                pokemons1.Add("Blastoise", P1Blastoise);
                pokemons2.Add("Blastoise", P2Blastoise);

                Pokemon P1Arcanine = new Pokemon(7, 10, ListaDeAtaqueFuego);
                Pokemon P2Arcanine = new Pokemon(7, 10, ListaDeAtaqueFuego);
                pokemons1.Add("Arcanine", P1Arcanine);
                pokemons2.Add("Arcanine", P2Arcanine);

                Pokemon P1Torterra = new Pokemon(8, 10, ListaDeAtaquePlanta);
                Pokemon P2Torterra = new Pokemon(8, 10, ListaDeAtaquePlanta);
                pokemons1.Add("Torterra", P1Torterra);
                pokemons2.Add("Torterra", P2Torterra);

        }

    
}