﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace forumDB.Model
{
    public partial class ForumContext : DbContext
    {
        public ForumContext()
        {
        }

        public ForumContext(DbContextOptions<ForumContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Denuncia> Denuncia { get; set; }
        public virtual DbSet<Nota> Nota { get; set; }
        public virtual DbSet<Pergunta> Pergunta { get; set; }
        public virtual DbSet<Resposta> Resposta { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=bancodedadosbom.cqsiq7xdliei.us-east-1.rds.amazonaws.com;Initial Catalog=Forum;User ID=admin;Password=e5sXQsfI20LktnQyVEO3");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>(entity =>
            {
                entity.Property(e => e.Nome).IsFixedLength();
            });

            modelBuilder.Entity<Denuncia>(entity =>
            {
                entity.HasOne(d => d.IdPerguntaNavigation)
                    .WithMany(p => p.Denuncia)
                    .HasForeignKey(d => d.IdPergunta)
                    .HasConstraintName("FK__Denuncia__id_per__4316F928");

                entity.HasOne(d => d.IdRespostaNavigation)
                    .WithMany(p => p.Denuncia)
                    .HasForeignKey(d => d.IdResposta)
                    .HasConstraintName("FK__Denuncia__id_res__440B1D61");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Denuncia)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Denuncia__id_usu__44FF419A");
            });

            modelBuilder.Entity<Nota>(entity =>
            {
                entity.HasOne(d => d.IdPerguntaNavigation)
                    .WithMany(p => p.Nota)
                    .HasForeignKey(d => d.IdPergunta)
                    .HasConstraintName("FK__Nota__id_pergunt__47DBAE45");

                entity.HasOne(d => d.IdRespostaNavigation)
                    .WithMany(p => p.Nota)
                    .HasForeignKey(d => d.IdResposta)
                    .HasConstraintName("FK__Nota__id_respost__48CFD27E");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Nota)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Nota__id_usuario__49C3F6B7");
            });

            modelBuilder.Entity<Pergunta>(entity =>
            {
                entity.HasOne(d => d.IdCursoNavigation)
                    .WithMany(p => p.Pergunta)
                    .HasForeignKey(d => d.IdCurso)
                    .HasConstraintName("FK__Pergunta__id_cur__3C69FB99");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Pergunta)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Pergunta__id_usu__3B75D760");
            });

            modelBuilder.Entity<Resposta>(entity =>
            {
                entity.HasOne(d => d.IdPerguntaNavigation)
                    .WithMany(p => p.Resposta)
                    .HasForeignKey(d => d.IdPergunta)
                    .HasConstraintName("FK__Resposta__id_per__3F466844");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Resposta)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Resposta__id_usu__403A8C7D");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Nome).IsFixedLength();

                entity.HasOne(d => d.IdCursoNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdCurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuario__id_curs__38996AB5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}