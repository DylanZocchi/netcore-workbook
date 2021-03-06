﻿using System.Collections.Generic;
using BaseProject.Area.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaseProject.Area.Controllers
{
    [Area("Comments")]
    [Route("[area]/Notes")]
    public class NotesController : Controller
    {
        // GET: Comment
        [Route("Index")]
        public ActionResult Index()
        {
            return View(new List<Note>());
        }

        // GET: Comment/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}


        //[Route("[area]/Notes")]
        //[Area("Comments")]
      
        //[Route("Views")]

       [Route("Create")]
       [HttpGet]
        // GET: Comment/Create
        public ActionResult Create()
        {
            return View(new BaseProject.Areas.Comments.Models.Create());
        }

        // POST: Comment/Create
        [Route("Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Areas.Comments.Models.Create create)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Comment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Comment/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Comment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Comment/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}