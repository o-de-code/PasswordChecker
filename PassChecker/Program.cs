using PassChecker;

var passwordProcessor = new PasswordProcessor(new FileReader().GetDataFromFile());
Console.WriteLine(passwordProcessor.GetValidPasswordsNum());