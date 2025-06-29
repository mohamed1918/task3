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
           Console.WriteLine("Enter a Number : ");
           int num;
           bool isnumber = int.TryParse(Console.ReadLine(), out num);
           if (num > 0)
           {
                Console.WriteLine("Number Is Postive");
           }
           else
           {
                Console.WriteLine("Number Is Negative");
           }
        #endregion
    }
}
}
