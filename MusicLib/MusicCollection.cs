namespace MusicLib;

/// <summary>
/// This class holds a collection of Music.
/// Also provides functionality on printing all the music, sorting by release year and appending new music to the collection.
/// </summary>
public class MusicCollection
{
    /// <summary>
    /// stores the test data
    /// </summary>
    private List<Music>? testData;
    
    /// <summary>
    /// The actual music data in the collection
    /// </summary>
    public List<Music> MusicData { get; set; }

    //for inserting specific list into the collection
    public MusicCollection(List<Music> musicData)
    {
        MusicData = musicData;
    }

    //default constructor
    public MusicCollection()
    {
        MusicData = new List<Music>();
    }

    /// <summary>
    /// Prints out all the music information in a formatted fashion
    /// </summary>
    public void PrintFormatted()
    {
        string formattedTitle = string.Format("{0,30} {1,30} {2,30} {3,30} {4,30}\n\n", "Title", "Artist", "Album", "RelYear", "Language");
        Console.WriteLine(formattedTitle);
        foreach (var music in MusicData)
        {
            music.Print();
        }
    }
    
    /// <summary>
    /// Appends a new music entry into the collection
    /// </summary>
    /// <param name="music"></param>
    public void Append(Music music)
    {
        MusicData.Add(music);
    }

    /// <summary>
    /// Sorts the music data by the release year. In ascending order
    /// </summary>
    public void SortByReleaseYear()
    {
        MusicData.Sort((m1, m2) => m1.RelYear.CompareTo(m2.RelYear));
    }

    /// <summary>
    /// Generates test music data.
    /// </summary>
    public void GenerateTestData()
    {
       testData = new List<Music>()
        {
            new Music("Bohemian Rhapsody", "Queen", "A Night at the Opera", 1975, "English"),
            new Music("Imagine", "John Lennon", "Imagine", 1971, "English"),
            new Music("Hotel California", "Eagles", "Hotel California", 1976, "English"),
            new Music("Stairway to Heaven", "Led Zeppelin", "Led Zeppelin IV", 1971, "English"),
            new Music("Thriller", "Michael Jackson", "Thriller", 1982, "English")
        };
       
       MusicData.AddRange(testData);
    }
}