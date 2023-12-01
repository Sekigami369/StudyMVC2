using System.ComponentModel.DataAnnotations;

namespace StudyMVC2.Models;

public partial class Person
{
    public int Id { get; set; }
    [Required(ErrorMessage = "名前は必須です。")]
    public string Name { get; set; } = null!;

    [Range(0, 200, ErrorMessage = "年齢は０～整数の範囲で入力してください。")]
    public int Age { get; set; }
}
