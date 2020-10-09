using BibliotecaJogosBLL;
using BibliotecaJogosEntities;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        private JogosBo _jogosBo;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarregarEditoresCombo();
                CarregarGenerosCombo();

                if (ModoEdicao()) CarregarDadosEdicao();
            }
        }

        protected void BtnGravar_Click(object sender, EventArgs e)
        {
            _jogosBo = new JogosBo();
            var jogo = ObterModelo();

            try
            {
                jogo.Imagem = SalvarImagem();
            } 
            catch (Exception ex)
            {
                LblMsgErro.Text = "Ocorreu um erro ao salvar a imagem";
            }

            try
            {

                if (ModoEdicao())
                {
                    jogo.Id = ObterIdJogo();
                    _jogosBo.AlterarJogo(jogo);
                    LblMsgErro.ForeColor = Color.Green;
                    LblMsgErro.Text = "Jogo alterado com sucesso!";

                } else
                {
                    _jogosBo.InserirNovoJogo(jogo); 
                    LblMsgErro.ForeColor = Color.Green;
                    LblMsgErro.Text = "Jogo cadastrado com sucesso!";
                }

                
                BtnGravar.Enabled = false;
            }
            catch (Exception)
            {
                LblMsgErro.ForeColor = Color.Red;
                LblMsgErro.Text = "Ocorreu um erro ao salvar o jogo";
            }
        }

        private string SalvarImagem()
        {
            if (FileUploadImage.HasFile)
            {
                try
                {
                    var caminho = $"{AppDomain.CurrentDomain.BaseDirectory}Content\\Imagens\\";
                    var fileName = $"{DateTime.Now.ToString("yyyyMMddhhmmss")}_{FileUploadImage.FileName}";
                    FileUploadImage.SaveAs(caminho + fileName);
                    return fileName;
                } 
                catch (Exception ex)
                {
                    throw ex;
                }
            } else
            {
                return null;
            }
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

        public void CarregarDadosEdicao()
        {
            _jogosBo = new JogosBo();
            var jogo = _jogosBo.ObterJogoId(ObterIdJogo());

            TxtTitulo.Text = jogo.Titulo;
            TxtValor.Text = jogo.Valor.ToString();
            TxtCompra.Text = jogo.Data.HasValue ? jogo.Data.Value.ToString("yyyy-MM-dd") : string.Empty;
            DdlEditor.Text = jogo.IdEditor.ToString();
            DdlGenero.Text = jogo.IdGenero.ToString();
        }

        public int ObterIdJogo()
        {
            var id = 0;
            var idQueryString = Request.QueryString["id"];
            if (int.TryParse(idQueryString, out id))
            {
                if (id <= 0)
                {
                    throw new Exception("ID inválido!");
                }
                return id;
            }
            else
            {
                throw new Exception("ID inválido!");
            }
        }

        public bool ModoEdicao()
        {
            return Request.QueryString.AllKeys.Contains("id");
        }

        private Jogo ObterModelo()
        {
            var jogo = new Jogo();
            jogo.IdEditor = Convert.ToInt32(DdlEditor.SelectedValue);
            jogo.IdGenero = Convert.ToInt32(DdlGenero.SelectedValue);
            jogo.Titulo = TxtTitulo.Text;
            jogo.Valor = string.IsNullOrWhiteSpace(TxtValor.Text) ? (double?)null : Convert.ToDouble(TxtValor.Text);
            jogo.Data = string.IsNullOrWhiteSpace(TxtCompra.Text) ? (DateTime?)null : Convert.ToDateTime(TxtCompra.Text);

            return jogo;
        }
    }
}