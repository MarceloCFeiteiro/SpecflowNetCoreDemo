using NUnit.Framework;
using OpenQA.Selenium;
using SpecflowNetCoreDemo.Drivers;
using SpecflowNetCoreDemo.Utils;
using System;
using TechTalk.SpecFlow;

namespace SpecflowNetCoreDemo.Steps
{
    [Binding]
    public sealed class BasicSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly SeleniumActions _seleniumActions;

        private readonly ScenarioContext _scenarioContext;
        public readonly WebDriverBuilder _webDriverBuilder;

        public BasicSteps(ScenarioContext scenarioContext, SeleniumActions seleniumActions, WebDriverBuilder webDriverBuilder)
        {
            _scenarioContext = scenarioContext;
            _seleniumActions = seleniumActions;
            _webDriverBuilder = webDriverBuilder;
        }

        [Given(@"que o usario acessa a pagina ""(.*)""")]
        public void DadoQueOUsarioAcessaAPagina(string url)
        {
            _webDriverBuilder.WebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            _webDriverBuilder.WebDriver.Navigate().GoToUrl(url);
        }

        [Given(@"clica no elemento ""(.*)"" do tipo ""(.*)""")]   
        [When(@"clica no elemento ""(.*)"" do tipo ""(.*)""")]
        public void QuandoClicaNoElementoDoTipo(string seletor, string tipoElemento)
        {
            var elemento = ObterElementoBy(seletor, tipoElemento);

            _seleniumActions.Clicar(elemento);
        }
       
        [When(@"entra com os seguintes campos")]
        public void QuandoEntraComOsSeguintesCampos(Table table)
        {
            try
            {
                foreach (var linha in table.Rows)
                {
                    var elemento = ObterElementoBy(linha[2], linha[3]);
                    _seleniumActions.EnviarTexto(elemento, linha[1]);
                }
            }
            catch (Exception)
            {

                throw new FormatException("A tabela esta mal formatada");
            }

        }

        [Then(@"valida se o elemento ""(.*)"" do tipo ""(.*)"" esta visivel")]
        public void EntaoValidaSeOElementoDoTipoEstaVisivel(string seletor, string tipoElemento)
        {
            var elemento = ObterElementoBy(seletor, tipoElemento);
            Assert.That(_seleniumActions.ElementoEstaVisivel(elemento));
        }

        [Then(@"valida a mensagem no elemento ""(.*)"" do tipo ""(.*)"" com o texto ""(.*)""")]
        public void EntaoValidaAMensagemNoElementoDoTipoComOTexto(string seletor, string tipoElemento, string mensagem)
        {
            var elemento = ObterElementoBy(seletor, tipoElemento);
            Assert.That(_seleniumActions.RetornaTexto(elemento, mensagem), Is.EqualTo(mensagem));
        }

        private By ObterElementoBy(string nomeElemento, string tipoElemento)
        {
            switch (tipoElemento)
            {
                case "ById":
                    return By.Id(nomeElemento);

                case "ByLinkText":
                    return By.LinkText(nomeElemento);

                case "ByCssSelector":
                    return By.CssSelector(nomeElemento);

                case "ByName":
                    return By.Name(nomeElemento);

                default:
                    break;
            }

            return null;
        }
    }
}