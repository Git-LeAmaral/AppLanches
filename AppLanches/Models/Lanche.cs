﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppLanches.Models;

[Table("Lanches")]
public class Lanche
{
    [Key]
    public int LancheId { get; set; }

    [Display(Name = "Nome do Lanche")]
    [Required(ErrorMessage = "O nome do lanche deve ser informado")]
    [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máxiomo {2}")]
    public string Nome { get; set; }

    [Display(Name = "Descrição do Lanche")]
    [Required(ErrorMessage = "A descrição do lanche deve ser informado")]
    [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
    [MaxLength(200, ErrorMessage = "Descrição não deve exceder {1} caracteres")]
    public string DescricaoCurta { get; set; }

    [Display(Name = "Descrição do Lanche")]
    [Required(ErrorMessage = "A descrição do lanche deve ser informado")]
    [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
    [MaxLength(200, ErrorMessage = "Descrição não deve exceder {1} caracteres")]
    public string DescricaoDetalhada { get; set; }

    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(10,2)")]
    [Required(ErrorMessage = "Informe o preço do lanche")]
    [Range(1,999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
    public decimal Preco { get; set; }

    [Display(Name = "Caminho Imagem Normal")]
    [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
    public string ImagemUrl { get; set; }

    [Display(Name = "Caminho Imagem Miniatura")]
    [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
    public string ImagemThumbnailUrl { get; set; }

    [Display(Name = "Preferido?")]
    public bool IsLanchePreferido { get; set; }

    [Display(Name = "Estoque")]
    public bool EmEstoque { get; set; }
    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; }
}
