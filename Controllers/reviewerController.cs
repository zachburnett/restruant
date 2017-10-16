using Microsoft.EntityFrameworkCore;
using resturant.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace resturant.Controllers
{
    public class reviewerController : Controller
    {
        private resturantContext _context;

        public reviewerController(resturantContext context){
        _context =context;
        }
        [HttpGet]
        [Route("")]
        public IActionResult index()
        {
            ViewBag.ohBalls ="";
            return View();
        }
        [HttpPost]
        [Route("addreview")]
        public IActionResult addreview(reviewer reviewer)
        {
          if(!ModelState.IsValid){
              ViewBag.ohBalls = ModelState.Values;
              return View();
          }
          
            _context.Add( reviewer);
            _context.SaveChanges();
          return RedirectToAction("results");
        }
        [HttpGet]
        [Route("results")]
        public IActionResult results()
        {
            List<reviewer> allreviews = _context.reviewer.ToList();
            ViewBag.alldem = allreviews;
            return View();
        }
    }
}