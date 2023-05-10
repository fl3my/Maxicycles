using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Models;

public class Holiday
{
    public int Id { get; set; }
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime Start { get; set; }
    [DataType(DataType.Date)]

    public DateTime End { get; set; }
}