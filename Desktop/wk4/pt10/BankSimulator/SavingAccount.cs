using System;
namespace BankSimulator
{
	public class SavingAccount : BankAccount
	{
		public SavingAccount(int number) : base(number) 
		{
		}

		public override string details()
		{
			string message = string.Empty;
			message = "Savings account:" + accNumber + "\tBalance:" + accBalance;
			return message;
		}
	}
}
