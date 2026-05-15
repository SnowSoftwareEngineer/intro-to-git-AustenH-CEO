// This pogram is for the Intro to Github assignment for CS 1415
// Austen Hernandez
// 5/15/26
using GameEnums;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select Game Difficulty: " + GameDifficuly.Easy + " " + GameDifficuly.Medium + " " + GameDifficuly.Hard);
        string Difficulty = Console.ReadLine();

        Console.WriteLine("Select a Character Class: " + CharacterClass.Warrior + " " + CharacterClass.Mage + " " + CharacterClass.Rogue);
        string Class = Console.ReadLine();

        Console.WriteLine("");

        Console.WriteLine("You have selected " + Difficulty + " difficulty and " + Class + " class.");
    }
}