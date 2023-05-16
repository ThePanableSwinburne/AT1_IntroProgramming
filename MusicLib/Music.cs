namespace MusicLib;
/// <summary>
/// The music class holds the specific information of a track. This includes the Title, Artist, Album, RelYear and the language
/// The class also provides a way of printing the data.
/// </summary>
public class Music
{
    /// <summary>
    /// Title of the track
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// The artist in the track
    /// </summary>
    public string Artist { get; set; }
    
    /// <summary>
    /// The album the track pertains to
    /// </summary>
    public string Album { get; set; }
    
    /// <summary>
    /// The release year of the track
    /// </summary>
    public int RelYear { get; set; }
    
    /// <summary>
    /// The language the track is sung in
    /// </summary>
    public string Language { get; set; }

    /// <summary>
    /// Constructor to add attributes
    /// </summary>
    /// <param name="title"></param>
    /// <param name="artist"></param>
    /// <param name="album"></param>
    /// <param name="relYear"></param>
    /// <param name="language"></param>
    public Music(string title, string artist, string album, int relYear, string language)
    {
        Title = title;
        Artist = artist;
        Album = album;
        RelYear = relYear;
        Language = language;
    }

    /// <summary>
    /// Prints the music data and is formatted
    /// </summary>
    public void Print()
    {
        string formattedData = string.Format("{0,30} {1,30} {2,30} {3,30} {4,30}\n\n", Title, Artist, Album, RelYear, Language);
        Console.WriteLine(formattedData);
    }
}