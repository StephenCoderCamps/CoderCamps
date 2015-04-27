using CoderCamps;
using EFCodeFirst.Infrastructure;
using EFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeFirst.Controllers
{
    public class MoviesController : Controller
    {
        private IGenericRepository _repo;


        //public MoviesController():this(new EFRepository())
        //{
        //}


        public MoviesController(IGenericRepository repo)
        {
            _repo = repo;
        }



        // GET: Movies
        public ActionResult Index()
        {
            return View(_repo.Query<Movie>());
        }

        // GET: Movies/Details/5
        public ActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                var movie = _repo.Find<Movie>(id.Value);
                if (movie != null)
                {
                    return View(movie);
                }
            }
            return RedirectToAction("Index");
        }

        // GET: Movies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(movie);
                return RedirectToAction("Index");
            }
            return View();
        }


        // GET: Movies/Edit/5
        public ActionResult Edit(int id)
        {
            var movie = _repo.Find<Movie>(id);
            return View(movie);
        }

        // POST: Movies/Edit/5
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {

                //_dc.Entry(movie).State = System.Data.Entity.EntityState.Modified;
                var original = _repo.Find<Movie>(movie.Id);
                original.Title = movie.Title;
                original.Director = movie.Director;
                _repo.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int id)
        {
            var movie = _repo.Find<Movie>(id);
            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally(int id)
        {
            _repo.Delete<Movie>(id);
            return RedirectToAction("Index");
        }
    }
}
