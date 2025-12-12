using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Table("tb_publicacao")]
public partial class TbPublicacao
{
    [Key]
    [Column("id_publicacao")]
    public int IdPublicacao { get; set; }

    [Column("descricao")]
    [StringLength(255)]
    public string Descricao { get; set; } = null!;

    [Column("imagem_url")]
    [StringLength(255)]
    public string ImagemUrl { get; set; } = null!;

    [Column("data_puclicacao")]
    public DateOnly DataPuclicacao { get; set; }

    [Column("id_usuario")]
    public int? IdUsuario { get; set; }

    [InverseProperty("IdPublicacaoNavigation")]
    public virtual ICollection<Comentario> Comentario { get; set; } = new List<Comentario>();

    [InverseProperty("IdPublicacaoNavigation")]
    public virtual ICollection<Curtida> Curtida { get; set; } = new List<Curtida>();

    [ForeignKey("IdUsuario")]
    [InverseProperty("TbPublicacao")]
    public virtual TbUsuario? IdUsuarioNavigation { get; set; }
}
