using System;

class Alarm
{
    // Declare the event
    public event Action AlarmRang;

    // Method that triggers the event
    public void Ring()
    {
        Console.WriteLine("Alarm is ringing!");
        AlarmRang?.Invoke();  // Raise the event
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Alarm
        Alarm alarm = new Alarm();

        // Subscribe to the event with an event handler (lambda)
        alarm.AlarmRang += () => Console.WriteLine("Wake up!");

        // Call the Ring method
        alarm.Ring();

        Console.ReadLine();
    }
}
