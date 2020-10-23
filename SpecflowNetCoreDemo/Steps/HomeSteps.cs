using SpecflowNetCoreDemo.Pages;
using TechTalk.SpecFlow;

namespace SpecflowNetCoreDemo.Steps
{
    [Binding]
    public class HomeSteps
    {
        private readonly HomePage _homePage;

        public HomeSteps(HomePage homePage)
        {
            _homePage = homePage;
        }

        [Given(@"Eu subo a aplicacao")]
        public void DadoEuSuboAAplicacao()
        {
            _homePage.NavegarPara("http://eaapp.somee.com/");
        }

        [Given(@"Eu Clico no link login")]
        public void DadoEuClicoNoLinkLogin()
        {
            _homePage.ClicarLogin();
        }
    }
}