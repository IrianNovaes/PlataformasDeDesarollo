﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParcialPDD;

namespace ParcialPDD.Migrations
{
    [DbContext(typeof(TareasDbContext))]
    [Migration("20201010051844_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("ParcialPDD.Detalles", b =>
                {
                    b.Property<int>("DetallePK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int?>("RecursoPK")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TareaPK")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tiempo")
                        .HasColumnType("INTEGER");

                    b.HasKey("DetallePK");

                    b.HasIndex("RecursoPK");

                    b.HasIndex("TareaPK");

                    b.ToTable("Detalles");
                });

            modelBuilder.Entity("ParcialPDD.Recursos", b =>
                {
                    b.Property<int>("RecursoPK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int?>("UsuarioPK")
                        .HasColumnType("INTEGER");

                    b.HasKey("RecursoPK");

                    b.HasIndex("UsuarioPK");

                    b.ToTable("Recursos");
                });

            modelBuilder.Entity("ParcialPDD.Tareas", b =>
                {
                    b.Property<int>("TareaPK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Estado")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Estimacion")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ResponsableRecursoPK")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<DateTime>("Vencimiento")
                        .HasColumnType("TEXT");

                    b.HasKey("TareaPK");

                    b.HasIndex("ResponsableRecursoPK");

                    b.ToTable("Tareas");
                });

            modelBuilder.Entity("ParcialPDD.Usuarios", b =>
                {
                    b.Property<int>("UsuarioPK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("char(20)");

                    b.Property<string>("Usuario")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.HasKey("UsuarioPK");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ParcialPDD.Detalles", b =>
                {
                    b.HasOne("ParcialPDD.Recursos", "Recurso")
                        .WithMany()
                        .HasForeignKey("RecursoPK");

                    b.HasOne("ParcialPDD.Tareas", "Tarea")
                        .WithMany()
                        .HasForeignKey("TareaPK");
                });

            modelBuilder.Entity("ParcialPDD.Recursos", b =>
                {
                    b.HasOne("ParcialPDD.Usuarios", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioPK");
                });

            modelBuilder.Entity("ParcialPDD.Tareas", b =>
                {
                    b.HasOne("ParcialPDD.Recursos", "Responsable")
                        .WithMany()
                        .HasForeignKey("ResponsableRecursoPK");
                });
#pragma warning restore 612, 618
        }
    }
}
