public class Program
{
    public static void Main(string[] args)
    {
        Menu test=new Menu();
        Console.WriteLine(test);
        test.Answer();
        Console.WriteLine(test.is_valid_input());
    }
}