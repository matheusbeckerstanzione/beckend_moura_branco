using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrudM.Models;

[Table("Aluno")]
public partial class Aluno
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string Nome { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string SobreNome { get; set; } = null!;

    public int Idade { get; set; }

    [Column("cpf")]
    [StringLength(14)]
    [Unicode(false)]
    public string Cpf { get; set; } = null!;
}
