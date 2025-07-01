using Microsoft.Extensions.Configuration;
using Microsoft.Playwright;
using SpecFlowSecond.Drivers;
using SpecFlowSecond.Hooks;
using SpecFlowSecond.Pages;
using System;
using TechTalk.SpecFlow;
using UIAutomationTests.StepDefinitions;

namespace UIAutomationTests.StepDefinitions
{
    [Binding]
    public class NavbarValidationStepDefinitions
    {
        private readonly Driver _driver;
        private readonly LoginPage _loginPage;
        private readonly Navbar _navbarPage;

        public NavbarValidationStepDefinitions(Driver driver)
        {
            _driver = driver;
            _loginPage = new LoginPage(_driver.Page);
            _navbarPage = new Navbar(_driver.Page);

        }

        // The regex pattern extracts the username from the feature file text.
        [Given(@"""([^""]*)"" logs in to the platform")]
        public async Task GivenLogsInToThePlatform(string username)
        {
            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<LoginHook>()
                       .Build();

            await _driver.Page.GotoAsync(configuration["appURL"]);
            await _loginPage.ClickAcceptConsent();
            await _loginPage.Login(username, configuration["pw"]); ;
        }

        [When(@"When the navbar appears")]
        public async Task WhenTheNavbarAppears()
        {
            var isExist = await _navbarPage.VerifyNavbarAppearance();
            Assert.True(isExist);
        }

        // The regex pattern extracts the navbar item from the feature file text and verify if it is appearing in the navbar of the logged in user.
        [When(@"""([^""]*)"" is appearing in the navbar")]
        public async Task VerifyingNavbarItem(string navbarItem)
        {
            Assert.True(await _navbarPage.VerifyNavbarItem(navbarItem));            
        }

        // The regex pattern extracts the sub-navbar item and the main navbar item from the feature file text and verifies if the sub-navbar item is appearing under the main navbar item.
        [When(@"""([^""]*)"" is appearing in the sub menu of ""([^""]*)"" in the navbar")]
        public async Task VerifyingSubNavbarItem(string subNavbarItem, string navbarItem)
        {
            Assert.True(await _navbarPage.VerifySubNavbarItem(subNavbarItem, navbarItem));
        }

    }
}
