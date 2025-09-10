namespace FilmesApi.Data.Dtos;
using System.ComponentModel.DataAnnotations;

public class CreateFilmDto
{
    [Required(ErrorMessage = "O título do filme é obrigátório!")]
    public string? Title { get; set; }
    
    [Required(ErrorMessage = "O Gênreo do filme é obrigátório!")]
    [StringLength(50, ErrorMessage = "O Gênero do filme não pode exeder 50 caracteres")]
    public string? Gender { get; set; }

    [Required]
    [Range(70, 600, ErrorMessage = "A duração do filme deve ser entre 70 e 600 minutos")]
    public int DurationTime { get; set; }
}