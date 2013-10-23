using System.Web.Mvc;
using AvaliacaoAcademica.Domain.Model;
using AvaliacaoAcademica.Infraestrutura.NHibernate.Implementation;
using AvaliacaoAcademica.Infraestrutura.NHibernate.Repository;

namespace AvaliacaoAcademica.Web.Controllers
{
    public class QuestaoController : Controller
    {
        private readonly IRepository<Questao> _repQuestao;

        public QuestaoController()
        {
            _repQuestao = new RespQuestao();
        }

      
        public ActionResult Questao()
        {
            return View(_repQuestao.ObterTodos);
        }

    
       
        public ActionResult CriarQuestao()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CriarQuestao(Questao questao)
        {  
            _repQuestao.Salvar(questao);
            return RedirectToAction("Questao");
        }

         public ActionResult EditarQuestao(int id)
         {
             var questao = _repQuestao.BuscarPor(id);
            return View(questao);
        }


        [HttpPost]
         public ActionResult EditarQuestao(Questao _questao)
        {
            var questao = _repQuestao.BuscarPor(_questao.Id);

            questao.Descricao = _questao.Descricao;
            
            _repQuestao.Atualizar(questao);

            return RedirectToAction("Questao");
        }

        public ActionResult ExcluirQuestao(int id)
        {
            var questao = _repQuestao.BuscarPor(id);
            return View(questao);
        }

        [HttpPost]
        public ActionResult ExcluirQuestao(Questao _questao)
        {
            var questao = _repQuestao.BuscarPor(_questao.Id);
            _repQuestao.Excluir(questao);
            return RedirectToAction("Questao");
        }

        public ActionResult ExibirQuestao(int id)
        {
            var questao = _repQuestao.FiltrandoPor(q => q.Id == id);
           
            return View(questao);
        }
    }
}
