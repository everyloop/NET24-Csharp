
internal class Program
{
    private static void Main(string[] args)
    {
        Task<long> task1 = new Task<long>(() =>
        {
            long sum = 0;

            for (int i = 1; i <= 500; i++)
            {
                sum += i;
            }

            return sum;
        });

        Console.WriteLine($"task1 is {task1.Status}");

        Task myContinuationTask = task1.ContinueWith(task =>
        {
            Console.WriteLine($"Result of task1: {task.Result}");
        });

        task1.Start();

        Console.WriteLine($"task1 is {task1.Status}");

        //Task1();

        for (int i = 0; i < 1000; i++)
        {
            Console.WriteLine($"Main thread: {i}");
        }

        Console.WriteLine("Main thread continues ...");

        //Task.WaitAll(task1);


        Console.WriteLine($"task1 is {task1.Status}");

        Console.WriteLine("The end!");

        Console.ReadKey(true);

        //static void Task1()
        //{
        //    for (int i = 0; i < 2000; i++)
        //    {
        //        Console.WriteLine($"Task1: {i}");
        //    }
        //}
    }
}