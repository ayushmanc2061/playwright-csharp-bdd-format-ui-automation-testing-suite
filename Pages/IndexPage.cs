using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSecond.Pages
{
    public class IndexPage
    {
        private IPage _page;
        public IndexPage(IPage page) => _page = page;
        public ILocator _textManagementPageToast => _page.Locator("//span[@class='toast-message']");
        public ILocator _btnAddNew => _page.Locator("//button[@class='btn-add mb-0' or @class='btn-add mt-2' or @class='btn-add fa-plus-padding mb-0']");
        public ILocator _txtSearch => _page.Locator("//input[@placeholder='Search']");
        public ILocator _btnSearch => _page.Locator("//i[@title='Search given entry']");
        public ILocator _txtTableSearchData => _page.Locator("//tbody[@class='rz-datatable-data  rz-datatable-hoverable-rows']");

        public async Task<string> VerifyToastMessage()
        {
            await _textManagementPageToast.WaitForAsync();
            return await _textManagementPageToast.InnerTextAsync();
        }
    }
}
