﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppLanches.Models;

[Table("Categorias")]
public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }

    [Display(Name = "Nome")]
    [Required(ErrorMessage = "Informe o nome da catrgoria")]
    [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
    public string CategoriaNome { get; set; }

    [Display(Name = "Descrição")]
    [Required(ErrorMessage = "Informe a descrição da catrgoria")]
    [StringLength(100, ErrorMessage = "O tamanho máximo é 200 caracteres")]
    public string Descricao { get; set; }
    public List<Lanche> Lanches { get; set;}
}
