namespace RechercheDeLivres.Services
{
    public class RechercheLivresStrategyFactory : IRechercheStrategyFactory
    {
        private static RechercheLivresStrategyFactory instance;

        public static RechercheLivresStrategyFactory Instance 
        { 
            get 
            {
                if (instance == null)
                    instance = new RechercheLivresStrategyFactory();
                return instance; 
            } 
        }

        private RechercheLivresStrategyFactory() { }

        public IRechercheLivresStrategy GetRechercheStrategy()
        {
            return new CatalogueLivres();
        }
    }
}
