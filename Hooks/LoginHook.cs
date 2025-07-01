using SpecFlowSecond.Drivers;
using SpecFlowSecond.Pages;
using TechTalk.SpecFlow;
using System;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SpecFlowSecond.Hooks
{
    [Binding]

    public sealed class LoginHook
    {
        string adminusername, adminpassword, appURL;
        private readonly Driver _driver;
        private readonly LoginPage _loginPage;

        public LoginHook(Driver driver)
        {
            _driver = driver;
            _loginPage = new LoginPage(_driver.Page);
            var configuration = new ConfigurationBuilder()
                   .AddUserSecrets<LoginHook>()
                   .Build();
            adminusername = configuration["admin"];
            adminpassword = configuration["pw"];
            appURL = configuration["appURL"];
        }

        [BeforeScenario("@LoginRequired")]
        public async Task BeforeScenarioWithTag()
        {
            _driver.Page.GotoAsync(appURL);
            await _loginPage.ClickAcceptConsent();
            await _loginPage.Login(adminusername, adminpassword);
            var isExist = await _loginPage.VerifyDashboardHeading();
            Assert.True(isExist);
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
        //[BeforeTestRun]
        public static void BeforeTestRun()
        { 
        }
            
        //[AfterTestRun]
        public static void AfterTestRun()
        {
        }


    }
}