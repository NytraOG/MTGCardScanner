using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OCRLibrary.Tests
{
    [TestClass]
    public class ScanServiceTests
    {
        private ScanService service;

        [TestInitialize]
        public void Init()
        {
            service = new ScanService();
        }

        [TestMethod]
        public void METHOD_SCENARIO_RESULT()
        {
            // Arrange
            

            // Act
            service.MachScan();

            // Assert
        }
    }
}