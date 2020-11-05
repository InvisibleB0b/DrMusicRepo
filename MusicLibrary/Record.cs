using System;

namespace MusicLibrary
{
    public class Record
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Playtime { get; set; }
        public int ReleaseYear { get; set; }

        public Record()
        {

        }

        public Record(string title, string artist, int playtime, int releaseYear)
        {
            Title = title;
            Artist = artist;
            Playtime = playtime;
            ReleaseYear = releaseYear;
        }

        public override string ToString()
        {
            return $"{nameof(Title)}: {Title}, {nameof(Artist)}: {Artist}, {nameof(Playtime)}: {Playtime}, {nameof(ReleaseYear)}: {ReleaseYear}";
        }
    }
}
