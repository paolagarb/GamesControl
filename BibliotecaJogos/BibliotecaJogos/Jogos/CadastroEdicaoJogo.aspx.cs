using BibliotecaJogosBLL;
using BibliotecaJogosEntities;
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
            var jogo = new Jogo();

            jogo.IdEditor = Convert.ToInt32(DdlEditor.SelectedValue);
            jogo.IdGenero = Convert.ToInt32(DdlGenero.SelectedValue);
            jogo.Titulo = TxtTitulo.Text;
            jogo.Valor = string.IsNullOrWhiteSpace(TxtValor.Text) ? (double?)null : Convert.ToDouble(TxtValor.Text);
            jogo.Data = string.IsNullOrWhiteSpace(TxtCompra.Text)? (DateTime?)null : Convert.ToDateTime(TxtCompra.Text);
            jogo.Imagem = FileUploadImage.FileName;
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