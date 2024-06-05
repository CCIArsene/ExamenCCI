using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenCCI.Model;
using ExamenCCI.Controls;

namespace ExamenCCI
{
    public partial class MainForm : Form
    {
        List<Band> bands = new List<Band>();

        public MainForm()
        {
            // BANDS CREATION
            var date1 = new DateTime(2023, 07, 17, 17, 30, 0);
            Band band1 = new Band("Royaume-Uni",date1, "Un duo de Londoniennes badass comme on les aime ! Amy Love et Georgia South, reines de l’urban punk, sont dotées d’un indéniable panache et d’une volonté d’embras(s)er dans un geste plein de fureur 30 ans de contestation sonore made in England : agressivité politique du punk, verve provocatrice du grime, hédonisme expérimental de la bass music. Sur scène, le duo offre des performances dopées aux riffs et aux lignes de basses de plus en plus lourdes avec une énergie contagieuse ! Le public est secoué !",
                                "Hip Hop", 1, "Nova Twins", Properties.Resources.nova_twins, "Kerouac");

            var date2 = new DateTime(2023, 07, 17, 18, 45, 0);
            Band band2 = new Band("France", date2, "Skip The Use, le fameux groupe de rock lillois, effectue son grand retour après 2 ans d'absence avec un nouvel album et une nouvelle tournée, Human Disorder. L'album, intense, paradoxal, aux émotions qui s’entrechoquent, s'écoute comme une traversée des ténèbres pour accéder à la lumière, celle qui fait de nous des Hommes. Human Disorder nous montre encore une fois toute l’efficacité et la puissance de Skip the Use, un groupe taillé pour la scène, son terrain de prédilection.",
                                "Rock", 2, "Skip The Use", Properties.Resources.skip_the_use, "Glenmor");

            var date3 = new DateTime(2023, 07, 17, 20, 00, 0);
            Band band3 = new Band("France", date3, "Fer de lance de la scène rock / hip hop de 1995 à 2010 avec des titres et des clips qui résonnent encore aujourd’hui (Cours vite, Va y avoir du Sport, Tant que parle l’Economie, Guérilla…), Silmarils est de retour en studio avec son nouvel album, RunFast, disponible en avril, et sur scène ! Et qui plus est, dans sa formation originelle, emmenée par son leader David Salsedo. Ce lundi sera survitaminé ou ne sera pas !",
                                "Rock / Hip Hop", 3, "Silmarils", Properties.Resources.silmarils, "Kerouac");

            var date4 = new DateTime(2023, 07, 17, 20, 30, 0);
            Band band4 = new Band("USA", date4, "Anthony Kiedis, Flea et Chad Smith retrouvent John Frusciante, a.k.a le meilleur guitariste du monde, pour jouer leurs immenses tubes (Californication, Snow, Can’t stop, Under the Bridge, Give it away…) et présenter leur dernier album, Return of the Dream Canteen. Généreux, libres et surprenants, les Californiens forgés pour la scène ont encore l’énergie dévastatrice de gamins survoltés. Rendez-vous à Kerampuilh pour un concert qui s’annonce déjà historique !",
                                "Funk Rock", 4, "Red Hot Chili Peppers", Properties.Resources.red_hot_chili_peppers, "Glenmor");

            var date5 = new DateTime(2023, 07, 17, 00, 20, 0);
            Band band5 = new Band("France", date5, "15 ans de carrière, plus de 67 pays visités, 1200 concerts en totale auto-production et déjà le 9e album Horizon ! Enregistré en trois semaines à Nashville et produit à nouveau par Vance Powell (Raconters, Stapleton, Jack White), ce nouvel opus s'inspire d'événements et d'expériences survenus dans la vie du duo, qui continue de militer contre la voracité de l'industrie agro-alimentaire et décrit le combat permanent des agriculteurs contre un système absurde qui appelle parfois à la désobéissance civile, le tout avec une énergie sans faille !",
                                "Rock'n Roll", 5, "The Inspector Cluzo", Properties.Resources.the_inspector_cluzo, "Kerouac");

            bands.Add(band1);
            bands.Add(band2);
            bands.Add(band3);
            bands.Add(band4);
            bands.Add(band5);

            InitializeComponent();
        }

        public void affichagePetitesCartesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();

            panel1.Dock = DockStyle.Fill;
            int x = 0;
            for(int i = 0; i < bands.Count; i++) 
            {
                // Instantiation de la petite carte
                SmallCard smallCard = new SmallCard();
                smallCard.txtName_TextChanged(sender, e, bands[i].Name);
                smallCard.pictureBox1_Click(sender, e, bands[i].Photo);

                // Position de la petite carte
                smallCard.Location = new Point(x, 0);

                x += smallCard.Width + 20;

                // Ajout dans le panel 
                panel1.Controls.Add(smallCard);

            }

        }

        public void affichageGrandesCartesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            panel1.Dock = DockStyle.Fill;
            int x = 0;
            foreach(Band band in bands)
            {
                // Instantiation de la grande carte
                LargeCard largeCard = new LargeCard();
                largeCard.textBox4_TextChanged(sender, e, band.Name);
                largeCard.pictureBox1_Click(sender, e, band.Photo);
                largeCard.textBoxCountry_TextChanged(sender, e, band.Country);
                largeCard.textBoxGenre_TextChanged(sender, e, band.Genre);
                largeCard.textBoxDate_TextChanged(sender, e, band.Date);
                largeCard.textBoxScene_TextChanged(sender, e, band.Stage);
                largeCard.textBoxDescription_TextChanged(sender, e, band.Description);

                // Position de la grande carte
                largeCard.Location = new Point(x, 0);

                x += largeCard.Width + 5;

                // Ajout dans le panel 
                panel1.Controls.Add(largeCard);

            }
        }
    }
}
