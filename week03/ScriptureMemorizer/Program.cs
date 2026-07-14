// Creativity:
// This program was improved by ensuring that
// only words that are not already hidden are
// selected when hiding random words. This
// prevents repeatedly selecting words that
// have already been hidden.

Reference reference =
    new Reference("Proverbs", 3, 5, 6);

Scripture scripture =
    new Scripture(
        reference,
        "Trust in the Lord with all thine heart and lean not unto thine own understanding");

string input = "";

while (input != "quit" &&
       !scripture.IsCompletelyHidden())
{
    Console.Clear();

    Console.WriteLine(scripture.GetDisplayText());

    Console.WriteLine();
    Console.Write("Press Enter to continue or type quit: ");

    input = Console.ReadLine();

    if (input != "quit")
    {
        scripture.HideRandomWords(3);
    }
}

Console.Clear();
Console.WriteLine(scripture.GetDisplayText());
Console.WriteLine();
Console.WriteLine("Program ended.");
