using Microsoft.AspNetCore.Mvc;
using Cadastro_Alunos_MVC.Models;

namespace Cadastro_Alunos_MVC.Controllers
{
    public class AlunoController : Controller
    {
        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Aluno aluno)
        {
            return View("Resultado", aluno);
        }
    }
}