// Declare a delegate type.
public delegate void NotifyEventHandler();

class Publisher
{
    // Declare an event based on the delegate.
    public event NotifyEventHandler OnNotify;
    // Method to raise the event.
    public void RaiseEvent()
    {
        if (OnNotify != null)  // Check if there are subscribers.
        {
            Console.WriteLine("Raising event...");
            OnNotify();  // Invoke the delegate, notifying subscribers.
        }
    }
}

class Subscriber
{
    public void HandleNotification()
    {
        Console.WriteLine("Subscriber received the notification.");
    }
}

class Program
{
    //static void Main()
    //{
    //    Publisher publisher = new Publisher();
    //    Subscriber subscriber = new Subscriber();

    //    // Subscribe to the event using +=
    //    publisher.OnNotify += subscriber.HandleNotification;

    //    // Trigger the event, notifying all subscribers
    //    publisher.RaiseEvent();

    //    // Unsubscribe from the event using -=
    //    publisher.OnNotify -= subscriber.HandleNotification;
    //}
}
