using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LostInTheWoods.Models;
using DbConnection;

namespace LostInTheWoods.Controllers
{
    public class HomeController : Controller
    {
        private List<Dictionary<string, object>> AllTrails
        {
            get
            {
                return DbConnector.Query("SELECT * FROM trails;");
            }
        }



        public IActionResult Index()
        {
            return View(AllTrails);
        }

        [HttpGet("NewTrail")]
        public IActionResult NewTrail()
        {
            return View("NewTrail");
        }

        [HttpPost("AddTrail")]
        public IActionResult AddTrail(Trail trail)
        {
            if(ModelState.IsValid)
            {
                string query = $"INSERT INTO trails (name, description, length, elevation, longitude, latitude) VALUES ('{trail.name}', '{trail.description}', '{trail.length}', '{trail.elevation}', '{trail.longitude}', '{trail.latitude}');";
                DbConnector.Execute(query);
                return RedirectToAction("Index");
            }else{
                return View("NewTrail");
            }
        }
        
        [HttpGet("trails/{id}")]
        public IActionResult Trails(int id)
        {
            string query = $"SELECT * FROM trails WHERE id = {id};";
            List<Dictionary<string, object>> trails = DbConnector.Query(query);
            return View("Trails", trails);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
