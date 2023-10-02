using System;
using System.Reflection;

class MyClass
{
    public void Print(string message)
    {
        Console.WriteLine(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();

        
        string methodName;
        if (args.Length > 0)
        {
            methodName = args[0];
        }
        else
        {
            Console.Write("Enter the name of the method to call: ");
            methodName = Console.ReadLine();
        }

        try
        {
            
            MethodInfo method = typeof(MyClass).GetMethod(methodName);
            if (method != null)
            {
                method.Invoke(obj, new object[] { "Hello World" });
            }
            else
            {
                Console.WriteLine("Method not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
