
Publisher publisher = new Publisher();

Subscriber subscriber1 = new Subscriber("Kalle");
Subscriber subscriber2 = new Subscriber("Pelle");
Subscriber subscriber3 = new Subscriber("Eva");

publisher.Message += subscriber1.OnMessageRecieved;
publisher.Message += subscriber2.OnMessageRecieved;
publisher.Message += subscriber3.OnMessageRecieved;

publisher.SendMessage("Hello everyone!");

Console.WriteLine();
//publisher.Message = subscriber2.OnMessageRecieved;

publisher.SendMessage("Bye!");
