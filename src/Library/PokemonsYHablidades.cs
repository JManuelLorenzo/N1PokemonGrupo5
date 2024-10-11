using Library.Interface;

namespace Library;

public class PokemonsYHablidades
{
        List<IAtaque> ListaAtaque = new List<IAtaque>();
        List<IAtaque> ListaDeAtaqueFuego = new List<IAtaque>();
        List<IAtaque> ListaDeAtaqueAgua = new List<IAtaque>();
        List<IAtaque> ListaDeAtaqueTierra = new List<IAtaque>();
        List<IAtaque> ListaDeAtaquePlanta = new List<IAtaque>();
        Dictionary<int, IPokemon> pokemons1 = new Dictionary<int, IPokemon>(); // Quizas va en el constructor, hay que probarlo.
        Dictionary<int, IPokemon> pokemons2 = new Dictionary<int, IPokemon>();


        public void CrearPokemons()
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

        

        
        

                // Pokémon de fuego
                Pokemon P1Charizard = new Pokemon("Charizard", 5, 100, 15, ListaDeAtaqueFuego); // Defensa 65
                Pokemon P2Charizard = new Pokemon("Charizard", 5, 100, 15, ListaDeAtaqueFuego); // Defensa 65
                pokemons1.Add(1, P1Charizard);
                pokemons2.Add(1, P2Charizard);

// Pokémon de agua
                Pokemon P1Gyarados = new Pokemon("Gyarados", 7, 90, 12, ListaDeAtaqueAgua); // Defensa 79
                Pokemon P2Gyarados = new Pokemon("Gyarados", 7, 90, 12, ListaDeAtaqueAgua); // Defensa 79
                pokemons1.Add(2, P1Gyarados);
                pokemons2.Add(2, P2Gyarados);

// Pokémon de tierra
                Pokemon P1Golem = new Pokemon("Golem", 3, 85, 22, ListaDeAtaqueTierra); // Defensa 95
                Pokemon P2Golem = new Pokemon("Golem", 3, 85, 22, ListaDeAtaqueTierra); // Defensa 95
                pokemons1.Add(3, P1Golem);
                pokemons2.Add(3, P2Golem);

// Pokémon de planta
                Pokemon P1Venusaur = new Pokemon("Venusaur", 6, 60, 18, ListaDeAtaquePlanta); // Defensa 83
                Pokemon P2Venusaur = new Pokemon("Venusaur", 6, 60, 18, ListaDeAtaquePlanta); // Defensa 83
                pokemons1.Add(4, P1Venusaur);
                pokemons2.Add(4, P2Venusaur);

// Añadir más Pokémon
                Pokemon P1Blastoise = new Pokemon("Blastoise", 6, 70, 16, ListaDeAtaqueAgua); // Defensa 100
                Pokemon P2Blastoise = new Pokemon("Blastoise", 6, 70, 16, ListaDeAtaqueAgua); // Defensa 100
                pokemons1.Add(5, P1Blastoise);
                pokemons2.Add(5, P2Blastoise);

                Pokemon P1Arcanine = new Pokemon("Arcanine", 9, 60, 13, ListaDeAtaqueFuego); // Defensa 75
                Pokemon P2Arcanine = new Pokemon("Arcanine", 9, 60, 13, ListaDeAtaqueFuego); // Defensa 75
                pokemons1.Add(6, P1Arcanine);
                pokemons2.Add(6, P2Arcanine);

                Pokemon P1Torterra = new Pokemon("Torterra", 2, 60, 24, ListaDeAtaquePlanta); // Defensa 105
                Pokemon P2Torterra = new Pokemon("Torterra", 2, 60, 25, ListaDeAtaquePlanta); // Defensa 105
                pokemons1.Add(7, P1Torterra);
                pokemons2.Add(7, P2Torterra);



        }

        public Dictionary<int, IPokemon> DevolverDicP1()
        {
                return pokemons1;
        }

        public Dictionary<int, IPokemon> DevolverDicP2()
        {
            return pokemons2;
        }
        

}