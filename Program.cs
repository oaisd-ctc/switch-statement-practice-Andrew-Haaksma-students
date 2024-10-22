public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("How was your day today on a scale of 0 - 10");
        int x = int.Parse (Console.ReadLine());
        switch(x)
        {
            case 0:
                Console.WriteLine("Your day was a zero, thats not good so sorry about that");
                break;
            case 1:
                Console.WriteLine("Your day was a one, thats not good so sorry about that");
                break;
            case 2:
                Console.WriteLine("Your day was a two, well that sucks want ice cream");
                break;
            case 3:
                Console.WriteLine("Your day was a three, thats not good do you want to talk about it");
                break;
            case 4:
                Console.WriteLine("Your day was a four, well some days are like that sheer up");
                break;
            case 5:
                Console.WriteLine("Your day was a five, could be better but at least it's over");
                break;
            case 6:
                Console.WriteLine("Your day was a six, what could have made it better");
                break;
            case 7:
                Console.WriteLine("Your day was a sevan, what a good day for you");
                break;
            case 8:
                Console.WriteLine("Your day was a eight, wow what made it so good");
                break;
            case 9:
                Console.WriteLine("Your day was a nine, thats nice lets hope for more days like it");
                break;
            case 10:
                Console.WriteLine("Your day was a ten, that is great");
                break;
            default:
            Console.WriteLine("Please give me a number from 0 - 10");
            break;
        }
    }
}