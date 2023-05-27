using HotelHRMPlayWright.OrangeHRM.Admin;
using HotelHRMPlayWright.OrangeHRM.Leaves;
using HotelHRMPlayWright.OrangeHRM.Login;
using HotelHRMPlayWright.OrangeHRM.PIM;
using Microsoft.Playwright.NUnit;

namespace HotelHRMPlayWright
{
    [TestFixture]
/*    [Parallelizable(ParallelScope.All)]*/
    public class TestExecution : PageTest
    {
        [Test]
        public async Task LoginPage_TC001()
        {
            Login login = new Login(Page);
            await login.LoginPage("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login", "Admin", "admin123");
        }
        [Test]
        public async Task AdminPage_TC001()
        {
            Login login = new Login(Page);
            await login.LoginPage("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login", "Admin", "admin123");

            Admin admin = new Admin(Page);
            await admin.AdminPage("https://opensource-demo.orangehrmlive.com/web/index.php/admin/viewSystemUsers");
        }
        [Test]
        public async Task PIMPAGE_TC001()
        {
            Login login = new Login(Page);
            await login.LoginPage("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login", "Admin", "admin123");

            PIM pim = new PIM(Page);
            await pim.PIMPage("https://opensource-demo.orangehrmlive.com/web/index.php/pim/viewEmployeeList");

        }
        [Test]
        public async Task LeavesPage_TC001() { 
        
            Login login = new Login(Page);
            await login.LoginPage("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login", "Admin", "admin123");
            Leaves leaves = new Leaves(Page);
            await leaves.LeavesPage("https://opensource-demo.orangehrmlive.com/web/index.php/leave/viewLeaveList");
        }
    }
}