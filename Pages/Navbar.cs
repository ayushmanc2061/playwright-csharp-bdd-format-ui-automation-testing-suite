using Microsoft.Playwright;

namespace SpecFlowSecond.Pages
{
    public class Navbar
    {
        private IPage _page;
        public Navbar(IPage page) => _page = page;
        public ILocator _linkNavbar => _page.Locator("//div[@id='kt_aside_menu']");

        // Navbar Locators
        //Admin Navbar
        public ILocator _linkNavbarDashboard => _page.Locator("//span[contains(text(),'Dashboard')]");
        public ILocator _linkNavbarDealAnalytics => _page.Locator("//span[contains(text(),'Deal analytics')]");
        public ILocator _linkNavbarCompanies => _page.Locator("//span[contains(text(),'Companies')])[1]");
        public ILocator _linkNavbarOffers => _page.Locator("(//span[contains(text(),'Offers')])[1]");
        public ILocator _linkNavbarInvestorProfiles => _page.Locator("//span[contains(text(),'Investor profiles')]");
        public ILocator _linkNavbarMeetings => _page.Locator("//span[contains(text(),'Meetings')]");

        //Audit management
        public ILocator _linkNavbarAuditManagement => _page.Locator("//span[contains(text(),'Audit management')]");
        public ILocator _linkNavbarEmailsSublink => _page.Locator("//span[text()='Emails']");
        public ILocator _linkNavbarAuditsSublink => _page.Locator("//span[contains(text(),'Audits')]");
        public ILocator _linkNavbarPageVisitsSublink => _page.Locator("//span[contains(text(),'Page Visits')]");

        //News management
        public ILocator _linkNavbarNewsManagement => _page.Locator("//span[contains(text(),'News management')]"); 
        public ILocator _linkNavbarNotificationsSublink => _page.Locator("//span[contains(text(),'Notifications')]");
        public ILocator _linkNavbarNewsSublink => _page.Locator("//span[contains(text(),'News')]");

        //Auction management
        public ILocator _linkNavbarAuctionManagement => _page.Locator("//span[contains(text(),'Auction management')]");
        public ILocator _linkNavbarOffersSublink => _page.Locator("//span[text()='Offers']");
        public ILocator _linkNavbarFlagsSublink => _page.Locator("//span[text()='Flags']");
        public ILocator _linkNavbarTranchesSublink => _page.Locator("//span[text()='Tranches']");
        public ILocator _linkNavbarBidsSublink => _page.Locator("//span[text()='Bids']");
        public ILocator _linkNavbarPreequisiteActionsSublink => _page.Locator("//span[text()='Prerequisite actions']");

        //Interest Management
        public ILocator _linkNavbarInterest => _page.Locator("//span[contains(text(),'Interest')]");
        public ILocator _linkNavbarSecondarySublink => _page.Locator("//span[text()='Secondary']");
        public ILocator _linkNavbarPrivateSublink => _page.Locator("//span[text()='Private']");

        //Form management
        public ILocator _linkNavbarForms => _page.Locator("(//span[contains(text(),'Forms')])[1]");
        public ILocator _linkNavbarQuestionaniresSublink => _page.Locator("//span[text()='Questionnaires']");
        public ILocator _linkNavbarFormsSublink => _page.Locator("(//span[contains(text(),'Forms')])[2]");

        //Company Management
        public ILocator _linkNavbarCompanyManagement => _page.Locator("//span[contains(text(),'Company management')]");
        public ILocator _linkNavbarCompaniesSublink => _page.Locator("//span[contains(text(),'Company management')]//following::span[text()='Companies']");
        public ILocator _linkNavbarDataRoomsSublink => _page.Locator("//span[text()='Data rooms']");
        public ILocator _linkNavbarOrganisationsSublink => _page.Locator("//span[text()='Organisations']");
        public ILocator _linkNavbarSettlementsSublink => _page.Locator("//span[text()='Settlements']");
        public ILocator _linkNavbarMatchmakingSublink => _page.Locator("//span[contains(text(),'Matchmaking')]");
        public ILocator _linkNavbarTagsSublink => _page.Locator("//span[text()='Tags']");
        public ILocator _linkNavbarMarkersSublink => _page.Locator("//span[text()='Markers']");
        public ILocator _linkNavbarInvestorFundsSublink => _page.Locator("//span[contains(text(),'Investor funds')]");
        public ILocator _linkNavbarLicencesSublink => _page.Locator("//span[contains(text(),'Lincences')]");

        //User management
        public ILocator _linkNavbarUserManagement => _page.Locator("//span[contains(text(),'User management')]");
        public ILocator _linkNavbarUsersSublink => _page.Locator("//span[text()='Users']");
        public ILocator _linkNavbarRolesSublink => _page.Locator("//span[text()='Roles']");
        public ILocator _linkNavbarSignupsSublink => _page.Locator("//span[text()='Signups']");
        public ILocator _linkNavbarReferralsSublink => _page.Locator("//span[text()='Referrals']");

        //Profile Popup
        public ILocator _linkNavbarUserProfile => _page.Locator("//span[@id='userProfile-menu-title']");
        public ILocator _linkNavbarSettings => _page.Locator("//a[@title='Go to settings']");
        public ILocator _linkNavbarMyProfile => _page.Locator("//a[@title='Go to my profile']");
        public ILocator _linkNavbarLogout => _page.Locator("//span[text()='Logout']");

        //Issuer Navbar
        public ILocator _linkIssuerNavbarMyCompanyLink => _page.Locator("//span[contains(text(),'My Company')]");
        public ILocator _linkIssuerNavbarMergerAndAcquicitionsLink => _page.Locator("//span[contains(text(),'Merger and acquicitions')]");
        public ILocator _linkIssuerNavbarDocumentAccessLink => _page.Locator("//span[contains(text(),'Document access')]");
        public ILocator _linkIssuerNavbarReferAnInvestorLink => _page.Locator("//span[contains(text(),'Refer an investor')]");

        //Investor Navbar
        public ILocator _linkInvestorNavbarHomeLink => _page.Locator("//span[contains(text(),'Home')]");
        public ILocator _linkInvestorNavbarCompaniesLink => _page.Locator("(//span[contains(text(),'Companies')])[1]");
        public ILocator _linkInvestorNavbarCompaniesSublink => _page.Locator("//span[contains(text(),'Companies')]//following::span[text()='Companies']");
        public ILocator _linkInvestorNavbarOffersSublink => _page.Locator("//span[contains(text(),'Companies')]//following::span[text()='Offers']");
        public ILocator _linkInvestorNavbarInvestorsLink => _page.Locator("//span[contains(text(),'Investors')]");
        public ILocator _linkInvestorNavbarMyInvitationsSublink => _page.Locator("//span[contains(text(),'Investors')]//following::span[contains(text(),'My invitations')]");
        public ILocator _linkInvestorNavbarReferralsSublink => _page.Locator("//span[contains(text(),'Investors')]//following::span[contains(text(),'Referrals')]");
        public ILocator _linkInvestorNavbarReferAnInvestorSublink => _page.Locator("//span[contains(text(),'Investors')]//following::span[contains(text(),'Refer an investor')]");
        
        // Verify Navbar appeared and enabled so that we can proceed with further actions with the navbar.
        public async Task<bool> VerifyNavbarAppearance()
        {
            await _linkNavbar.WaitForAsync();
            return await _linkNavbar.IsEnabledAsync();
        }

        // Verify if the Navbar is visible for the user.
        public async Task<bool> VerifyNavbarItem(string item)
        {
            switch(item.ToLower())
            {
                case "dashboard":
                    await _linkNavbarDashboard.WaitForAsync();
                    return await _linkNavbarDashboard.IsVisibleAsync();
                    break;
                case "deal analytics":
                    await _linkNavbarDealAnalytics.WaitForAsync();
                    return await _linkNavbarDealAnalytics.IsVisibleAsync();
                    break;
                case "companies":
                    await _linkInvestorNavbarCompaniesLink.WaitForAsync();
                    return await _linkInvestorNavbarCompaniesLink.IsVisibleAsync();
                    break;
                case "offers":
                    await _linkNavbarOffers.WaitForAsync();
                    return await _linkNavbarOffers.IsVisibleAsync();
                    break;
                case "investor profiles":
                    await _linkNavbarInvestorProfiles.WaitForAsync();
                    return await _linkNavbarInvestorProfiles.IsVisibleAsync();
                    break;
                case "meetings":
                    await _linkNavbarMeetings.WaitForAsync();
                    return await _linkNavbarMeetings.IsVisibleAsync();
                    break;

                // Admin's
                case "audit management":
                    await _linkNavbarAuditManagement.WaitForAsync();
                    return await _linkNavbarAuditManagement.IsVisibleAsync();
                    break;
                case "news management":
                    await _linkNavbarNewsManagement.WaitForAsync();
                    return await _linkNavbarNewsManagement.IsVisibleAsync();
                    break;
                case "auction management":
                    await _linkNavbarAuctionManagement.WaitForAsync();
                    return await _linkNavbarAuctionManagement.IsVisibleAsync();
                    break;
                case "forms":
                    await _linkNavbarForms.WaitForAsync();
                    return await _linkNavbarForms.IsVisibleAsync();
                    break;
                case "company management":
                    await _linkNavbarCompanyManagement.WaitForAsync();
                    return await _linkNavbarCompanyManagement.IsVisibleAsync();
                    break;
                case "user management":
                    await _linkNavbarUserManagement.WaitForAsync();
                    return await _linkNavbarUserManagement.IsVisibleAsync();
                    break;

                // Investor's
                case "home":                    
                    await _linkInvestorNavbarHomeLink.WaitForAsync();
                    return await _linkInvestorNavbarHomeLink.IsVisibleAsync();
                    break;

                case "investors":
                    await _linkInvestorNavbarInvestorsLink.WaitForAsync();
                    return await _linkInvestorNavbarInvestorsLink.IsVisibleAsync();
                    break;

                //Issuer's
                case "my company":
                    await _linkIssuerNavbarMyCompanyLink.WaitForAsync();
                    return await _linkIssuerNavbarMyCompanyLink.IsVisibleAsync();
                    break;
                case "merger and acquisitions":
                    await _linkIssuerNavbarMergerAndAcquicitionsLink.WaitForAsync();
                    return await _linkIssuerNavbarMergerAndAcquicitionsLink.IsVisibleAsync();
                    break;
                case "matchmaking":
                    await _linkNavbarMatchmakingSublink.WaitForAsync();
                    return await _linkNavbarMatchmakingSublink.IsVisibleAsync();
                    break;
                case "data rooms":
                    await _linkNavbarDataRoomsSublink.WaitForAsync();
                    return await _linkNavbarDataRoomsSublink.IsVisibleAsync();
                    break;
                case "document access":
                    await _linkIssuerNavbarDocumentAccessLink.WaitForAsync();
                    return await _linkIssuerNavbarDocumentAccessLink.IsVisibleAsync();
                    break;

            }
            return false;
        }

        // Verify if the sub-navbar item is visible for the user.
        public async Task<bool> VerifySubNavbarItem(string subItem, string mainItem)
        {
            switch (subItem.ToLower(), mainItem.ToLower())
            {
                //Admin's Audit management
                case ("emails", "audit management"):
                    await _linkNavbarAuditManagement.WaitForAsync();
                    await _linkNavbarAuditManagement.ClickAsync();
                    await _linkNavbarEmailsSublink.WaitForAsync();
                    return await _linkNavbarEmailsSublink.IsVisibleAsync();
                    break;

                case ("audits", "audit management"):
                    await _linkNavbarAuditManagement.WaitForAsync();
                    await _linkNavbarAuditManagement.ClickAsync();
                    await _linkNavbarAuditsSublink.WaitForAsync();
                    return await _linkNavbarAuditsSublink.IsVisibleAsync();
                    break;

                case ("page visits", "audit management"):
                    await _linkNavbarAuditManagement.WaitForAsync();
                    await _linkNavbarAuditManagement.ClickAsync();
                    await _linkNavbarPageVisitsSublink.WaitForAsync();
                    return await _linkNavbarPageVisitsSublink.IsVisibleAsync();
                    break;

                case ("notifications", "news management"):
                    await _linkNavbarNewsManagement.WaitForAsync();
                    await _linkNavbarNewsManagement.ClickAsync();
                    await _linkNavbarNotificationsSublink.WaitForAsync();
                    return await _linkNavbarNotificationsSublink.IsVisibleAsync();
                    break;

                case ("news", "news management"):
                    await _linkNavbarNewsManagement.WaitForAsync();
                    await _linkNavbarNewsManagement.ClickAsync();
                    await _linkNavbarNewsSublink.WaitForAsync();
                    return await _linkNavbarNewsSublink.IsVisibleAsync();
                    break;

                //Investor's
                case ("companies", "companies"):
                    await _linkInvestorNavbarCompaniesLink.WaitForAsync();
                    await _linkInvestorNavbarCompaniesLink.ClickAsync();
                    await _linkInvestorNavbarCompaniesSublink.WaitForAsync();
                    return await _linkInvestorNavbarCompaniesSublink.IsVisibleAsync();
                    break;
                case ("offers", "companies"):
                    await _linkInvestorNavbarCompaniesLink.WaitForAsync();
                    await _linkInvestorNavbarCompaniesLink.ClickAsync();
                    await _linkNavbarOffersSublink.WaitForAsync();
                    return await _linkNavbarOffersSublink.IsVisibleAsync();
                    break;
                case ("meetings", "companies"):
                    await _linkInvestorNavbarCompaniesLink.WaitForAsync();
                    await _linkInvestorNavbarCompaniesLink.ClickAsync();
                    await _linkNavbarMeetings.WaitForAsync();
                    return await _linkNavbarMeetings.IsVisibleAsync();
                    break;
                case ("my invitations", "investors"):
                    await _linkInvestorNavbarInvestorsLink.WaitForAsync();
                    await _linkInvestorNavbarInvestorsLink.ClickAsync();
                    await _linkInvestorNavbarMyInvitationsSublink.WaitForAsync();
                    return await _linkInvestorNavbarMyInvitationsSublink.IsVisibleAsync();
                    break;
                case ("referrals", "investors"):
                    await _linkInvestorNavbarInvestorsLink.WaitForAsync();
                    await _linkInvestorNavbarInvestorsLink.ClickAsync();
                    await _linkInvestorNavbarReferralsSublink.WaitForAsync();
                    return await _linkInvestorNavbarReferralsSublink.IsVisibleAsync();
                    break;
                case ("refer an investor", "investors"):
                    await _linkInvestorNavbarInvestorsLink.WaitForAsync();
                    await _linkInvestorNavbarInvestorsLink.ClickAsync();
                    await _linkIssuerNavbarReferAnInvestorLink.WaitForAsync();
                    return await _linkIssuerNavbarReferAnInvestorLink.IsVisibleAsync();
                    break;
            }
            return false;
        }
    }
}
