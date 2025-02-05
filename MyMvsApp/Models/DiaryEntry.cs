using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyMvsApp.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }
        [Required] // this entry is required and cannot be null
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; } = string.Empty;
        [Required]
        public DateTime Created { get; set; } = DateTime.Now;
    }
}