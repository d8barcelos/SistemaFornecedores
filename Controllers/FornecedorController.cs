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
            try
            {
                if (ModelState.IsValid)
                {
                    _fornecedorRepository.Adicionar(fornecedor);
                    TempData["MensagemSucesso"] = "Fornecedor cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }
                return View(fornecedor);
            }
            catch (System.Exception error)
            {
                TempData["MensagemErro"] = $"Não foi possível cadasrar o fornecedor, detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Alterar(FornecedorModel fornecedor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _fornecedorRepository.Atualizar(fornecedor);
                    TempData["MensagemSucesso"] = "Fornecedor alterado com sucesso!";
                    return RedirectToAction("Index");
                }
                return View("Editar", fornecedor);
            }
            catch (System.Exception error)
            {
                TempData["MensagemErro"] = $"Não foi possível alterar o fornecedor, detalhe do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Deletar(int id)
        {
            try
            {
                bool apagado = _fornecedorRepository.Deletar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Fornecedor apagado com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = "Não foi possível apagar o fornecedor";
                }

                return RedirectToAction("Index");
            }
            catch (System.Exception error)
            {
                TempData["MensagemErro"] = $"Não foi possível apagar o fornecedor, mais detalhes do erro: {error.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
