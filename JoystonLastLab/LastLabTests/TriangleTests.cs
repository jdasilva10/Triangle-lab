using JoystonLastLab;

namespace LastLabTests
{
    public class TriangleTests

    {
        private Triangle tr { get; set; }

        [SetUp]
        public void Setup()
        {
            tr = new Triangle();
        }

        [Test]
        public void ValidTriangle_WithValidAngles_ReturnsValidTriangle()
        {
            //Arrange
            int FirstAngle = 45;
            int SecondAngle = 45;
            int ThirdAngle = 45;

            string expected = "The Triangle is not Valid.";

            //Act
            String actual = tr.ValidTriangle(FirstAngle, SecondAngle, ThirdAngle);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTriangle_WithNegativeAngles_ReturnsInValidTriangle()
        {
            //Arrange
            int FirstAngle = -45;
            int SecondAngle = 45;
            int ThirdAngle = 45;

            string expected = "The Triangle is not Valid.";

            //Act
            String actual = tr.ValidTriangle(FirstAngle, SecondAngle, ThirdAngle);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTriangle_WithZeroAngles_ReturnsInValidTriangle()
        {
            //Arrange
            int FirstAngle = 0;
            int SecondAngle = 0;
            int ThirdAngle = 0;

            string expected = "The Triangle is not Valid.";

            //Act
            String actual = tr.ValidTriangle(FirstAngle, SecondAngle, ThirdAngle);

            Assert.AreEqual(expected, actual);
        }

    }
}