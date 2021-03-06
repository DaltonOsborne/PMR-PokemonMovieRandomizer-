using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMR__PokemonMovieRandomizer_
{
    public partial class Form1 : Form
    {
        public List<Movie> Movies=new List<Movie> { new Movie { Name = "Pokemon: The First Movie" },
            new Movie { Name = "Pokémon: The Movie 2000" },
            new Movie { Name = "Pokémon 3: The Movie - Spell of the Unown" },
            new Movie { Name = "Pokémon 4Ever: Celebi - Voice of the Forest" },
            new Movie { Name = "Pokémon Heroes: Latios and Latias" },
            new Movie {Name = "Jirachi—Wish Maker" },
            new Movie {Name = "Destiny Deoxys" },
            new Movie {Name = "Lucario and the Mystery of Mew" },
            new Movie {Name = "Pokemon Ranger and the Temple of the Sea" },
            new Movie {Name = "The Rise of Darkrai" },
            new Movie {Name = "Giratina and the Sky Warrior" },
            new Movie {Name = "Arceus and the Jewel of Life" },
            new Movie {Name = "Zoroark--Master of Illusions" },
            new Movie {Name = "White--Victini and Zekrom" },
            new Movie {Name = "Black--Victini and Reshiram" },
            new Movie {Name = "Kyruem vs.the Sword of Justice" },
            new Movie {Name = "Genesect and the Legend Awakened" },
            new Movie {Name = "Diancie and the Coccoon of Destruction" },
            new Movie {Name = "Hoopa and the Clash of Ages" },
            new Movie {Name = "Volcanion and the MEchanical Marvel" },
            new Movie {Name = "I Choose You!" },
            new Movie {Name = "The Power of Us" },
            new Movie {Name = "Mewtwo Strikes Back:Evolution" },new Movie {Name = "Secrets of the Jungle" } };
         
        public Form1()
        {
            InitializeComponent();

            Movies.ForEach(movie => { listBox1.Items.Add(movie.Name); });    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random Movie = new Random();
            int i = listBox1.Items.Count;
            int chosenItem = Movie.Next(0, 24);

            listBox1.SelectedIndex = chosenItem;

            MessageBox.Show("The movie is: " + listBox1.SelectedItem.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
