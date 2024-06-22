using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto.Data;
using Projeto.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;

namespace Projeto.Controllers
{
    public class UtilizadorController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public UtilizadorController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PagInicial()
        {
            var postsVisiveis = _context.Post
                .Where(p => p.Visibiliade)
                .Include(x => x.Utilizador_Autenticado)
                .OrderByDescending(p => p.Data_Post)
                .ToList();

            return View(postsVisiveis);
        }

        [HttpPost]
        public IActionResult CriarPost(string Texto)
        {
            if (User.Identity.IsAuthenticated)
            {
                var novoPost = new Post
                {
                    Texto = Texto,
                    Visibiliade = true,
                    Utilizador_Autenticado = _context.Utilizador_Autenticado.Single(x => x.Id_Util == (int)HttpContext.Session.GetInt32("UserId")),
                    Data_Post = DateTime.Now
                };

                _context.Post.Add(novoPost);
                _context.SaveChanges();
            }

            return RedirectToAction("PagInicial");
        }

        [HttpPost]
        public IActionResult Comentar(string Comentario, int PostId)
        {
            var novoComentario = new Comenta
            {
                Texto = Comentario,
                Data_Comentario = DateTime.Now,
                UtilizadorAutenticado = _context.Utilizador_Autenticado.Single(x => x.Id_Util == (int)HttpContext.Session.GetInt32("UserId")),
                Post = _context.Post.Single(x => x.Id_Post == PostId),
            };

            _context.Comenta.Add(novoComentario);
            _context.SaveChanges();

            return RedirectToAction("PagInicial");
        }
    }
}
