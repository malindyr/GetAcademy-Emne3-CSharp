namespace Nunit_Test_Proj._05._30._24
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        //assert
        //add
        //arrange

        [Test]
        public void TestAddAB()
        {

            //assert
            var slay2 = new Slay2();

            int result = slay2.AddAB(2,2);

            //add
            int subrtactingAB = slay2.SubtractAB(4,2);

                     //Assert.AreEqual(2, slay2.AddAB);
                       Assert.AreEqual(4, result); //outdated apparently



         //arrange            //Assert.That(slay2.AddAB(), Is.EqualTo(2));
         Assert.That(result, Is.EqualTo(2));

         Assert.That(subrtactingAB, Is.EqualTo(2));
        
                     //Assert.That(2, Is.EqualTo(slay2.AddAB)); write it in the correct direction next time:P

           
        }

        public void TestSubtractAB()
        {
            //assert
            var slay3 = new Slay2();

            //add
            int result = slay3.SubtractAB(3,2);

            //arrange
            Assert.That(result, Is.EqualTo(1));
        }
    }
}