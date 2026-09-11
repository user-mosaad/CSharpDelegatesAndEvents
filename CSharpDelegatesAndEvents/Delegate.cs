// Declare a delegate type that can point to methods with no parameters and no return type
public delegate void Notify();

class Delegate()
{
    // A method that matches the delegate signature
    public static void SendMessage()
    {
        Console.WriteLine("Message sent!");
    }

    //static void Main()
    //{
    //    // Create an instance of the delegate pointing to SendMessage
    //    Notify notifyDelegate = SendMessage;
    //    // Invoke the delegate
    //    notifyDelegate();
    //}
}
