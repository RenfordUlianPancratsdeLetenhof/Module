using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module;

namespace YourNamespace.Tests
{
    [TestClass]
    public class VolyeryTests
    {
        [TestMethod]
        public void TestDuckVolyeryArea()
        {

            double landWidth = 5.0;
            double landLength = 7.0;
            double swimArea = 8.0;

            DackArea duckArea = new DackArea(landWidth, landLength, swimArea);


            double calculatedArea = duckArea.area();


            double expectedArea = landLength * swimArea;
            Assert.AreEqual(expectedArea, calculatedArea);
        }

        [TestMethod]
        public void TestPenguinVolyeryArea()
        {
            // Arrange
            double landWidth = 5.0;
            double landLength = 6.0;
            double swimArea = 3.0; // Assume a swim area of 3 square meters

            PenguinArea penguinArea = new PenguinArea(landWidth, landLength, swimArea);

            // Act
            double calculatedArea = penguinArea.area();

            // Assert
            double expectedArea = landLength * swimArea;
            Assert.AreEqual(expectedArea, calculatedArea);
        }

    }

}
