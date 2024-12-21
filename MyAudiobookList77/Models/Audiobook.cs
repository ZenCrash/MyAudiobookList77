using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAudiobookList.DataAccess.Models
{
  public class AudioBook
  {
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Subtitle { get; set; }
    public string Author { get; set; }
    public string NarratedBy { get; set; }
    public string? Series { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Language { get; set; }
    public string? Ratings { get; set; }
    public string? Stars { get; set; }
    public string? CoverUrl { get; set; }
    public string? BookNumber { get; set; }
  }
}
