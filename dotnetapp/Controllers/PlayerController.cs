using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetapp.Models;

namespace dotnetapp.Controllers
{
    
    // [Route("/[controller]")]
    public class PlayerController : Controller
    {
        private readonly ApplicationDbContext context;

        public PlayerController(ApplicationDbContext _context)
        {
            context = _context;
        }
        // [Route("create")]
        public IActionResult Create(){

            return  View();
        }
        
        [HttpPost]
        public IActionResult Create(Player p){
            // if(ModelState.IsValid){
            
                context.Players.Add(p);
                context.SaveChanges();
                return RedirectToAction("Index");
            // }
            // return View();
        }
        // [Route("")]
        public IActionResult Index(){
            
            var data=context.Players.ToList();
            return View(data);
        }
        
        
      
        public IActionResult Edit(int id){
            var data=context.Players.Find(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(Player p){
           // if(ModelState.IsValid)
           {
                Player pl=context.Players.Find(p.Id);
                pl.Name=p.Name;
                pl.Age=p.Age;
                pl.Category=p.Category;
                pl.BiddingAmount=p.BiddingAmount;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
           // return View();
        }
        public IActionResult Delete(){
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id){
            var data=context.Players.Find(id);
            context.Players.Remove(data);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
         public IActionResult DeleteConfirmed(int id){
            var data=context.Players.Find(id);
            context.Players.Remove(data);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        // public IActionResult DisplayAllPlayers(){
            
        // }
    }
}

