namespace PasswordChecker_Tests
{
    [TestClass]
    public class PasswordProcessor_Test
    {
        [TestMethod]
        public void GetValidPasswordsNum_allLowercaseValid()
        {
            string[] lines = new string[]
            {
                "a 1-2 Password"
            };

            var passwordProcessor = new PasswordProcessor(lines);

            Assert.AreEqual(passwordProcessor.GetValidPasswordsNum(), 1);
        }
        
        [TestMethod]
        public void GetValidPasswordsNum_oneLetterUppercaseValid()
        {
            string[] lines = new string[]
            {
                "A 1-2 Password"
            };

            var passwordProcessor = new PasswordProcessor(lines);

            Assert.AreEqual(passwordProcessor.GetValidPasswordsNum(), 1);
        }
        
        [TestMethod]
        public void GetValidPasswordsNum_moreThanExpectetLettersInvalid()
        {
            string[] lines = new string[]
            {
                "a 1-2 Passwarda"
            };

            var passwordProcessor = new PasswordProcessor(lines);

            Assert.AreEqual(passwordProcessor.GetValidPasswordsNum(), 0);
        }
        
        [TestMethod]
        public void GetValidPasswordsNum_lessThanExpectetLettersInvalid()
        {
            string[] lines = new string[]
            {
                "a 1-2 Possword"
            };

            var passwordProcessor = new PasswordProcessor(lines);

            Assert.AreEqual(passwordProcessor.GetValidPasswordsNum(), 0);
        }

        [TestMethod]
        public void GetValidPasswordsNum_oneDigitInInstructionValid()
        {
            string[] lines = new string[]
            {
                "a 1 Password"
            };

            var passwordProcessor = new PasswordProcessor(lines);

            Assert.AreEqual(passwordProcessor.GetValidPasswordsNum(), 1);
        }


        [TestMethod]
        public void GetValidPasswordsNum_oneDigitInInstructionInvalid()
        {
            string[] lines = new string[]
            {
                "a 1 Possword"
            };

            var passwordProcessor = new PasswordProcessor(lines);

            Assert.AreEqual(passwordProcessor.GetValidPasswordsNum(), 0);
        }

        [TestMethod]
        public void GetValidPasswordsNum_zeroLettersIntsruction()
        {
            string[] lines = new string[]
            {
                "a 0 Possword"
            };

            var passwordProcessor = new PasswordProcessor(lines);

            Assert.AreEqual(passwordProcessor.GetValidPasswordsNum(), 1);
        }


        [TestMethod]
        public void GetValidPasswordsNum_arrayOfDifferentData()
        {
            string[] lines = new string[]
            {
                "a 1-2 Possword",
                "b 1 goBlin",
                "c 6-9 CarauTo",
                "d 0 Steven",
            };

            var passwordProcessor = new PasswordProcessor(lines);

            Assert.AreEqual(passwordProcessor.GetValidPasswordsNum(), 2);
        }
    }
}

