using Microsoft.Playwright;
using SpecFlowSecond.Config;
using System.Threading.Tasks;

namespace SpecFlowSecond.Pages
{
    public class CreateUserPage : Configurations
    {
        private IPage _page;
        public CreateUserPage(IPage page) => _page = page;

        // Locators for the Create User page elements
        public ILocator _listReferralType => _page.Locator("(//span[@class='select2-selection__rendered'])[1]");
        public ILocator _txtSingupFirstName => _page.Locator("//input[@id='first-name']");
        public ILocator _txtSingupLastName => _page.Locator("//input[@id='last-name']");
        public ILocator _txtSingupEmail => _page.Locator("//input[@id='email']");
        public ILocator _listSignupOrganisation => _page.Locator("(//span[@class='select2-selection__rendered'])[2]");
        public ILocator _txtSingupMobile => _page.Locator("//input[@id='mobile']");
        public ILocator _txtSingupTelephone => _page.Locator("//input[@id='phone']");
        public ILocator _btnSignupSave => _page.Locator("//button[text()='Save']");
        public ILocator _btnSignupCancel => _page.Locator("//button[text()='Cancel']");
        public ILocator _listSignupRole => _page.Locator("(//span[@class='select2-selection__rendered'])[4]");

        // This reusable function creates a new user signup with the provided details.
        public async Task CreateASignup(string OrganizationName, string FirstName, string LastName, string role)
        {
            await _txtSingupFirstName.FillAsync(FirstName);
            await _txtSingupLastName.FillAsync(LastName);
            await _txtSingupEmail.FillAsync($"{FirstName}{LastName}{Uniqueness}@gmail.com");
            Thread.Sleep(1000);
            await _listSignupOrganisation.ClickAsync();
            await _page.Locator($"//li[contains(text(),'{OrganizationName}')]").ClickAsync();
            Thread.Sleep(1000);
            await _listSignupRole.ClickAsync();
            await _page.Locator($"//li[contains(text(),'{role}')]").ClickAsync();
            await _btnSignupSave.ClickAsync();
        }
    }
}
