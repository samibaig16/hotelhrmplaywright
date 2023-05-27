using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HotelHRMPlayWright.OrangeHRM.PIM
{
    internal class PIM
    {
        private readonly IPage _page;
        private readonly ILocator Employeename;
        private readonly ILocator SelectEmployee;
        private readonly ILocator EmployeeId;
        private readonly ILocator Status;
        private readonly ILocator SelectStatus;
        private readonly ILocator Include;
        private readonly ILocator selecting;
        private readonly ILocator SupervisorName;
        private readonly ILocator SelectSupervisorName;
        private readonly ILocator JobTitle;
        private readonly ILocator SelectJobTitle;
        private readonly ILocator SubUnit;
        private readonly ILocator SelectSubUnit;
        private readonly ILocator SearchBtn;
        private readonly ILocator ResetBtn;
        private readonly ILocator AddEmp;
        private readonly ILocator firstname;
        private readonly ILocator middlename;
        private readonly ILocator lastname;
        private readonly ILocator EmpId;
        private readonly ILocator SaveButton;
        private readonly ILocator Image;
        private readonly ILocator nickname;
        private readonly ILocator otherId;
        private readonly ILocator Reports;
        private readonly ILocator reportname;
        private readonly ILocator selectreportname;
        private readonly ILocator searchreport;

        public PIM(IPage page)
        {
            _page = page;
            Employeename = _page.GetByPlaceholder("Type for hints...").First;
            SelectEmployee = _page.GetByRole(AriaRole.Listbox);
            //dddeewrewr
            EmployeeId = _page.GetByRole(AriaRole.Textbox).Nth(2);
            Status = _page.Locator("form i").First;
            SelectStatus = _page.GetByText("Full -Time (Contract)");
            SupervisorName = _page.GetByPlaceholder("Type for hints...").Nth(1);
            SelectSupervisorName = _page.GetByRole(AriaRole.Listbox);
            JobTitle = _page.Locator("form i").Nth(2);
            SelectJobTitle = _page.GetByRole(AriaRole.Option, new() { Name = "QA Lead" });
            SubUnit = _page.Locator("form i").Nth(3);
            SelectSubUnit = _page.GetByRole(AriaRole.Option, new() { Name = "Development" });
            Include = _page.Locator("form i").Nth(1);
            selecting = _page.GetByText("Current and Past Employees");
            SearchBtn = _page.GetByRole(AriaRole.Button, new() { Name = "Search" });
            ResetBtn = _page.GetByRole(AriaRole.Button, new() { Name = "Reset" });
            AddEmp = _page.GetByRole(AriaRole.Button, new() { Name = " Add" });
            firstname = _page.GetByPlaceholder("First Name");
            middlename = _page.GetByPlaceholder("Middle Name");
            lastname = _page.GetByPlaceholder("Last Name");
            EmpId = _page.Locator("form").GetByRole(AriaRole.Textbox).Nth(4);
            SaveButton = _page.GetByRole(AriaRole.Button, new() { Name = "Save" });
            Image = _page.Locator("div").Filter(new() { HasTextRegex = new Regex("^Accepts jpg, \\.png, \\.gif up to 1MB\\. Recommended dimensions: 200px X 200px$") }).Locator("div").Nth(3);
            nickname =_page.Locator("div").Filter(new() { HasTextRegex = new Regex("^Employee Full NameNickname$") }).GetByRole(AriaRole.Textbox).Nth(3);
            otherId = _page.Locator("div").Filter(new() { HasTextRegex = new Regex("^Employee IdOther Id$") }).GetByRole(AriaRole.Textbox).Nth(1);
            Reports = _page.GetByRole(AriaRole.Listitem).Filter(new() { HasText = "Reports" });
            reportname = _page.GetByPlaceholder("Type for hints...");
            selectreportname = _page.GetByRole(AriaRole.Option, new() { Name = "Employee Contact info report" });
            searchreport = _page.GetByRole(AriaRole.Button, new() { Name = "Search" });
            Status = _page.Locator("form i").First;
            SelectStatus = _page.GetByRole(AriaRole.Option, new() { Name = "Part-Time Contract" });

        }
        public async Task PIMPage(string url)
        {
            await _page.GotoAsync(url);
/*            await Employeename.ClickAsync();*/
            await Employeename.FillAsync("Alice Duval");
            Thread.Sleep(3000);
            await SelectEmployee.ClickAsync();
            await SupervisorName.FillAsync("Odis Adalwin");
            Thread.Sleep(3000);
            await SelectSupervisorName.ClickAsync();
            await EmployeeId.FillAsync("0221");
            await JobTitle.ClickAsync();
            await SelectJobTitle.ClickAsync();
            await Status.ClickAsync();
            await SelectStatus.ClickAsync();
            await _page.Keyboard.PressAsync("ArrowDown");
            await _page.Keyboard.PressAsync("ArrowDown");
            await _page.Keyboard.PressAsync("ArrowDown");
            await _page.Keyboard.PressAsync("Enter");
            await _page.Locator("form i").Nth(1).ClickAsync();
            await _page.Keyboard.PressAsync("ArrowDown");
            await _page.Keyboard.PressAsync("ArrowDown");
            await _page.Keyboard.PressAsync("Enter");
            await _page.Locator("form i").Nth(3).ClickAsync();
            await _page.Keyboard.PressAsync("ArrowDown");
            await _page.Keyboard.PressAsync("ArrowDown");
            await _page.Keyboard.PressAsync("Enter");
            await _page.Locator("form i").Nth(3).ClickAsync();
            await _page.Keyboard.PressAsync("ArrowDown");
            await _page.Keyboard.PressAsync("ArrowDown");
            await _page.Keyboard.PressAsync("ArrowDown");
            await _page.Keyboard.PressAsync("Enter");
            await SearchBtn.ClickAsync();
            await ResetBtn.ClickAsync();
            await AddEmp.ClickAsync();
            Thread.Sleep(2000);
            await firstname.FillAsync("Mirza");
            await middlename.FillAsync("SamiUllah");
            await lastname.FillAsync("Baig");
            await EmpId.FillAsync("031697");
            await SaveButton.ClickAsync();
            Thread.Sleep(3000);
            await nickname.FillAsync("slack");
            await otherId.FillAsync("fa20bscs0019");
            await Reports.ClickAsync();
            await reportname.FillAsync("Employee");
            await selectreportname.ClickAsync();
            await searchreport.ClickAsync();




            /*            // Upload the file
                        await fileInput.SetInputFilesAsync(filePath);
                        await ImageOption.ClickAsync();
                        await ImageOption.FillAsync("\"C:\\Users\\shahr\\Desktop\\rere.jpg\"");
                        await SaveButton.ClickAsync();*/




        }

    }
}
