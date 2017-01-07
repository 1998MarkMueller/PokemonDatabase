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
    public partial class Form1 : Form
    {
        PokemonList pokemonList = new PokemonList();

        public Form1()
        {
            InitializeComponent();

            //Counts How Many Pokemon Are in the Database
            lblNumberOfPokemon.Text = "There are " + pokemonList.numOfPokemon.ToString() + " Pokemon available";

            //Displays the Names of All of the Pokemon in the Database
            for (var i = 0; i < pokemonList.numOfPokemon; i++){
                ltbPokemonData.Items.Add(pokemonList.listOfPokemon[i].name);
            }

        }

        //Changes Pokemon View With Each Selection Change
        private void ltbPokemonData_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            for (var i = 0; i < ltbPokemonData.Items.Count; i++)
            {
                //Checks Which Pokemon Was Selected
                if (ltbPokemonData.SelectedIndex == i)
                {
                    //Gets the Pokemons First Type
                    var pokemonType = pokemonList.listOfPokemon[i].type[0];

                    //Displays Data
                    lblPokemonSelectedName.Text = pokemonList.listOfPokemon[i].name;
                    lblFirstAppearedAmount.Text = pokemonList.listOfPokemon[i].genIntroduced;
                    lblSpeciesAmount.Text = pokemonList.listOfPokemon[i].species;
                    lblIDAmount.Text = pokemonList.listOfPokemon[i].id.ToString();

                    //Checks if Pokemon Has More Than One Type Then Display Correct Amount
                    for (var u = 0; u < pokemonList.listOfPokemon[i].type.Length; u++) {
                        if (u == 0)
                        {
                            lblTypeAmount.Text = pokemonList.listOfPokemon[i].type[u];
                        }
                        else
                        {
                            lblTypeAmount.Text += pokemonList.listOfPokemon[i].type[u];
                        }
                    }

                    //Displays the Correct Picture of the Pokemon
                    if (ltbPokemonData.SelectedItem.ToString() == pokemonList.listOfPokemon[0].name)
                    {
                        pcBPokemonPic.Image = Pokemon_Test_Use.Properties.Resources.picBulbasaur;
                    }
                    if (ltbPokemonData.SelectedItem.ToString() == pokemonList.listOfPokemon[1].name)
                    {
                        pcBPokemonPic.Image = Pokemon_Test_Use.Properties.Resources.picCharmander;
                    }
                    if (ltbPokemonData.SelectedItem.ToString() == pokemonList.listOfPokemon[2].name)
                    {
                        pcBPokemonPic.Image = Pokemon_Test_Use.Properties.Resources.picSquirtle;
                    }
                    if (ltbPokemonData.SelectedItem.ToString() == pokemonList.listOfPokemon[2].name)
                    {
                        pcBPokemonPic.Image = Pokemon_Test_Use.Properties.Resources.picSquirtle;
                    }
                    if (ltbPokemonData.SelectedItem.ToString() == pokemonList.listOfPokemon[3].name)
                    {
                        pcBPokemonPic.Image = Pokemon_Test_Use.Properties.Resources.picMetapod;
                    }
                    if (ltbPokemonData.SelectedItem.ToString() == pokemonList.listOfPokemon[4].name)
                    {
                        pcBPokemonPic.Image = Pokemon_Test_Use.Properties.Resources.picPikachu;
                    }
                    if (ltbPokemonData.SelectedItem.ToString() == pokemonList.listOfPokemon[5].name)
                    {
                        pcBPokemonPic.Image = Pokemon_Test_Use.Properties.Resources.picWailord;
                    }
                    if (ltbPokemonData.SelectedItem.ToString() == pokemonList.listOfPokemon[6].name)
                    {
                        pcBPokemonPic.Image = Pokemon_Test_Use.Properties.Resources.picConkeldurr;
                    }

                    //Changes the Background of the Form to Match the Pokemons Type
                    switch (pokemonType) {
                        case "WATER":
                            this.BackgroundImage = Pokemon_Test_Use.Properties.Resources.waterBackground;
                            break;
                        case "FIRE":
                            this.BackgroundImage = Pokemon_Test_Use.Properties.Resources.fireBackground;
                            break;
                        case "GRASS":
                            this.BackgroundImage = Pokemon_Test_Use.Properties.Resources.grassBackground;
                            break;
                        case "FIGHTING":
                            this.BackgroundImage = Pokemon_Test_Use.Properties.Resources.fightingBackground;
                            break;
                        case "BUG":
                            this.BackgroundImage = Pokemon_Test_Use.Properties.Resources.bugBackground;
                            break;
                        case "ELECTRIC":
                            this.BackgroundImage = Pokemon_Test_Use.Properties.Resources.electricBackground;
                            break;
                    }
                }
            } //End of For Loop
        }

        //Button Thats Shows FormAddNewPokemon Form
        private void btnAddNewPokemon_Click(object sender, EventArgs e)
        {
            FormAddNewPokemon addNewPokemon = new FormAddNewPokemon();
            addNewPokemon.Show();
        }
    }
}
