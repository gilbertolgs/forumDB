﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace forumDB.Model
{
    public partial class Denuncia
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("id_pergunta")]
        public int? IdPergunta { get; set; }
        [Column("id_resposta")]
        public int? IdResposta { get; set; }
        [Column("id_usuario")]
        public int? IdUsuario { get; set; }
        [Column("texto")]
        [StringLength(255)]
        [Unicode(false)]
        public string Texto { get; set; }

        [ForeignKey("IdPergunta")]
        [InverseProperty("Denuncia")]
        public virtual Pergunta IdPerguntaNavigation { get; set; }
        [ForeignKey("IdResposta")]
        [InverseProperty("Denuncia")]
        public virtual Resposta IdRespostaNavigation { get; set; }
        [ForeignKey("IdUsuario")]
        [InverseProperty("Denuncia")]
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}