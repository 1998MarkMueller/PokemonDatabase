using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Test_Use
{
    class PokemonStats
    {
        public string name;
        public int lvl;
        public string[] type;
        public int id;
        public string[] moveSet;
        public string picName;
        public string genIntroduced;
        public string species;

        public PokemonStats(string _name, int _lvl, string[] _type, int _id, string[] _moveSet, string _picName, string _genIntroduced, string _species)
        {
            name = _name;
            lvl = _lvl;
            type = _type;
            id = _id;
            moveSet = _moveSet;
            picName = _picName;
            genIntroduced = _genIntroduced;
            species = _species;
        }

        public static string[] allGenerations = { "Kanto (1)", "Johto (2)", "Hoenn (3)", "Sinnoh (4)", "Unova (5)", "Kalos (6)", "Alola (7)" };
        public static string[] allTypes = { "NORMAL", "FIRE", "FIGHTING", "WATER", "FLYING", "GRASS", "POISON", "ELECTRIC", "GROUND", "PSYCHIC", "ROCK", "ICE", "BUG", "DRAGON", "GHOST", "DARK", "STEEL", "FAIRY" };
        public static string[] allMoves = { "POUND", "KARATE CHOP", "DOUBLE SLAP", "COMET PUNCH", "MEGA PUNCH", "PAY DAY", "FIRE PUNCH", "ICE PUNCH", "THUNDER PUNCH", "SCRATCH", "VICE GRIP", "GUILLOTINE", "RAZOR WIND", "SWORDS DANCE", "CUT", "GUST", "WING ATTACK", "WHIRLWIND", "FLY" };
        //                                     0            1              2              3              4           5           6            7               8            9            10           11            12             13         14      15         16            17        18



    }
}
