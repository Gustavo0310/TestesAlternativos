﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrontServerest._04___Utilidades;

namespace FrontServerest._01___Pages.Autenticação
{
    public class LoginPage : Driver
    {
        public void RealizarLoginComSucesso()
        {
            AcessarPaginaDeAutenticacao();
            InserirCredenciais("testelogin@gmail.com", "12345");
            PressionarBotaoEntrar();
            RetornarMensagemLoginComSucesso();
        }


        public void PressionarBotaoCadastreSe()
        {
            RealizarClique_PorXpath("//*[@id=\"root\"]/div/div/form/small/a");
        }

        public void InserirCredenciaisDeCadastroDoUsuario(string nome, string email, string password)
        {
            BuscarElemento_PorID("nome").SendKeys(nome);
            BuscarElemento_PorID("email").SendKeys(email);
            BuscarElemento_PorID("password").SendKeys(password);
        }

        public void PressionarBotaoCadastrar()
        {
            RealizarClique_PorXpath("//*[@id=\"root\"]/div/div/form/div[5]/button");
        }

        public string RetornarMensagemQueJaExisteUmCadastro()
        {
            return BuscarTextoDoElemento_PorXpath("//*[@id=\"root\"]/div/div/form/div[1]/span");
        }

        public void AcessarPaginaDeAutenticacao()
        {
            driver.Navigate().GoToUrl("https://front.serverest.dev/login");
        }

        public void InserirCredenciais(string email, string password)
        {
            BuscarElemento_PorID("email").SendKeys(email);
            BuscarElemento_PorID("password").SendKeys(password);
        }

        public void PressionarBotaoEntrar()
        {
            RealizarClique_PorXpath("//*[@id=\"root\"]/div/div/form/button");
        }

        public string RetornarMensagemLoginComSucesso()
        {
            return BuscarTextoDoElemento_PorXpath("//*[@id=\"root\"]");
        }

        public string RetornarMensagemDeUsuarioOuSenhaIncorreta()
        {
            return BuscarTextoDoElemento_PorXpath("//*[@id=\"root\"]/div/div/form/div[1]/span");
        }

        public string RetornarMensagemDeEmailObrigatorio()
        {
            return BuscarTextoDoElemento_PorXpath("//*[@id=\"root\"]/div/div/form/div[1]/span");
        }
        public string RetornarMensagemSenhaObrigatoria()
        {
            return BuscarTextoDoElemento_PorXpath("//*[@id=\"root\"]/div/div/form/div[1]/span");
        }
    }
}
