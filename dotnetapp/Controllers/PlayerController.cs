using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetapp.Models;

namespace dotnetapp.Controllers
{
    public class PlayerController : Controller
    {
        private readonly ApplicationDbContext context;

        public PlayerController(ApplicationDbContext _context)
        {
            context = _context;
        }
        public IActionResult Create(){
            return  View();
        }
        [HttpPost]
        public IActionResult Create(Player p){
            Player player=new Player();
            player.Name=p.Name;
            player.Category=p.Category;
            player.BiddingAmount=p.BiddingAmount;
            context.Players.Add(player);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [Route("Index")]
        public IActionResult Index(){
            
            var data=context.Players.ToList();
            return View(data);
        }
        public IActionResult Find(int id){
            var data=context.Players.Find(id);
            return View(data);
        }
        public IActionResult Add(){
            return View();
        }
        [HttpPost]
        public IActionResult Add(Player p){
            if(ModelState.IsValid){
                Player pl=new Player();
                pl.Name=p.Name;
                pl.Category=p.Category;
                pl.BiddingAmount=p.BiddingAmount;
                context.Players.Add(pl);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id){
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Player p,int id){
            if(ModelState.IsValid){
                Player pl=context.Players.Find(id);
                pl.Name=p.Name;
                pl.Category=p.Category;
                pl.BiddingAmount=p.BiddingAmount;
                context.Players.Add(pl);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int id){
            return View();
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(int id){
            var data=context.Players.Find(id);
            context.Players.Remove(data);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

