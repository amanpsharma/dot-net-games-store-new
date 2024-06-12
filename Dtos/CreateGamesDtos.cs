using System.ComponentModel.DataAnnotations;

namespace Games.Dtos;

public record class CreateGamesDtos(
    [Required][StringLength(50)] string Name,
    int GenreId,
    [Range(1, 100)] decimal Price,
    DateOnly ReleaseData
);