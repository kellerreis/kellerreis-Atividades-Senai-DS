using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_gamer_com_back_e_sql.Infra;
using Projeto_gamer_com_back_e_sql.Models;

namespace Projeto_gamer_com_back_e_sql.Controllers
{
    [Route("[controller]")]
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }

        Context c = new Context();
        //            controller/action
        [Route("Listar")] //https://localhost/equipe/Listar
        public IActionResult Index()
        {
            //mochila que contem a lista de equipes 
            //podemos usar essa "mochila" na view de equipe
            ViewBag.Equipe = c.Equipe.ToList();

            //retora a view de equipe
            return View();
        }

        [Route("Cadastrar")]

        public IActionResult Cadastrar(IFormCollection form){

            Equipe novaEquipe = new Equipe();

            novaEquipe.Nome = form["Nome"].ToString();
            // novaEquipe.imagem = form["Imagem"].ToString(); --- vem como string, o que precisamos e a imagem


            //aqui comeca a logica do upload de imagem

            if (form.Files.Count > 0)
            {
                var file = form.Files[0];

                var folder = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/img/Equipes");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.imagem = file.FileName;
                
            }
            else{

                novaEquipe.imagem = "padrao.png";
            }

            //fim da logica de upload de imagem

            c.Equipe.Add(novaEquipe);
            //c.Add(novaEquipe);

            c.SaveChanges();

            ViewBag.Equipe = c.Equipe.ToList();

            return LocalRedirect("~/Equipe/Listar");
        }


        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            Equipe e = c.Equipe.First(e => e.IdEquipe == id);

            c.Equipe.Remove(e);

            c.SaveChanges();

            return LocalRedirect("~/Equipe/Listar");
        }

        [Route("Editar/{id}")]
        public IActionResult Editar(int id)
        {
            Equipe e = c.Equipe.First(e => e.IdEquipe == id);

            ViewBag.Equipe = e;
            
            return View("Edit");
        }

        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form, Equipe e)
        {
            Equipe novaEquipe = new Equipe();

            novaEquipe.Nome = e.Nome;
            //upload da imagem na equipe atualizado

            if (form.Files.Count > 0)
            {
                var file = form.Files[0];

                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);

                }
                var path = Path.Combine(folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create)){

                    file.CopyTo(stream);
                
                }
                novaEquipe.imagem = file.FileName;
            }
            else{
                novaEquipe.imagem = "padrao.png";
            }

            Equipe equipe = c.Equipe.First(x => x.IdEquipe == e.IdEquipe);

            equipe.Nome = novaEquipe.Nome;
            equipe.imagem = novaEquipe.imagem;

            c.Equipe.Update(equipe);

            c.SaveChanges();

            return LocalRedirect("~/Equipe/listar");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

    }

}