using System;
using System.ComponentModel.DataAnnotations;

namespace Server
{
    public class Database
    {
        public int Id { get; set; }
        [StringLength(int.MaxValue)]
        public string? SourceIPAddress { get; set; }
        [StringLength(int.MaxValue)]
        public string? DestinationIPAddress { get; set; }
        public DateTime? BrazilianTime { get; set; }
        [StringLength(int.MaxValue)]
        public string? Url { get; set; }
        [StringLength(999)]
        public int? StatusCode { get; set; }

        [StringLength(int.MaxValue)]
        public int? RequestBytes { get; set; }


    }
}
