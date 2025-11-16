namespace ProjectAPI.Models
{
    public class QRCodes
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string QRImage { get; set; } = string.Empty;
    }
}
