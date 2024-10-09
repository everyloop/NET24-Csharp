object lockA = new object();
object lockB = new object();

int counter = 0;

var task1 = Task.Run(() => {
	for (int i = 0; i < 1000; i++)
	{
        Thread.Sleep(100);
        lock (lockA)
        {
            lock (lockB)
            {
		        counter++;
                Console.WriteLine(counter);
            }
        }
	}
});

var task2 = Task.Run(() => {
    for (int i = 0; i < 1000; i++)
    {
        Thread.Sleep(250);
        lock (lockB)
        {
            lock (lockA)
            {
                counter++;
                Console.WriteLine(counter);
            }
        }
    }
});

Task.WaitAll(task1, task2);

Console.WriteLine(counter);
