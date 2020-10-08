using BibliotecaJogosBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaJogos.Jogos
{
    public partial class CadastroEdicaoJogo : System.Web.UI.Page
    {
        private GeneroBo _generoBo;
        private EditorBo _editorBo;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarregarEditoresCombo();
                CarregarGenerosCombo();
            }
        }

        protected void BtnGravar_Click(object sender, EventArgs e)
        {

        }

        private void CarregarEditoresCombo()
        {
            _editorBo = new EditorBo();
            var editores = _editorBo.ObterEditores();
            DdlEditor.DataSource = editores;
            DdlEditor.DataBind();
        }

        private void CarregarGenerosCombo()
        {
            _generoBo = new GeneroBo();
            var generos = _generoBo.ObterGeneros();
            DdlGenero.DataSource = generos;
            DdlGenero.DataBind();
        }
    }
}