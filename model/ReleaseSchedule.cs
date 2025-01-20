namespace RYHME.model
{
    public class ReleaseSchedule
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public int SongId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Status { get; set; }
    }
}
