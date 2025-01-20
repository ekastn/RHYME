namespace RYHME.model
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string CoverImage { get; set; }
    }
}
