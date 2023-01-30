using System.Text.RegularExpressions;
using System.Linq;
                namespace HelloWorld
{    
public class Program
{
    public static void Main(string[] args)
    {
        var watch = new System.Diagnostics.Stopwatch();
        string chars= "^|<>%&#$-+/*'!?{}=^~:;%()[]";
        var caracters = chars.AsEnumerable();
        string mail = "patrickSon_@oubluk.com";
        bool containsSpecialCharacters = false;

        foreach (char item in chars.AsEnumerable())
        {
            containsSpecialCharacters = mail.Contains(item);
            if(containsSpecialCharacters){
              break;
            }
        }

        bool valid = Regex.IsMatch(mail,"^\\S+@\\S+\\.\\S+$",RegexOptions.IgnoreCase,TimeSpan.FromMilliseconds(250)) && !containsSpecialCharacters && mail.Length <= 50;
        Console.WriteLine("Is valid mail "+valid);
        watch.Stop();
        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
    }
}
}