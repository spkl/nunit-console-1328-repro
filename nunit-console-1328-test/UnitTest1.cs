using nunit_console_1328_repro_lib;
using System.Globalization;

namespace nunit_console_1328_test
{
    [TestFixture, RequiresThread(ApartmentState.STA)]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }

        [Test]
        public void CanOpenAndCloseWindow1()
        {
            Window1 window = new Window1();
            window.Show();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            window.Close();
        }
    }
}