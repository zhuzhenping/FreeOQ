using FreeQuant;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Instruments
{
	[Serializable]
	public class Account
	{
		private AccountTransactionList transactions;
		private AccountPositionList positions;

		public string Name { get; set; }
		public string Description { get; set; }
		public Currency Currency { get; set; }

		public AccountTransactionList Transactions
		{
			get
			{
				return this.transactions;
			}
		}

		public AccountPositionList Positions
		{
			get
			{
				return this.positions; 
			}
		}

		public double this[Currency currency]
		{
			get
			{
				AccountPosition accountPosition = this.positions[currency];
				if (accountPosition != null)
					return accountPosition.Value;
				else
					return 0.0;
			}
		}

		public event EventHandler AccountChanged;
		public event AccountTransactionEventHandler TransactionAdded;

		public Account(string name, string description, Currency currency)
		{
			this.transactions = new AccountTransactionList();
			this.positions = new AccountPositionList();
			this.Name = name;
			this.Description = description;
			this.Currency = currency;
		}

		public Account(string name, string description) : this(name, description, CurrencyManager.DefaultCurrency)
		{
		}

		public Account(string name) : this(name, string.Empty)
		{
		}

		public Account(string name, Currency currency) : this(name, string.Empty, currency)
		{
		}

		public Account(Currency currency) : this(string.Empty, currency)
		{
		}

		public Account() : this(CurrencyManager.DefaultCurrency)
		{
		}

		public double GetValue()
		{
			double num = 0.0;
			foreach (AccountPosition accountPosition in this.positions)
				num += Currency.Convert(accountPosition.Value, accountPosition.Currency, this.Currency);
			return num;
		}

		public double GetValue(DateTime dateTime)
		{
			Account account = new Account(this.Currency);
			foreach (AccountTransaction transaction in this.transactions)
			{
				if (transaction.DateTime <= dateTime)
					account.Add(transaction);
			}
			double num = 0.0;
			foreach (AccountPosition accountPosition in account.Positions)
				num += Currency.Convert(accountPosition.Value, accountPosition.Currency, this.Currency, dateTime);
			return num;
		}

		public void Clear()
		{
			this.transactions.Clear();
			this.positions.Clear();
		}

		public void Add(AccountTransaction transaction)
		{
			AccountPosition position = this.positions[transaction.Currency];
			if (position == null)
			{
				position = new AccountPosition(transaction.Currency);
				this.positions.Add(position);
			}
			this.transactions.Add(transaction);
			this.EmitTransactionAdded(transaction);
			position.Value += transaction.Value;
			this.EmitAccountChanged();
		}

		public void Add(Transaction transaction)
		{
			this.Add(new AccountTransaction(transaction));
		}

		public void Add(double val, Currency currency, DateTime dateTime, string text)
		{
			this.Add(new AccountTransaction(val, currency, dateTime, text));
		}

		public void Add(double val, Currency currency, DateTime dateTime)
		{
			this.Add(new AccountTransaction(val, currency, dateTime));
		}

		public void Add(double val, Currency currency, string text)
		{
			this.Add(val, currency, Clock.Now, text);
		}

		public void Add(double val, Currency currency)
		{
			this.Add(val, currency, Clock.Now);
		}

		public void Add(double val, DateTime dateTime)
		{
			this.Add(val, this.Currency, dateTime);
		}

		public void Add(double val)
		{
			this.Add(val, this.Currency, Clock.Now);
		}

		public void Deposit(double val, Currency currency, DateTime dateTime, string text)
		{
			this.Add(val, currency, dateTime, text);
		}

		public void Deposit(double val, Currency currency, DateTime dateTime)
		{
			this.Add(val, currency, dateTime);
		}

		public void Deposit(double val, Currency currency)
		{
			this.Deposit(val, currency, Clock.Now);
		}

		public void Deposit(double val)
		{
			this.Deposit(val, this.Currency, Clock.Now);
		}

		public void Deposit(double val, DateTime dateTime)
		{
			this.Deposit(val, this.Currency, dateTime);
		}

		public void Deposit(double val, string text)
		{
			this.Deposit(val, this.Currency, Clock.Now, text);
		}

		public void Deposit(double val, DateTime dateTime, string text)
		{
			this.Deposit(val, this.Currency, dateTime, text);
		}

		public void Withdraw(double val, Currency currency, DateTime dateTime, string text)
		{
			this.Add(-Math.Abs(val), currency, dateTime, text);
		}

		public void Withdraw(double val, Currency currency, DateTime dateTime)
		{
			this.Add(-Math.Abs(val), currency, dateTime);
		}

		public void Withdraw(double val, Currency currency)
		{
			this.Withdraw(val, currency, Clock.Now);
		}

		public void Withdraw(double val)
		{
			this.Withdraw(val, this.Currency, Clock.Now);
		}

		public void Withdraw(double val, DateTime dateTime)
		{
			this.Withdraw(val, this.Currency, dateTime);
		}

		public void Withdraw(double val, string text)
		{
			this.Withdraw(val, this.Currency, Clock.Now, text);
		}

		public void Withdraw(double val, DateTime dateTime, string text)
		{
			this.Withdraw(val, this.Currency, dateTime, text);
		}

		private void EmitAccountChanged()
		{
            if (this.AccountChanged != null)
                this.AccountChanged(this, EventArgs.Empty);
		}

        private void EmitTransactionAdded(AccountTransaction transaction)
		{
            if (this.TransactionAdded != null)
                this.TransactionAdded(this, new AccountTransactionEventArgs(transaction));
		}
	}
}
