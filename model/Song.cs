namespace RYHME.model
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AlbumId { get; set; }
        public TimeSpan Duration { get; set; }
        public string Lyrics { get; set; }
    }
}
