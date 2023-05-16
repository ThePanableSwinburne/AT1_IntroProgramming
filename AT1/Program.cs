// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using MusicLib;

//Holds the music collection
 MusicCollection songs = new MusicCollection();
Menu();
 
 // The menu
 void Menu()
{
    Console.WriteLine("Welcome to the music application");
    Console.WriteLine("Type 1 to add a record");
    Console.WriteLine("Type 2 to display records");
    Console.WriteLine("Type 3 to load records");
    Console.WriteLine("Type 4 to sort by release year");
    Console.WriteLine("Type 5 to exit");

    var input = Console.ReadLine();
    switch (input)
    {
        case "1":
            AddRecord();
            Menu();
            break;
        case "2":
            Display();
            Menu();
            break;
        case "3":
            LoadRecords();
            Menu();
            break;
        case "4":
            Console.WriteLine("Sorting by release year...");
            songs.SortByReleaseYear();
            Menu();
            break;
        case "5":
            Exit();
            break;
        default:
            Console.WriteLine("input failed... reloading application");
            Menu();
            break;
    }
}
//Adds a record
void AddRecord()
{
    Console.WriteLine("You've chosen to add a record");
    
    Console.WriteLine("Please enter the music title");
    string title = Console.ReadLine();
    
    Console.WriteLine("Please enter the music artist");
    string artist = Console.ReadLine();
    
    Console.WriteLine("Please enter the music album");
    string album = Console.ReadLine();
    
    Console.WriteLine("Please enter the music release year");
    int relYear = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Please enter the music language");
    string language = Console.ReadLine();

    Music music = new Music(title, artist, album, relYear, language);
    songs.Append(music);
    music.Print();
    Console.WriteLine("The song has been successfully added.");
}

 //Displays all the music records
void Display()
{
    songs.PrintFormatted();
}

 //Loads the music test data
void LoadRecords()
{
    Console.WriteLine("loading predefined data");
    songs.GenerateTestData();
}

 //Exits the application
void Exit()
{
    Console.WriteLine("You are now exiting the application.");
}