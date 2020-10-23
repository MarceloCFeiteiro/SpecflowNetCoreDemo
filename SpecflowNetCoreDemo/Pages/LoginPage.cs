using OpenQA.Selenium;
using SpecflowNetCoreDemo.Drivers;
using SpecflowNetCoreDemo.Utils;

namespace SpecflowNetCoreDemo.Pages
{
    public class LoginPage : BasePage
    {
        public By TxtUserName => By.Name("UserName");
        public By TxtPassword => By.Name("Password");
        public By BtnLogin => By.CssSelector(".btn-default");
        public By LnkEmployeeDetails => By.LinkText("Employee Details");
        public By LblErro => By.CssSelector(".validation-summary-errors>ul>li");

        public LoginPage(WebDriverBuilder webDriverBuilder, SeleniumActions seleniumActions) : base(webDriverBuilder, seleniumActions)
        {
        }

        public void Login(string userName, string password)
        {
            _seleniumActions.EnviarTexto(TxtUserName, userName);
            _seleniumActions.EnviarTexto(TxtPassword, password);
        }

        public void ClicoNoBotaoLogin() => _seleniumActions.Clicar(BtnLogin);

        public bool EmployeeDatailExiste() => _seleniumActions.EstaVisivel(LnkEmployeeDetails);

        public string MensagemErroPasswordErrado() => _seleniumActions.RetornaTexto(LblErro, "Invalid login attempt.");
    }
}