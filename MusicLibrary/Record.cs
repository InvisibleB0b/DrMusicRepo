using System;

namespace MusicLibrary
{
    public class Record
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Playtime { get; set; }
        public int ReleaseYear { get; set; }

        public Record()
        {

        }

        public Record(int id, string title, string artist, int playtime, int releaseYear)
        {
            Id = id;
            Title = title;
            Artist = artist;
            Playtime = playtime;
            ReleaseYear = releaseYear;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Title)}: {Title}, {nameof(Artist)}: {Artist}, {nameof(Playtime)}: {Playtime}, {nameof(ReleaseYear)}: {ReleaseYear}";
        }
    }
}
