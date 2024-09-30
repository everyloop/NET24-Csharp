
class Subscriber
{
    private string name;

    public Subscriber(string name)
    {
        this.name = name;
    }

    public void OnMessageRecieved(object sender, MessageEventArgs args)
    {
        Console.WriteLine($"{name} got the message: {args.Message}");
    }
}