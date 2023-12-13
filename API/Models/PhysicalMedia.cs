using System.ComponentModel.DataAnnotations;

namespace CineVerse.API.Models;

public abstract class PhysicalMedia
{
    public int PhysicalMediaId { get; set; }

    [Display(Name = "Título")]
    [StringLength(45, ErrorMessage = "Máximo de 45 caracteres")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
    public string Title { get; set; }

    public string TitleSlug => Title.ToLower().Replace(" ", "-");

    [Display(Name = "Título original")]
    [StringLength(45, ErrorMessage = "Máximo de 45 caracteres")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
    public string OriginalTitle { get; set; }

    [Display(Name = "Sinopse")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
    public string Synopsis { get; set; }

    [Display(Name = "Endereço da imagem")]
    [StringLength(50, ErrorMessage = "Máximo de 50 caracteres")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
    public string PosterPath { get; set; }

    [Display(Name = "Tempo")]
    [StringLength(10, ErrorMessage = "Máximo de 10 caracteres")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
    public string Runtime { get; set; }

    [Display(Name = "Estreia")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
    [DataType("month")]
    [DisplayFormat(DataFormatString = "{0:MMMM \\de yyyy}")]
    public DateTime Premiere { get; set; }

    [Display(Name = "Classificação")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
    public string Classification { get; set; }

    [Display(Name = "Gênero")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
    public string Genre { get; set; }

    [Display(Name = "Preço")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório")]
    [DataType(DataType.Currency)]
    public double Price { get; set; }
}
