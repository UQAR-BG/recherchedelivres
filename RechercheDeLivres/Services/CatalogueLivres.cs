using RechercheDeLivres.Models;
using RechercheDeLivres.Models.DTOs;

namespace RechercheDeLivres.Services
{
    public class CatalogueLivres : IRechercheLivresStrategy
    {
        private List<Livre> livres;

        public CatalogueLivres()
        {
            SetLivres();
        }

        public List<Livre> Chercher(RechercheLivre recherche)
        {
            IQueryable<Livre> resultats = livres.AsQueryable();

            if (recherche != null)
            {
                if (!string.IsNullOrEmpty(recherche.Editeur))
                    resultats = resultats.Where(l => l.Editeur.Contains(recherche.Editeur));
                if (!string.IsNullOrEmpty(recherche.Auteur))
                    resultats = resultats.Where(l => l.Auteur.Contains(recherche.Auteur));
                if (!string.IsNullOrEmpty(recherche.Titre))
                    resultats = resultats.Where(l => l.Titre.Contains(recherche.Titre));
            }

            return resultats.ToList();
        }

        private void SetLivres()
        {
            livres = new List<Livre>()
            {
                new Livre("Victor Hugo", "Plume de Carotte", "Han d’Islande"),
                new Livre("Victor Hugo", "Arvensa", "Le dernier Jour d’un Condamné"),
                new Livre("J.R.R. Tolkien", "Bourgois", "Le Silmarillion"),
                new Livre("J.R.R. Tolkien", "Bourgois", "Le Seigneur des anneaux : Les Deux Tours"),
                new Livre("J.R.R. Tolkien", "Bourgois", "Le Seigneur des anneaux : Le Retour du roi"),
                new Livre("Oscar Wilde", "Le livre qui parle", "Le Portrait de Dorian Gray")
            };
        }
    }
}
