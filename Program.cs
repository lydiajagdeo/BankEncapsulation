using BankEncapsulation;

BankAccount myAccount = new BankAccount();

Console.WriteLine("Enter amount to be deposited");

var amountToDeposit = double.Parse(Console.ReadLine());

myAccount.Deposit(amountToDeposit);

myAccount.Deposit(200.00);

Console.WriteLine(myAccount.GetBalance());
