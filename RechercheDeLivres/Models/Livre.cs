namespace RechercheDeLivres.Models
{
    public class Livre
    {
        public string Auteur { get; set; }
        public string Editeur { get; set; }
        public string Titre { get; set; }
        public string Image { get; set; }

        public Livre(string Auteur, string Editeur, string Titre) : this(Auteur, Editeur, Titre, "") { }

        public Livre(string Auteur, string Editeur, string Titre, string Image)
        {
            this.Auteur = Auteur;
            this.Editeur = Editeur;
            this.Titre = Titre;
            this.Image = Image;
        }
    }
}
