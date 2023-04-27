﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    [Required(ErrorMessage = "O titulo do file é obrigatório")]
    public string? Titulo { get; set; }
    [Required(ErrorMessage = "O gênero do file é obrigatório")]
    [MaxLength(50, ErrorMessage = " O tamanho do Gênero não pode exceder 50 caracteres")]
    public string? Genero { get; set; }
    [Required]
    [Range(70, 700, ErrorMessage = "A duração do filme deve ser entre 70 e 600 minutos")]

    public int Duracao { get; set; }
}
