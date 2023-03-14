using nunit_console_1328_repro_lib;

namespace nunit_console_1328_test
{
    [TestFixture, RequiresThread(ApartmentState.STA)]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
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