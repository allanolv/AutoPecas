using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AvaliacaoAcademica.Domain.Model;
using AvaliacaoAcademica.Infraestrutura.NHibernate.Repository;
using AvaliacaoAcademica.Infraestrutura.NHibernate.Implementation;

namespace AvaliacaoAcademica.Web.Controllers
{
    public class TesteController : Controller
    {
        private readonly IRepository<Questao> _repQuestao;

        public TesteController()
        {
            _repQuestao = new RespQuestao();
        }

        public ActionResult Questao()
        {
            return PartialView(_repQuestao.ObterTodos);
        }

        public ActionResult CriarQuestao()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult CriarQuestao(Questao questao)
        {
            _repQuestao.Salvar(questao);
            return PartialView("~/Views/Home/About.cshtml");
        }

    }
}
