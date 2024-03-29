﻿using forumDB.Model;
using forumDB.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel;

namespace forumDB.View.Controllers
{
    public class NotasController : Controller
    {
        // GET: NotasController
        public ActionResult Index()
        {
            return View();
        }

        // GET: NotasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NotasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: NotasController/Create
        public ActionResult NotasPergunta(int id)
        {
            ViewData["idPergunta"] = id;
            ViewData["idResposta"] = null;
            return View();
        }

        // GET: NotasController/Create
        public ActionResult NotasResposta(int id)
        {
            ViewData["idPergunta"] = null;
            ViewData["idResposta"] = id;
            return View("Notas");
        }

        // POST: NotasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public void UpVote(Nota oNota)
        {
            string sessaoUsuario = HttpContext.Session.GetString("sessaoUsuarioLogado");

            Usuario oUsuario = JsonConvert.DeserializeObject<Usuario>(sessaoUsuario);

            RepositoryNota oRepository = new RepositoryNota();
            oNota.Valor = 1;
            oNota.IdUsuario = oUsuario.Id;
            oRepository.Incluir(oNota);
        }

        // POST: NotasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DownVote(Nota oNota)
        {
            string sessaoUsuario = HttpContext.Session.GetString("sessaoUsuarioLogado");

            Usuario oUsuario = JsonConvert.DeserializeObject<Usuario>(sessaoUsuario);

            RepositoryNota oRepository = new RepositoryNota();
            oNota.Valor = -1;
            oNota.IdUsuario = oUsuario.Id;
            oRepository.Incluir(oNota);

            return View();
        }

        // POST: NotasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NotasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NotasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NotasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NotasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
