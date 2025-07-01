using Microsoft.Playwright;
using SpecFlowSecond.Drivers;
using SpecFlowSecond.Pages;

namespace UIAutomationTests.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly Driver _driver;
        private readonly LoginPage _loginPage;

        public LoginStepDefinitions(Driver driver)
        {
            _driver = driver;
            _loginPage = new LoginPage(_driver.Page);
        }
        
        // Step definitions for the login feature
        [Given(@"We navigate to the login page")]
        public void GivenWeNavigateToTheLoginPage()
        {
            _driver.Page.GotoAsync("[YOUR_SITE_URL]");
        }
        
        [Given(@"We we click on accept consent button")]
        public async Task GivenWeWeClickOnAcceptConsentButton()
        {
            await _loginPage.ClickAcceptConsent();
        }

        [Given(@"We enter username and password and click on Login button")]
        public async Task GivenWeEnterUsernameAndPasswordAndClickOnLoginButton()
        {
            await _loginPage.Login("[ADMIN_USERNAME]", "[ADMIN_PASSWORD]");
        }
        
        [Then(@"User is logged into dashboard")]
        public async Task ThenUserIsLoggedIntoDashboard()
        {
            var isExist = await _loginPage.VerifyDashboardHeading();
            Assert.True(isExist);
        }
    }
}
