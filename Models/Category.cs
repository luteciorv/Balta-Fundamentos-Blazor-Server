﻿using System.ComponentModel.DataAnnotations;

namespace BlazingShop.Models;

public class Category
{
    [Key]
    [Required(ErrorMessage = "O campo 'Id' é obrigatório")]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo 'Título' é obrigatório")]
    [MaxLength(50, ErrorMessage = "O campo 'Título' deve ter no máximo 50 caracteres")]
    [MinLength(5, ErrorMessage = "O campo 'Título' deve ter no mínimo 5 caracteres")]
    public string Title { get; set; } = string.Empty;

    public List<Product> Products { get; set; } = new();
}
