﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientServerNKSLK.Controllers
{
    public class DiaryController : Controller
    {
        // GET: User/Diary
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Diary/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Diary/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Diary/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Diary/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Diary/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Diary/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Diary/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}