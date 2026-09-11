public delegate void LogHandler(string message);

class Logger
{
    // Multicast delegate example
    public static void LogToConsole(string message)
    {
        Console.WriteLine($"Console: {message}");
    }

    public static void LogToFile(string message)
    {
        // Simulate logging to a file
        Console.WriteLine($"File: {message}");
    }
    
    static void Main()
    {
        // Multicast delegate pointing to two methods
        LogHandler log = LogToConsole;
        log += LogToFile;
        // Invoke the delegate (both methods are called)
        log("Multicast delegate example.");
    }
}