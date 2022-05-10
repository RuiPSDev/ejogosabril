using E_Jogos.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Jogos.Controllers
{
    public class EquipeController : Controller
    {

        // ActionResult representa os vários códigos HTTP,
        // resultantes de uma solicitação do cliente.
        // https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status

        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {
            // viewBag = Reserva de espaço para armazenar informações para recuperar na VIEW.

            // ViewBag = tem a função de "carregar" as informações do Controller para a VIEW.

            ViewBag.equipeModel = equipeModel.LerEquipes();

            return View();
        }
    }
}
