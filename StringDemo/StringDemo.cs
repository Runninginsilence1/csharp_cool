namespace csharp_cool.StringDemo;

public class StringDemo
{
    /// <summary>
    /// string.Split不介绍了
    /// </summary>
    public static void Split()
    {
        string str1 = "Hello World";
        var strings = str1.Split(" ");
        foreach (var s in strings)
        {
            Console.Write(s);
            Console.Write(" ");
        }
    }
}