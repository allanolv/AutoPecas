using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using AvaliacaoAcademica.Domain.Model;
using AvaliacaoAcademica.Infraestrutura.NHibernate.Implementation;
using AvaliacaoAcademica.Infraestrutura.NHibernate.Repository;

namespace AvaliacaoAcademica.Web.Controllers
{
    public class RespostaAvaliacaoController : Controller
    {
        private readonly IRepository<RespostaAvaliacao> _repRespostaAvaliacao;

        public RespostaAvaliacaoController()
        {
            _repRespostaAvaliacao = new RespRespostaAvaliacao();
        }
        public ActionResult RespostaAvaliacao()
        {
            return View(_repRespostaAvaliacao.ObterTodos);
        }

      public ActionResult InserirRespostaAvaliacao()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InserirRespostaAvaliacao(RespostaAvaliacao _respavaliacao)
        {
            _repRespostaAvaliacao.Salvar(_respavaliacao);
            return RedirectToAction("RespostaAvaliacao");
        }

        public ActionResult EditarRespostaAvaliacao(int id)
        {
            var respavaliacao = _repRespostaAvaliacao.BuscarPor(id);
            return View(respavaliacao);
        }


        [HttpPost]
        public ActionResult EditarRespostaAvaliacao(RespostaAvaliacao _respavaliacao)
        {
            var respavaliacao = _repRespostaAvaliacao.BuscarPor(_respavaliacao.Id);

            respavaliacao.Turma = _respavaliacao.Turma;
            respavaliacao.Aluno = _respavaliacao.Aluno;
            respavaliacao.Avaliacao = _respavaliacao.Avaliacao;
            respavaliacao.Questao = _respavaliacao.Questao;
            respavaliacao.Respostas = _respavaliacao.Respostas;

            _repRespostaAvaliacao.Atualizar(respavaliacao);

            return RedirectToAction("RespostaAvaliacao");
        }

        public ActionResult ExcluirRespostaAvaliacao(int id)
        {
            var respavaliacao = _repRespostaAvaliacao.BuscarPor(id);
            return View(respavaliacao);
        }

        [HttpPost]
        public ActionResult ExcluirRespostaAvaliacao(RespostaAvaliacao _respavaliacao)
        {
            var respavaliacao = _repRespostaAvaliacao.BuscarPor(_respavaliacao.Id);
            _repRespostaAvaliacao.Excluir(respavaliacao);
            return RedirectToAction("RespostaAvaliacao");
        }

        public ActionResult ExibirRespostaAvaliacao(int id)
        {
            var respavaliacao = _repRespostaAvaliacao.FiltrandoPor(q => q.Id == id);

            return View(respavaliacao);
        }
    }
}
