using System.ComponentModel.DataAnnotations;

namespace BlazingShop.Models;

public class Product
{
    [Key]
    [Required(ErrorMessage = "O campo 'Id' é obrigatório")]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo 'Título' é obrigatório")]
    [MaxLength(150, ErrorMessage = "O campo 'Título' deve ter no máximo 150 caracteres")]
    [MinLength(5, ErrorMessage = "O campo 'Título' deve ter no mínimo 5 caracteres")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "O campo 'Preço' é obrigatório")]
    [DataType(DataType.Currency)]
    [Range(1, 9999, ErrorMessage = "O campo 'Preço' deve estar entre 1 e 9999")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "O 'Id' da Categoria é obrigatório")]
    [Range(1, 9999, ErrorMessage = "O 'Id' da Categoria deve estar entre 1 e 9999")]
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}
