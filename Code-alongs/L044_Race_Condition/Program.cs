using System.Diagnostics.Metrics;

for (int i = 0; i < 20; i++)
{
    Count();
}

static void Count()
{
    object myLock = new object();

    int counter = 0;

    Task task1 = Task.Run(() => DoCount());
    Task task2 = Task.Run(() => DoCount());

    Task.WaitAll(task1, task2);

    Console.WriteLine($"count = {counter}");
    
    void DoCount()
    {
        for (int i = 0; i < 10000; i++)
        {
            lock (myLock)
            {
                //    int temp = counter;
                //    temp = temp + 1;
                //    counter = temp;
                counter++;
            }
        }
    }
}


