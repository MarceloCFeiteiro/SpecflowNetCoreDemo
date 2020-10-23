using OpenQA.Selenium;
using SpecflowNetCoreDemo.Drivers;
using SpecflowNetCoreDemo.Utils;

namespace SpecflowNetCoreDemo.Pages
{
    public class HomePage : BasePage
    {
        public By LnkLogin = By.LinkText("Login");

        public HomePage(WebDriverBuilder webDriverBuilder, SeleniumActions seleniumActions) : base(webDriverBuilder, seleniumActions)
        {
        }

        public void ClicarLogin() => _seleniumActions.Clicar(LnkLogin);
    }
}