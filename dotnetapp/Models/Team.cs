namespace dotnetapp.Models{
    public class Team{
        public int TeamId{get;set;}
        public ICollection<Player> Player{get;set;}
    }
}