// Models/Player.cs
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class Player{
        public int Id{get;set;}
        [Required(ErrorMessage="Name cannot be blank")]
        public string Name{get;set;}
        public string Category{get;set;}
        [Range(1,int.MaxValue,ErrorMessage="Bidding Amount should be greater then 0")]
        public decimal BiddingAmount{get;set;}
    }
}
