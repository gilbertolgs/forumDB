﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace forumDB.Model
{
    public partial class Pergunta
    {
        public Pergunta()
        {
            Denuncia = new HashSet<Denuncia>();
            Nota = new HashSet<Nota>();
            Resposta = new HashSet<Resposta>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("id_usuario")]
        public int? IdUsuario { get; set; }
        [Column("id_curso")]
        public int? IdCurso { get; set; }
        [Required]
        [Column("texto")]
        [StringLength(350)]
        [Unicode(false)]
        public string Texto { get; set; }
        [Required]
        [Column("titulo")]
        [StringLength(40)]
        [Unicode(false)]
        public string Titulo { get; set; }
        [Column("respondida")]
        public bool? Respondida { get; set; }
        [Column("horario", TypeName = "datetime")]
        public DateTime? Horario { get; set; }

        [ForeignKey("IdCurso")]
        [InverseProperty("Pergunta")]
        public virtual Curso IdCursoNavigation { get; set; }
        [ForeignKey("IdUsuario")]
        [InverseProperty("Pergunta")]
        public virtual Usuario IdUsuarioNavigation { get; set; }
        [InverseProperty("IdPerguntaNavigation")]
        public virtual ICollection<Denuncia> Denuncia { get; set; }
        [InverseProperty("IdPerguntaNavigation")]
        public virtual ICollection<Nota> Nota { get; set; }
        [InverseProperty("IdPerguntaNavigation")]
        public virtual ICollection<Resposta> Resposta { get; set; }
    }
}