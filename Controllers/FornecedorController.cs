using Microsoft.AspNetCore.Mvc;
using SistemaFornecedores.Models;
using SistemaFornecedores.Repositorio;

namespace SistemaFornecedores.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        public FornecedorController(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(FornecedorModel fornecedor)
        {
            _fornecedorRepository.Adicionar(fornecedor);
            return RedirectToAction("Index");
        }
    }
}
