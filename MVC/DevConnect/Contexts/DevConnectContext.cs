using System;
using System.Collections.Generic;
using DevConnect.Models;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Contexts;

public partial class DevConnectContext : DbContext
{
    public DevConnectContext()
    {
    }

    public DevConnectContext(DbContextOptions<DevConnectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comentario> Comentario { get; set; }

    public virtual DbSet<Curtida> Curtida { get; set; }

    public virtual DbSet<TbPublicacao> TbPublicacao { get; set; }

    public virtual DbSet<TbUsuario> TbUsuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DevCon_Windows");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comentario>(entity =>
        {
            entity.HasKey(e => e.IdComentario).HasName("PK__comentar__1BA6C6F451F0A970");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.Comentario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__comentari__id_pu__534D60F1");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Comentario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__comentari__id_us__52593CB8");
        });

        modelBuilder.Entity<Curtida>(entity =>
        {
            entity.HasKey(e => e.IdCurtida).HasName("PK__curtida__0AC033CA129221CE");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.Curtida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__curtida__id_publ__4F7CD00D");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Curtida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__curtida__id_usua__4E88ABD4");
        });

        modelBuilder.Entity<TbPublicacao>(entity =>
        {
            entity.HasKey(e => e.IdPublicacao).HasName("PK__tb_publi__EA81BC3A7F4E5DB2");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbPublicacao).HasConstraintName("FK__tb_public__id_us__4BAC3F29");
        });

        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__tb_usuar__4E3E04AD0D076F39");

            entity.HasMany(d => d.UsuarioSeguido).WithMany(p => p.UsuarioSeguidor)
                .UsingEntity<Dictionary<string, object>>(
                    "Seguidor",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("UsuarioSeguidoId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Seguidor__Usuari__571DF1D5"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("UsuarioSeguidorId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Seguidor__Usuari__5629CD9C"),
                    j =>
                    {
                        j.HasKey("UsuarioSeguidorId", "UsuarioSeguidoId").HasName("PK__Seguidor__475A2EF3E43D40D8");
                    });

            entity.HasMany(d => d.UsuarioSeguidor).WithMany(p => p.UsuarioSeguido)
                .UsingEntity<Dictionary<string, object>>(
                    "Seguidor",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("UsuarioSeguidorId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Seguidor__Usuari__5629CD9C"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("UsuarioSeguidoId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Seguidor__Usuari__571DF1D5"),
                    j =>
                    {
                        j.HasKey("UsuarioSeguidorId", "UsuarioSeguidoId").HasName("PK__Seguidor__475A2EF3E43D40D8");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
