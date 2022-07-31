using System.Diagnostics;

public class Demo
{
    public Demo()
    {
        var listener = new ConsoleTraceListener();
        //Added to see logs in the console (not only in the debug console)
        Trace.Listeners.Add(listener);
    }

    public int Sum(int num1, int num2)
    {
        Debug.WriteLine($"The number 1 is {num1}");

        Debug.Assert(num2 > num1, $"Number 2 should be greather tan num1, value:{num2}");
        return num1 + num2;
    }

}