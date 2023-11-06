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
        public IActionResult Index(){
            
            return View();

        }
        public IActionResult Find(int id){
            var data=context.Players.Find(id);
            return View(data);
        }
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
            var data=context.Players.Find(id);
            context.Players.Remove(data);
            return RedirectToAction("Index");
        }
    }
}

