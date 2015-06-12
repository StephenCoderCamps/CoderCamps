using PhotoAlbum.Models;
using PhotoAlbum.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhotoAlbum.Controllers
{
    public class AlbumController : Controller
    {
        private IAlbumService _albumService;
        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        // GET: Album
        public ActionResult Index()
        {
            return View(_albumService.ListAlbums());
        }

        // GET: Album/Details/5
        public ActionResult Details(int id)
        {

            return View(_albumService.ShowAlbum(id));
        }


        public ActionResult ImageDetails(int id)
        {
            return View(_albumService.ShowImage(id));        
        }


        // GET: Album/Create
        public ActionResult Create()
        {


            return View();
        }


        // POST: Album/Create
        [HttpPost]
        public ActionResult Create(Album album)
        {

            if (ModelState.IsValid) {
                _albumService.Create(album);
                return RedirectToAction("Index");
            }
            else {
                return View();
            }
        }


        // GET: Album/addimage
        public ActionResult AddImage(int id)
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddImage(int id, Image image)
        {
            if (ModelState.IsValid) {


                _albumService.ImageAdd(id, image);
                return RedirectToAction("Index");
            }
            else {
                return View();
            }
        }

        // GET: Album/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Album/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }

        // GET: Album/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Album/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }
    }
}
