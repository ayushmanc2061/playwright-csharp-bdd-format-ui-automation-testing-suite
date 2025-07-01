using Microsoft.Playwright;
using SpecFlowSecond.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSecond.Pages
{
    public class OrganisationPage : Configurations
    {
        private IPage _page;
        public OrganisationPage(IPage page) => _page = page;

        // Locators for the Organisation page elements
        public ILocator _txtOrganisationManagementHeading => _page.Locator("//h3[text()='Organisation management']");
        public ILocator _txtOrganisationComposeHeading => _page.Locator("//h3[text()='Organisation management (Editor)']");
        public ILocator _txtOrganisationName => _page.Locator("//input[@id='name']");
        public ILocator _txtOrganisationDescription => _page.Locator("/textarea[@placeholder='Enter description']");
        public ILocator _listOrganisationType => _page.Locator("//span[@class='select2-selection__rendered']");
        public ILocator _btnOrganisationSave => _page.Locator("//button[text()='Save']");
        public ILocator _btnOrganisationReviewAndSave => _page.Locator("//button[contains(text(),'Review')]");
        public ILocator _btnOrganisationCancel => _page.Locator("//button[text()='Cancel']");
        public ILocator _tabOrganisationProfile => _page.Locator("//h6[contains(text(),'profile')]");
        
        //Investor Profile
        public ILocator _txtInvestorProfileSummary => _page.Locator("//textarea[@placeholder='Enter summary']");
        public ILocator _linkAdSixMonths => _page.Locator("//div[contains(text(),'Add 6 months')]");
        public ILocator _linkAdTwelveMonths => _page.Locator("//div[contains(text(),'Add 12 months')]");

        public const string ORGANIZATION_ADD_TOAST_MESSAGE = "Organisation item was added successfully..";
        public const string ORGANIZATION_EDIT_TOAST_MESSAGE = "Organisation item was updated successfully..";

        private static string OrganisationName = "";

        /// <summary>
        /// Verifies if the Organisation Management heading is visible on the page.
        /// </summary>
        public async Task VerifyOrganisationManagementHeading()
        {
            await _txtOrganisationManagementHeading.WaitForAsync();
            Assert.True(await _txtOrganisationManagementHeading.IsVisibleAsync());
        }

        /// <summary>
        /// Verifies if the Organisation Compose heading is visible on the page.
        /// </summary>
        public async Task VerifyOrganisationComposeHeading()
        {
            await _txtOrganisationComposeHeading.WaitForAsync();
            Assert.True(await _txtOrganisationComposeHeading.IsVisibleAsync());
        }

        /// <summary>
        /// Generic method for creating an organisation
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="wait"></param>
        /// <param name="OrganisationType">Type of the organisation</param>
        public async Task CreateAnOrganisation(string OrganisationType)
        {
            if (OrganisationType == "Admin")
            {
                OrganisationName = $"{OrganisationType} {Uniqueness}";
            }
            else if (OrganisationType == "Advisor")
            {
                OrganisationName = $"{OrganisationType} {Uniqueness}";
            }
            else if (OrganisationType == "Advocate")
            {
                OrganisationName = $"{OrganisationType} {Uniqueness}";
            }
            else if (OrganisationType == "Institutional investor")
            {
                OrganisationName = $"{OrganisationType} {Uniqueness}";
            }
            else if (OrganisationType == "Issuer")
            {
                OrganisationName = $"{OrganisationType} {Uniqueness}";
            }
            else if (OrganisationType == "Private investor")
            {
                OrganisationName = $"{OrganisationType} {Uniqueness}";
            }
            await _txtOrganisationName.FillAsync(OrganisationName);
            Thread.Sleep(1000);
            await _listOrganisationType.ClickAsync();
            await _page.Locator($"//li[contains(text(),'{OrganisationType}')]").ClickAsync();
            if (OrganisationType == "Institutional investor" | OrganisationType == "Private investor")
            {
                await _btnOrganisationReviewAndSave.ClickAsync();
                await _tabOrganisationProfile.ClickAsync();
                await _txtInvestorProfileSummary.FillAsync("Investor profile description");
                await _linkAdSixMonths.ClickAsync();
            }
            if (OrganisationType == "Advisor")
            {
                await _btnOrganisationReviewAndSave.ClickAsync();
            }            
            await _btnOrganisationSave.ClickAsync();
        }
    }
}
