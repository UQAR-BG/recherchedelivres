namespace RechercheDeLivres.Services
{
    public interface IRechercheStrategyFactory
    {
        public IRechercheLivresStrategy GetRechercheStrategy();
    }
}
