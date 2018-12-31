namespace Crr.EntityModels
{
    public class Term
    {
        public string LinkName { get; set; } // id & shown in http link eg: CoinFork vs coin-fork
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}