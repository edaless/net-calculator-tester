namespace TestProject1
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{

        //}

        [Test]
        public void Test1()
        {
            var somma = Add(1, 4);

            Assert.AreEqual(somma, 1+4, "sbagliato")
        }
    }
}