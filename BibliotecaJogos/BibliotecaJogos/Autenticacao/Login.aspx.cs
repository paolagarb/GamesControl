﻿using BibliotecaJogosBLL.Autenticacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaJogosBLL.Exceptions;

namespace BibliotecaJogos.Autenticacao
{
    public partial class Login : System.Web.UI.Page
    {
        private LoginBo _loginBo;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            _loginBo = new LoginBo();
            string nomeUsuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            try
            {
                var usuario = _loginBo.ObterUsuario(nomeUsuario, senha);
            }
            catch (UsuarioNaoEncontradoException)
            {
                lblResposta.Text = "Usuário não cadastrado!";
            }
            catch (Exception)
            {
                lblResposta.Text = "Ocorreu um erro inesperado.";
            }
        }

    }
}