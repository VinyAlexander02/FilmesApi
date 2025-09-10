namespace FilmesApi.Data.Dtos;

public class ReadFilmDto
{
    public string? Title { get; set; }

    public string? Gender { get; set; }

    public int DurationTime { get; set; }
    
    public DateTime dateTime{ get; set; } = DateTime.Now;
}