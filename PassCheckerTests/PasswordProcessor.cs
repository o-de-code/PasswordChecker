namespace PassCheckerTests
{
    public class PasswordProcessor_Tests
    {
        [SetUp]
        public void Setup()
        {
            var examples = new string[]
            {
                "a 1-2 Password",
                "b 0 Password",
                "c 6-10 Password",
                "d 1-2 Passworddd",
                "e 3 Password",
                "f 1 Passford"
            };


        }

        [Test]
        public void ValidPassword()
        {
            Assert.Pass();
        }

        [Test]
        public void InvalidPassword()
        { 
            Assert.Pass(); 
        }

        [Test]
        public void MessInFile_ZeroValid()
        { 
            Assert.Pass(); 
        }
    }
}