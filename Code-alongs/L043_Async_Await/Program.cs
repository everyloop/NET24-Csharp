
internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("Start of main");

        //Task<int> task = Download();
        
        var task1 = Download();
        var task2 =  Download2();


        Console.WriteLine("Main continues ...");

        await task1;
        await task2;

        //await Task.WhenAll(task1, task2);

        //Console.WriteLine($"Main prints result: {result}");
        Console.WriteLine("End of main!");
    }

    private static async Task Download()
    {
        HttpClient client = new HttpClient();

        //Task<string> download = client.GetStringAsync("https://www.google.com");
         
        Console.WriteLine("download started ...");

        await Task.Run(() => Thread.Sleep(2000));

        //Console.WriteLine($"Got {data.Length} chars of data.");

        Console.WriteLine("download complete!");

        //return data.Length;
    }

    private static async Task Download2()
    {
        HttpClient client = new HttpClient();

        Task<string> download = client.GetStringAsync("https://www.google.com");

        Console.WriteLine("download2 started ...");

        string data = await download;

        Console.WriteLine($"Got {data.Length} chars of data. (D2)");

        Console.WriteLine("download2 complete!");

        //return data.Length;
    }
}