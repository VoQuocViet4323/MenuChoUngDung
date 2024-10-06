internal class Program
{
    private static void Main(string[] args)
    {
        int choice = -1;
        while (choice != 0)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Ve hinh tam giac");
            Console.WriteLine("2. Ve hinh vuong");
            Console.WriteLine("3. Ve hinh chu nhat");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("Nhap lua chon: ");
            choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Hinh tam giac");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * *");
                    Console.WriteLine("* * * *");
                    Console.WriteLine("* * *");
                    Console.WriteLine("* *");
                    Console.WriteLine("*");
                    break;
                case 2:
                    Console.WriteLine("Hinh vuong");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    break;
                case 3:
                    Console.WriteLine("Hinh chu nhat");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("No choice!");
                    break;
            }

        }
    }
}