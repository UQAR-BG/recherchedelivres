using RechercheDeLivres.Models;
using RechercheDeLivres.Models.DTOs;

namespace RechercheDeLivres.Services
{
    public interface IRechercheLivresStrategy
    {
        public List<Livre> Chercher(RechercheLivre recherche);
    }
}
