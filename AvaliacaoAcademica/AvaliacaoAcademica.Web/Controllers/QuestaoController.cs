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

      
        public ActionResult Index()
        {
            return View(_repQuestao.ObterTodos);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Questao questao)
        {  
            _repQuestao.Salvar(questao);
            return RedirectToAction("Index");
        }

         public ActionResult Edit(int id)
         {
             var questao = _repQuestao.BuscarPor(id);
            return View(questao);
        }


        [HttpPost]
        public ActionResult Edit(Questao _questao)
        {
            var questao = _repQuestao.BuscarPor(_questao.Id);

            questao.Descricao = _questao.Descricao;
            
            _repQuestao.Atualizar(questao);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var questao = _repQuestao.BuscarPor(id);
            return View(questao);
        }

        [HttpPost]
        public ActionResult Delete(Questao _questao)
        {
            var questao = _repQuestao.BuscarPor(_questao.Id);
            _repQuestao.Excluir(questao);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var questao = _repQuestao.FiltrandoPor(q => q.Id == id);
           
            return View(questao);
        }
    }
}
