using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Test_Use
{
    public partial class FormAddNewPokemon : Form
    {
        

        public FormAddNewPokemon()
        {
            InitializeComponent();

            for (var i = 0; i < PokemonStats.allGenerations.Length; i++)
            {
                lsbRegion.Items.Add(PokemonStats.allGenerations[i]);
            }
            for (var i = 0; i < PokemonStats.allMoves.Length; i++)
            {
                lsbMoves.Items.Add(PokemonStats.allMoves[i]);
            }
            for (var i = 0; i < PokemonStats.allTypes.Length; i++)
            {
                lsbType.Items.Add(PokemonStats.allTypes[i]);
            }
        }

        private void btnAddPokemon_Click(object sender, EventArgs e)
        {
            
        }
    }
}
