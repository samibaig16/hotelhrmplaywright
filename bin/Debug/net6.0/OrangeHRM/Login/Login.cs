using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelHRMPlayWright.OrangeHRM.Login
{
    internal class Login
    {
        private readonly IPage _page;
        private readonly ILocator usernameTxt;
        private readonly ILocator passwordTxt;
        private readonly ILocator loginBtn;

        public Login(IPage page)
        {
            _page = page;
            usernameTxt = _page.GetByPlaceholder("Username");
            passwordTxt = _page.GetByPlaceholder("Password");
            loginBtn = _page.GetByRole(AriaRole.Button, new() { Name = "Login" });
        }
        public async Task LoginPage(string url, string user, string pass)
        {
            await _page.GotoAsync(url);
            await usernameTxt.FillAsync(user);
            await passwordTxt.FillAsync(pass);
            await loginBtn.ClickAsync();
        }
    }
}
