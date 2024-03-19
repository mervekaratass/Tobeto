using Encapsulation;

/*Encapsulation
 Encapsulation, bir sınıfın verilerini (fields) ve işlevselliğini (methods) bir arada gruplayarak,
 dışarıdan erişimi kontrol altına almak anlamına gelir.
 Bu şekilde sınıfın iç yapısı dışarıya karşı gizlenir ve sınıfın daha iyi bir şekilde kontrol edilmesini sağlar.*/

BankAccount account = new BankAccount();
account.Deposit(1000);
account.Withdraw(500);
Console.WriteLine($"Current balance: {account.GetBalance()}");