namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //int num;
            //Console.WriteLine("Enter a number : ");
            //bool isnumber = int.TryParse(Console.ReadLine(), out  num);
            //if (num % 3 == 0 && num % 4 == 0)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");

            #endregion

            #region Q2
            //Console.WriteLine("Enter a Number : ");
            //int num;
            //bool isnumber = int.TryParse(Console.ReadLine(), out num);
            //if (num > 0)
            //{
            //     Console.WriteLine("Number Is Postive");
            //}
            //else
            //{
            //     Console.WriteLine("Number Is Negative");
            //}
            #endregion

            #region Q3
            //Console.Write("Enter first number: ");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //int n2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter third number: ");
            //int n3 = int.Parse(Console.ReadLine());
            //int max = Math.Max(n1, Math.Max(n2, n3));
            //int min = Math.Min(n1, Math.Min(n2, n3));
            //Console.WriteLine($"Max number = {max}");
            //Console.WriteLine($"Min number = {min}");
            #endregion

            #region Q4
            //Console.WriteLine("Enter a number : ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Number is even");
            //}
            //else
            //{
            //    Console.WriteLine("Number is odd");
            //}
            #endregion

            #region Q5
            //Console.WriteLine("Enter a character : ");
            //char ch = char.Parse(Console.ReadLine().ToLower());
            //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //{
            //    Console.WriteLine("Character is a vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Character is a consonant");
            //}
            #endregion

            #region Q6
            //Console.WriteLine("Enter a number : ");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i < num; i++)
            //{
            //    Console.WriteLine($" numbers = {i}");
            //}
            #endregion

            #region Q7
            //Console.WriteLine("Enter a number : ");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write($"{num * i} ");
            //}
            #endregion

            #region Q8
            Console.WriteLine("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            #endregion

        }
    }
}
