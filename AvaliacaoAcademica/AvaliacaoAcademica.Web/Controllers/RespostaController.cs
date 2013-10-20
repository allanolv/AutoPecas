using System.Web.Mvc;
using AvaliacaoAcademica.Domain.Model;
using AvaliacaoAcademica.Infraestrutura.NHibernate.Implementation;
using AvaliacaoAcademica.Infraestrutura.NHibernate.Repository;

namespace AvaliacaoAcademica.Web.Controllers
{
    public class RespostaController : Controller
    {
        private readonly IRepository<Respostas> _repResposta;

        public RespostaController()
        {
            _repResposta = new RespResposta();
        }

      
        public ActionResult Respostas()
        {
            return View(_repResposta.ObterTodos);
        }

        public ActionResult InserirRespostas()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InserirRespostas(Respostas respostas)
        {
            _repResposta.Salvar(respostas);
            return RedirectToAction("Respostas");
        }

         public ActionResult EditarRespostas(int id)
         {
             var respostas = _repResposta.BuscarPor(id);
             return View(respostas);
        }


        [HttpPost]
         public ActionResult EditarRespostas(Respostas _respostas)
        {
            var respostas = _repResposta.BuscarPor(_respostas.ID);

            respostas.Descricao = _respostas.Descricao;

            _repResposta.Atualizar(respostas);

            return RedirectToAction("Respostas");
        }

        public ActionResult ExcluirRespostas(int id)
        {
            var respostas = _repResposta.BuscarPor(id);
            return View(respostas);
        }

        [HttpPost]
        public ActionResult ExcluirRespostas(Respostas _respostas)
        {
            var respostas = _repResposta.BuscarPor(_respostas.ID);
            _repResposta.Excluir(respostas);
            return RedirectToAction("Respostas");
        }

        public ActionResult ExibirRespostas(int id)
        {
            var respostas = _repResposta.FiltrandoPor(q => q.ID == id);

            return View(respostas);
        }

    }
}
