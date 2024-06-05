public class Program
{
    public static void Main(string[] args)
    {
        Menu test=new Menu();
        Console.WriteLine(test);
        test.Answer("3");
        Console.WriteLine(test.is_valid_input());
        Console.WriteLine(test);

        Menu yes_no_template_test=Menu.YesNoQuestion("test_message");
        Console.Write(yes_no_template_test);
        yes_no_template_test.Answer();
        Console.WriteLine(yes_no_template_test.is_valid_input());
    }
}