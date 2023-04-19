using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        string fileDirection = new string("text.txt");

        Console.Write("введіть дані для дозапису у файл:\n=> ");
        string requestInputText = new string(Console.ReadLine());

        using (FileStream fs = new FileStream(fileDirection, FileMode.Append))
        {
            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            {
                sw.WriteLine(requestInputText);
                Console.WriteLine("\nдані записано!");
            }
        }

    }
}