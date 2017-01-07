using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Test_Use
{
    class PokemonList
    {
        public PokemonStats[] listOfPokemon;

        public int numOfPokemon;

        public PokemonStats bulbasaur = new PokemonStats("Bulbasaur", 5, new string[] { PokemonStats.allTypes[5], PokemonStats.allTypes[6] }, 1, new string[] { PokemonStats.allMoves[0], PokemonStats.allMoves[7], PokemonStats.allMoves[2], PokemonStats.allMoves[10] }, "picBulbasaur", PokemonStats.allGenerations[0], "Seed Pokémon");
        public PokemonStats charmander = new PokemonStats("Charmander", 5, new string[] { PokemonStats.allTypes[1] }, 4, new string[] { PokemonStats.allMoves[6], PokemonStats.allMoves[14], PokemonStats.allMoves[9], PokemonStats.allMoves[3] }, "picCharmander", PokemonStats.allGenerations[0], "Lizard Pokémon");
        public PokemonStats squirtle = new PokemonStats("Squirtle", 5, new string[] { PokemonStats.allTypes[3] }, 7, new string[] { PokemonStats.allMoves[7], PokemonStats.allMoves[0], PokemonStats.allMoves[14], PokemonStats.allMoves[9] }, "picSquirtle", PokemonStats.allGenerations[0], "Tiny Turtle Pokémon");
        public PokemonStats metapod = new PokemonStats("Metapod", 5, new string[] { PokemonStats.allTypes[12] }, 11, new string[] { PokemonStats.allMoves[7], PokemonStats.allMoves[0], PokemonStats.allMoves[14], PokemonStats.allMoves[9] }, "picMetapod", PokemonStats.allGenerations[0], "Cocoon Pokémon");
        public PokemonStats pikachu = new PokemonStats("Pikachu", 5, new string[] { PokemonStats.allTypes[7] }, 25, new string[] { PokemonStats.allMoves[7], PokemonStats.allMoves[0], PokemonStats.allMoves[14], PokemonStats.allMoves[9] }, "picPikachu", PokemonStats.allGenerations[0], "Mouse Pokémon" );
        public PokemonStats wailord = new PokemonStats("Wailord", 5, new string[] { PokemonStats.allTypes[3] }, 7, new string[] { PokemonStats.allMoves[7], PokemonStats.allMoves[0], PokemonStats.allMoves[14], PokemonStats.allMoves[9] }, "picWailord", PokemonStats.allGenerations[2], "Float Whale Pokémon");
        public PokemonStats conkeldurr = new PokemonStats("Conkeldurr", 5, new string[] { PokemonStats.allTypes[2] }, 7, new string[] { PokemonStats.allMoves[7], PokemonStats.allMoves[0], PokemonStats.allMoves[14], PokemonStats.allMoves[9] }, "picConkeldurr", PokemonStats.allGenerations[4], "Muscular Pokémon");

        public PokemonList()
        {
            listOfPokemon = new PokemonStats[] { bulbasaur, charmander, squirtle, metapod, pikachu, wailord, conkeldurr };
            numOfPokemon = listOfPokemon.Length;
        }

        public PokemonList(string _name, int _lvl, string[] _type, int _id, string[] _moveSet, string _picName, string _genIntroduced, string _species)
        {
         
        }
    }
}
