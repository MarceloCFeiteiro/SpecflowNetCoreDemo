using NUnit.Framework;
using SpecflowNetCoreDemo.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowNetCoreDemo.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        private readonly LoginPage _loginPage;

        public LoginSteps(LoginPage loginPage)
        {
            _loginPage = loginPage;
        }

        [Given(@"Eu entro com os seguintes detalhes")]
        public void DadoEuEntroComOsSeguintesDetalhes(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _loginPage.Login((string)data.UserName, (string)data.Password);
        }

        [Given(@"Eu clico no botao de login")]
        public void DadoEuClicoNoBotaoDeLogin()
        {
            _loginPage.ClicoNoBotaoLogin();
        }

        [Then(@"Eu deveria ver o link Employee details")]
        public void EntaoEuDeveriaVerOLinkEmployeeDetails()
        {
             Assert.That(_loginPage.EmployeeDatailExiste, Is.True);
        }

        [Then(@"Eu deveria a messagem de erro")]
        public void EntaoEuDeveriaAMessagemDeErro()
        {
            Assert.That(_loginPage.MensagemErroPasswordErrado, Is.EqualTo("Invalid login attempt."));
        }

    }
}