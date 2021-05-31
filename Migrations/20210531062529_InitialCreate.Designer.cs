﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using controleFinanceiro.Models;

namespace controleFinanceiro.Migrations
{
    [DbContext(typeof(ControleFinanceiroContext))]
    [Migration("20210531062529_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("controleFinanceiro.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("controleFinanceiro.Models.Financa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFinanca")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ModalidadeId")
                        .HasColumnType("int");

                    b.Property<int?>("TipoId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<float>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("ModalidadeId");

                    b.HasIndex("TipoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Financa");
                });

            modelBuilder.Entity("controleFinanceiro.Models.Modalidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Modalidade");
                });

            modelBuilder.Entity("controleFinanceiro.Models.Tipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Tipo");
                });

            modelBuilder.Entity("controleFinanceiro.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("controleFinanceiro.Models.Financa", b =>
                {
                    b.HasOne("controleFinanceiro.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");

                    b.HasOne("controleFinanceiro.Models.Modalidade", "Modalidade")
                        .WithMany()
                        .HasForeignKey("ModalidadeId");

                    b.HasOne("controleFinanceiro.Models.Tipo", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoId");

                    b.HasOne("controleFinanceiro.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Categoria");

                    b.Navigation("Modalidade");

                    b.Navigation("Tipo");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
