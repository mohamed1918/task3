using System.IO.Pipelines;

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
            //Console.WriteLine("Enter a number : ");
            //int num = int.Parse(Console.ReadLine());
            //for(int i = 1; i <= num; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //}
            #endregion

            #region Q9
            //Console.WriteLine("Enter a  first number : ");
            //Console.WriteLine("Enter a  second number : ");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int re = 1;
            //for (int i = 1; i <= num2; i++)
            //{
            //    re *= num1;
            //}
            //Console.WriteLine($"The result of {num1} raised to the power of {num2} is: {re}");
            #endregion

            #region Q10
            //Console.WriteLine("Enter a five numbers : ");
            //int sum =0;
            //for(int i = 1; i <= 5; i++)
            //{
            //    sum += int.Parse(Console.ReadLine()) ;

            //}
            //int avg = sum / 5;
            //Console.WriteLine($"The total of the five numbers is: {sum}");
            //Console.WriteLine($"The average of the five numbers is: {avg}");
            //Console.WriteLine($"The Percentage of the five numbers is: {avg}");

            #endregion

            #region Q11
            //Console.Write("Enter month number: ");
            //int m = int.Parse(Console.ReadLine());
            //int days;
            //if (m == 2)
            //    days = 28;
            //else if (m == 4 || m == 6 || m == 9 || m == 11)
            //    days = 30;
            //else
            //    days = 31;
            //Console.WriteLine($"Days in Month: {days}");
            #endregion

            #region Q12
            //double num1 = double.Parse(Console.ReadLine());
            //double num2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter an operator (+, -, *, /): ");
            //char op = char.Parse(Console.ReadLine());
            //switch (op) 
            //{ 
            //    case '+':
            //        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            //        break;
            //    case '*':
            //        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            //        break;
            //    case '/':
            //        if (num2 != 0)
            //            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            //        else
            //            Console.WriteLine("Cannot divide by zero.");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator.");
            //        break;
            //}
            #endregion

            #region Q13
            //Console.WriteLine("Enter a string : ");
            //string str = Console.ReadLine();
            //char[] arr = str.ToCharArray();
            //Array.Reverse(arr);
            //Console.WriteLine("Reversed string: " + new string(arr));
            #endregion

            #region Q14
            //Console.WriteLine("Enter a number : ");
            //int num = int.Parse(Console.ReadLine());
            //int reverse = 0;
            //while (num > 0)
            //{
            //    int digit = num % 10;
            //    reverse = reverse * 10 + digit;
            //    num /= 10;
            //}
            //Console.WriteLine("Reversed number: " + reverse);
            #endregion

            #region Q15
            //Console.WriteLine("Test Data : ");
            //Console.WriteLine("Input a satating number : ");
            //int start = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input a ending number : ");
            //int end = int.Parse(Console.ReadLine());
            //for (int i = start; i <= end; i++)
            //{
            //    bool prime = i > 1;
            //    for (int j = 2; j * j <= i; j++)
            //        if (i % j == 0)
            //        {
            //            prime = false;
            //            break;
            //        }
            //    if (prime) Console.Write($"{i} ");
            //}
            #endregion

            #region Q16
            //Console.WriteLine("Enter a number : ");
            //int num = int.Parse(Console.ReadLine());
            //int binary ;
            //while (num > 0)
            //{
            //    binary = num % 2;
            //    Console.Write(binary);
            //    num /= 2;
            //}
            #endregion

            #region Q17
            //double x1 = double.Parse(Console.ReadLine());
            //double y1 = double.Parse(Console.ReadLine());
            //double x2 = double.Parse(Console.ReadLine());
            //double y2 = double.Parse(Console.ReadLine());
            //double x3 = double.Parse(Console.ReadLine());
            //double y3 = double.Parse(Console.ReadLine());

            //double slope1 = (y2 - y1) / (x2 - x1);
            //double slope2 = (y3 - y2) / (x3 - x2);
            //if (slope1 == slope2)
            //{
            //    Console.WriteLine("Points are on the same line");
            //}
            //else 
            //{ 
            //    Console.WriteLine("Points are not on the same line");
            //}
            #endregion

            #region Q18
            ////double.TryParse(Console.ReadLine(), out double t);
            ////Console.WriteLine(t < 3 ? "Highly efficient" : t < 4 ? "Increase speed" : t < 5 ? "Training required" : "Leave company");

            //double hours = double.Parse(Console.ReadLine());

            //if (hours >= 2 && hours < 3)
            //    Console.WriteLine("Highly efficient");
            //else if (hours >= 3 && hours < 4)
            //    Console.WriteLine("Increase speed");
            //else if (hours >= 4 && hours < 5)
            //    Console.WriteLine("Training required");
            //else if (hours >= 5)
            //    Console.WriteLine("Leave the company");

            #endregion

            #region Q19
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 0; i < num; i++) 
            //{
            //    for (int j = 0; j < num; j++)
            //    {

            //          if (i == j)
            //               Console.Write("1 ");
            //          else
            //               Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q20
            //int[] arr = [1, 2, 3, 4, 5];
            //Console.WriteLine($"the sum of the array is = {arr.Sum()} "  );
            #endregion

            #region Q21
            int[] arr1 = { 1, 3, 5, 7, 9 };
            int[] arr2 = { 2, 4, 6, 8, 10 };

            int[] merged = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
                merged[i] = arr1[i];

            for (int i = 0; i < arr2.Length; i++)
                merged[i + arr1.Length] = arr2[i];

            Array.Sort(merged);

            Console.WriteLine("Merged Sorted Array:");
            for (int i = 0; i < merged.Length; i++)
                Console.Write(merged[i] + " ");

            #endregion
        }

    }
    
}
