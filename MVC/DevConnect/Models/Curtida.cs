using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Table("curtida")]
public partial class Curtida
{
    [Key]
    [Column("id_curtida")]
    public int IdCurtida { get; set; }

    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Column("id_publicacao")]
    public int IdPublicacao { get; set; }

    [ForeignKey("IdPublicacao")]
    [InverseProperty("Curtida")]
    public virtual TbPublicacao IdPublicacaoNavigation { get; set; } = null!;

    [ForeignKey("IdUsuario")]
    [InverseProperty("Curtida")]
    public virtual TbUsuario IdUsuarioNavigation { get; set; } = null!;
}
