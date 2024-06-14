using Proxy;

IBankAccount bankAccount = new BankAccountProxy("admin", "password");
bankAccount.GetBalance();

bankAccount.PayIn(99);
bankAccount.GetBalance();

bankAccount.PayOut(50);
bankAccount.GetBalance();