class MessageEventArgs : EventArgs
{
    public MessageEventArgs(string message)
    {
        Message = message;
    }

    public string Message { get; set; }
}

class Publisher
{
    //public delegate void MessageEvent(object sender, MessageEventArgs args);

    public event EventHandler<MessageEventArgs> Message;

    public void SendMessage(string message)
    {
        Message.Invoke(this, new MessageEventArgs(message));
    }
}
