using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class GuestbookEntry
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DatePosted { get; set; }

        public string Message { get; set; }
    }
}
