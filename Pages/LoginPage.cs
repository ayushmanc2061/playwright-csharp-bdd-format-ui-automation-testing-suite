using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SpecFlowSecond.Pages
{
    public class LoginPage
    {
        private IPage _page;
        public LoginPage(IPage page) => _page = page;

        // Locators for the Login page elements
        private ILocator _btnAcceptConsent => _page.Locator("#acceptConsent");
        private ILocator _txtUserName => _page.Locator("#Name");
        private ILocator _txtPassword => _page.Locator("#Password");
        private ILocator _btnLogin => _page.Locator("text= Login");
        private ILocator _txtDashboardHeading => _page.Locator("text='Dashboard'>>nth=1");
        private ILocator _txtCompaniesPageHeading => _page.Locator("//h2[text()='Companies']");

        // This function clicks the Accept Consent button.
        public async Task ClickAcceptConsent() => await _btnAcceptConsent.ClickAsync();
        
        // This function fills the username and password fields and clicks the login button
        public async Task Login(string userName, string password)
        {
            await _btnAcceptConsent.ClickAsync();
            await _txtUserName.FillAsync(userName);
            await _txtPassword.FillAsync(password);
            await _btnLogin.ClickAsync();
        }

        // This function verifies if the dashboard heading is visible after login.
        public async Task<bool> VerifyDashboardHeading()
        {
            await _page.WaitForSelectorAsync("text='Dashboard'>>nth=1");
            return await _txtDashboardHeading.IsVisibleAsync();
        }

        // This function verifies if the Companies page heading is visible for user role investors, as they see different dashboard heading.
        public async Task<bool> VerifyDashboardHeading(string investor)
        {
            await _txtCompaniesPageHeading.WaitForAsync();
            return await _txtCompaniesPageHeading.IsVisibleAsync();
        }
    }
}
