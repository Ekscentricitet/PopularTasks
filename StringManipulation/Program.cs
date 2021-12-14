using StringManipulation;
using StringManipulation.Exceptions;

while (true)
{
    Console.WriteLine("Please input the string that you want to reverse or 0 if you want to exit the loop");
    var stringToTest = Console.ReadLine();
    if (stringToTest == "0")
        break;
    else
    {
        try
        {
        Console.WriteLine(stringToTest.ReverseSentence());
        }
        catch (NullSentenceToReverseException)
        {
            Console.WriteLine("Is this the real life, is this just null sentence in the console?");
        }
    }
}
Console.WriteLine("Goodbye");