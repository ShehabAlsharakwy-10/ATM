namespace ATM
{
    internal class Program
    {
        static int balance = 2000;
        static void Main(string[] args)
        {
            Console.Write("Enter your Name: ");
            String name = Console.ReadLine();
            Console.Write("Enter your Password: ");
            int password = int.Parse(Console.ReadLine());
            if (password == 1234)
            {
                Console.WriteLine($"Hello, {name}!");
                bool keepRunning = true;
                while (keepRunning)
                {
                    Console.WriteLine("===============Options===============");
                    Console.WriteLine("1. Balance Inquiry");
                    Console.WriteLine("2. Withdraw balance");
                    Console.WriteLine("3. Deposit balance");
                    Console.WriteLine("4. Exit");
                    Console.Write("Process: ");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            balanceInquiry();
                            break;
                        case 2:
                            withdraw();
                            break;
                        case 3:
                            depositBalance();
                            break;
                        case 4:
                            Console.Write("Thank you for using ATM!");
                            keepRunning = false;
                            break;
                        default:
                            Console.WriteLine("Wrong choice. Try again.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Password. Try Again.");
            }
        }
        private static void balanceInquiry()
        {
            Console.WriteLine($"Your Balance is = {balance}");
        }

        private static void withdraw()
        {
            Console.Write("Enter the amount to withdraw: ");
            int value = int.Parse(Console.ReadLine());

            if (value > balance || value < 500)
            {
                Console.WriteLine("Try Again");
            }
            else
            {
                balance -= value;
                Console.WriteLine($"Withdrawal successful. Your current balance is {balance}");
            }
        }

        private static void depositBalance()
        {
            Console.Write("Enter the amount to deposit: ");
            int value = int.Parse(Console.ReadLine());

            balance += value;
            Console.WriteLine($"Deposit successful. Your total balance is {balance}");
        }
    }
}
