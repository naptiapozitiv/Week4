using ConsoleApp1;

Console.WriteLine("Enter text:");
string input = Console.ReadLine();
var text = new TextHelper(input);
var wordsCounter = text.CountWordWith4orMoreWords(input);
var poli = text.IsPoli(input);
var VowelsandCon = text.CountLetterC_and_V(input);
Console.WriteLine($"words with more than 4 letters: {wordsCounter}");
Console.WriteLine($"Its Palindrom:{poli}");
Console.WriteLine(VowelsandCon);