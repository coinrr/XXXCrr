namespace Crr.Models.Term
{
    public class TermModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LinkName { get; set; } // shown in http link eg: CoinFork vs coin-fork
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}