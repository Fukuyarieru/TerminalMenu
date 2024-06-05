/*   Format:
 *   
 *  <Top Border>
 *  <Message>
 *  <Options/Input> : <User Input>
 *  <Nothing/Error Message>
 *  
 *  
 *  Alias list:
 *  
 *  set_...
 *  line_...
 *  top_border_...
 *  default_...
 *  template_...
 *  
 *  important functions will use normal C# syntax
 *  
 */

public class Menu
{
    private int top_border_size;
    private string top_border;
    public string message;
    private string[] options; // options are the expected inputs
    // private string[] expected_inputs;
    private string user_input;

    public Menu(string message, string[]options)
    {
        top_border_size = 30;
        top_border = default_line();
        this.message=message;
        this.options=options;
        user_input="";
    }
    public Menu()
    {
        top_border_size = 30;
        top_border = default_line();
        message = "test_message";
        options = new string[3] { "option1", "option2", "option3" };
        user_input="test_input";
    }
    public void Run()
    {
        Console.WriteLine(ToString());
        Answer();
    }
    // public bool repeat_on_error()...
    public void Answer(string user_input)
    {
        this.user_input = user_input;
    }
    public void Answer()
    {
        this.user_input = Console.ReadLine();
    }
    public void set_top_border(string top_border)
    {
        this.top_border=top_border; // syntax:? Menu.set_top_border(Menu.line_make("=",100));
    }
    public string line_maker(string str, int length)
    {
        string answer="";
        for(int i=0;i<length;i++)
            answer+=str;
        return answer;
    }
    // public bool check_input()
    // {
    //     for(int i=0;i<options.Length;i++)
    //         if(options[i].ToLower().Equals(user_input.ToLower))
    //     return true; // temporary
    // }
    public bool is_valid_input()
    {
        // int size=0;
        // for(int i=1;options.Length/i!=0;i*=10)
        //     size=i;
        // if(user_input.Length<size)
        //     if(user_input.CompareTo("0")>0 && user_input.CompareTo(options.Length)<0)
        //         return true; // if input was a number of an option among the options
        if(user_input.CompareTo("1")>=0 && user_input.CompareTo(options.Length.ToString())<=0)
            return true;
        for(int i=0;i<options.Length;i++)
            if(options[i].ToLower().Equals(user_input.ToLower()))
                return true; 
        Console.WriteLine("ERROR: at Menu.is_valid_input(): invalid input");
        user_input="";
        return false; // temporary
    }
    // public bool is_passing_input()
    public override string ToString()
    {
        string str="";
        str+=top_border+"\n";
        str+=message+"\n";
        for(int i=0;i<options.Length;i++)
            str+=(i+1)+". " + options[i]+"\n";
        str+="input: " + user_input; // +"\n";
        return str;
    }

    private string default_line()
    {
        string str="";
        for(int i=0;i<30;i++)
            str+="=";
        return str;
    }
    // public void template_yes_no_question(string message)
    // {
    //     this.message=message;
    //     options=new string[2]{"yes","no"};
    //     user_input="";
    // }
    // public static Menu YesNoQuestion(string message)
    // {
    //     Menu output=new Menu();
    //     output.template_yes_no_question(message);
    //     return output;
    //     // return new Menu(message)=new Menu().template_yes_no_question(message);
    // }
    public static Menu template_yes_no_question(string message)
    {
        Menu output=new Menu();
        output.message=message;
        output.options=new string[2]{"yes","no"};
        output.user_input="";
        return output;
        // return new Menu(message)=new Menu().template_yes_no_question(message);
    }
    public static Menu template_custom_constructor(string message, int options_amount)
    {
        Menu output=new Menu(message,new string[options_amount]);
        for(int i=0;i<options_amount;i++)
            output.options[i]="";
        return output;
        // return new Menu(message)=new Menu().template_custom_constructor(message,options_amount);
    }
    public string line_maker(string prefix, string inner, string suffix)
    {
        string str="";
        while(str.Length<top_border_size)
            str+=inner;
        return prefix+str+suffix;
    }
    public string line_maker(string edges, string inner)
    {
        return line_maker(edges,inner,edges);
    }
    public void Print()
    {
        Console.Write(this.ToString());
    }
    public void set_top_border_to_default()
    {
        top_border_size = 30;
        top_border = default_line();
    }
}