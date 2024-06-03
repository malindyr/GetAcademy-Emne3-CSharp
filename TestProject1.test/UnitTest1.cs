
namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void TestAddMethod()
        {
            // Arrange
            var slay = new Slay();

            // Act
            var result = slay.AddSlay(2,2); // Calling the Add method, assuming that's what you intended

            // Assert
            Assert.AreEqual(4, result); // Using Assert.AreEqual for comparison
            Assert.That(result, Is.EqualTo(4)); // Using Assert.That with Is.EqualTo constraint
        }
    }
}

//test tab upper bar
//click "run all tests" button in the test tab