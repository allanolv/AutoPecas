using System.Web.Mvc;
using AvaliacaoAcademica.Domain.Model;
using AvaliacaoAcademica.Infraestrutura.NHibernate.Implementation;
using AvaliacaoAcademica.Infraestrutura.NHibernate.Repository;

namespace AvaliacaoAcademica.Web.Controllers
{
    public class AvaliacaoController : Controller
    {
      private readonly IRepository<Avaliacao> _repAvaliacao;

      public AvaliacaoController()
        {
            _repAvaliacao = new RepAvaliacao();
        }

      
        public ActionResult Avaliacao()
        {
            return View(_repAvaliacao.ObterTodos);
        }

        public ActionResult InserirAvaliacao()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InserirAvaliacao(Avaliacao avaliacao)
        {
            _repAvaliacao.Salvar(avaliacao);
            return RedirectToAction("Avaliacao");
        }

        public ActionResult EditarAvaliacao(int id)
         {
             var avaliacao = _repAvaliacao.BuscarPor(id);
             return View(avaliacao);
        }


        [HttpPost]
        public ActionResult EditarAvaliacao(Avaliacao _avaliacao)
        {
            var avaliacao = _repAvaliacao.BuscarPor(_avaliacao.Id);

            avaliacao.Codigo = _avaliacao.Codigo;
            avaliacao.Objetivo = _avaliacao.Objetivo;
            avaliacao.DataInicio = _avaliacao.DataInicio;
            avaliacao.HoraInicio = _avaliacao.HoraInicio;
            avaliacao.DataFim = _avaliacao.DataFim;
            avaliacao.HoraFim = _avaliacao.HoraFim;

            _repAvaliacao.Atualizar(avaliacao);

            return RedirectToAction("Avaliacao");
        }

        public ActionResult ExcluirAvaliacao(int id)
        {
            var avaliacao = _repAvaliacao.BuscarPor(id);
            return View(avaliacao);
        }

        [HttpPost]
        public ActionResult ExcluirAvaliacao(Avaliacao _avaliacao)
        {
            var avaliacao = _repAvaliacao.BuscarPor(_avaliacao.Id);
            _repAvaliacao.Excluir(avaliacao);
            return RedirectToAction("Avaliacao");
        }

        public ActionResult ExibirAvaliacao(int id)
        {
            var avaliacao = _repAvaliacao.FiltrandoPor(q => q.Id == id);

            return View(avaliacao);
        }

    }
}
