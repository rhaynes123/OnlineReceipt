using System;

namespace OnlineReceipt
{
    class MainClass
    {
        public interface IOnlineTrans
        {
            void DisplayOnlineTrans();
            double getTransAmounts();
        }
        public class OnlineTrans:IOnlineTrans
        {
            private string TransactionCode;
            private DateTime OnlineTransDate;
            private double OnlineTransAmount;

            public OnlineTrans()
            {
                TransactionCode = "";
                OnlineTransDate = DateTime.Now;
                OnlineTransAmount = 0.0;
                
            }
            public OnlineTrans(string code, DateTime date, double amount)
			{
				TransactionCode = code;
                OnlineTransDate = DateTime.Now;
				OnlineTransAmount = amount;

			}
            //Methods
            public double getTransAmounts()
            {
                return OnlineTransAmount;
            }

            public void DisplayOnlineTrans()

            {
                Console.WriteLine("Transaction: {0}", TransactionCode);
                Console.WriteLine("Date: {0}", OnlineTransDate);
                Console.WriteLine("Amount: {0}", OnlineTransAmount);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter amount to be withdrawn");
            double withDrawnAmount = double.Parse(Console.ReadLine());
            OnlineTrans firstTransaction = new OnlineTrans("001", DateTime.Now, withDrawnAmount);
            firstTransaction.DisplayOnlineTrans();
        }
    }
}
