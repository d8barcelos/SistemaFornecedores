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
            List<FornecedorModel> fornecedores = _fornecedorRepository.GetAll();
            return View(fornecedores);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {

            FornecedorModel fornecedor = _fornecedorRepository.ListarPorId(id);

            if (fornecedor == null)
            {
                return NotFound("Fornecedor não encontrado.");
            }

            return View(fornecedor);
        }


        public IActionResult ApagarConfirmacao(int id)
        {
            FornecedorModel fornecedor = _fornecedorRepository.ListarPorId(id);

            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }


        [HttpPost]
        public IActionResult Criar(FornecedorModel fornecedor)
        {
            if (ModelState.IsValid)
            {
                _fornecedorRepository.Adicionar(fornecedor);
                return RedirectToAction("Index");
            }
            return View(fornecedor);
        }

        [HttpPost]
        public IActionResult Alterar(FornecedorModel fornecedor)
        {
            if (ModelState.IsValid)
            {
                _fornecedorRepository.Atualizar(fornecedor);
                return RedirectToAction("Index");
            }
            return View("Editar", fornecedor);
        }

        [HttpGet]
        public IActionResult Deletar(int id)
        {
            _fornecedorRepository.Deletar(id);
            return RedirectToAction("Index");
        }
    }
}
