using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Table("tb_usuario")]
public partial class TbUsuario
{
    [Key]
    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Column("nome_completo")]
    [StringLength(255)]
    public string NomeCompleto { get; set; } = null!;

    [Column("nome_usuario")]
    [StringLength(255)]
    public string NomeUsuario { get; set; } = null!;

    [Column("email")]
    [StringLength(255)]
    public string Email { get; set; } = null!;

    [Column("senha")]
    [StringLength(255)]
    public string Senha { get; set; } = null!;

    [Column("foto_perfil_url")]
    [StringLength(255)]
    public string FotoPerfilUrl { get; set; } = null!;

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<Comentario> Comentario { get; set; } = new List<Comentario>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<Curtida> Curtida { get; set; } = new List<Curtida>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbPublicacao> TbPublicacao { get; set; } = new List<TbPublicacao>();

    [ForeignKey("UsuarioSeguidorId")]
    [InverseProperty("UsuarioSeguidor")]
    public virtual ICollection<TbUsuario> UsuarioSeguido { get; set; } = new List<TbUsuario>();

    [ForeignKey("UsuarioSeguidoId")]
    [InverseProperty("UsuarioSeguido")]
    public virtual ICollection<TbUsuario> UsuarioSeguidor { get; set; } = new List<TbUsuario>();
}
