using SpecFlowSecond.Config;
using SpecFlowSecond.Drivers;
using SpecFlowSecond.Pages;
using System;
using TechTalk.SpecFlow;

namespace UIAutomationTests.StepDefinitions
{
    [Binding]
    public class SignupCreationStepDefinitions : Configurations
    {
        private readonly Driver _driver;
        private readonly Navbar _navbarPage;
        private readonly IndexPage _indexPage;
        private readonly CreateUserPage _createUserPage;

        public SignupCreationStepDefinitions(Driver driver)
        {
            _driver = driver;
            _navbarPage = new Navbar(_driver.Page);
            _createUserPage = new CreateUserPage(_driver.Page);
            _indexPage = new IndexPage(_driver.Page);
        }

        [Given(@"User navigates to the signup management page")]
        public async Task GivenUserNavigatesToTheSignupManagementPage()
        {
            await _navbarPage._linkNavbarUserManagement.ClickAsync();
            await _navbarPage._linkNavbarSignupsSublink.ClickAsync();
        }

        [When(@"User clicks on Create user button and then enters organisation name and type and click on save button")]
        public async Task WhenUserClicksOnCreateUserButtonAndThenEntersOrganisationNameAndTypeAndClickOnSaveButton(Table table)
        {
            // Extracts the data from the table defined in the feature file for each user role.
            foreach (var row in table.Rows)
            {
                await _indexPage._btnAddNew.ClickAsync();
                await _createUserPage.CreateASignup($"{row[0]} Org 240823121945", row[2], row[3], row[1]);
            }
        }

        [Then(@"The signup is created successfully")]
        public async Task ThenTheSignupIsCreatedSuccessfully()
        {
            var _toastMessaege = await _indexPage.VerifyToastMessage();
            Assert.Equal("Success", _toastMessaege.ToString());
        }
    }
}
