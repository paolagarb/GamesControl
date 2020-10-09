using BibliotecaJogosBLL;
using BibliotecaJogosBLL.Autenticacao;
using BibliotecaJogosEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaJogos.Jogos
{
    public partial class Catalogo : System.Web.UI.Page
    {
        private JogosBo _jogosBo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) CarregarJogosRepeater();
        }

        private void CarregarJogosRepeater()
        {
            _jogosBo = new JogosBo();
            RepeaterJogos.DataSource = _jogosBo.ObterJogos();
            RepeaterJogos.DataBind();
        }

        private void Deslogar()
        {
            if (!string.IsNullOrEmpty(Page.Request.QueryString["logout"]))
            {
                FormsAuthentication.SignOut();
                Session.Abandon();
                FormsAuthentication.RedirectToLoginPage();
            }
        }
    }
}