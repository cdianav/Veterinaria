﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211022114539_adicion_interrogacion")]
    partial class adicion_interrogacion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Veterinaria.App.Dominio.EntidadCitas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EntidadHistoriaClinicoId")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaAtencionCita")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistroCita")
                        .HasColumnType("datetime2");

                    b.Property<string>("Triage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EntidadHistoriaClinicoId");

                    b.ToTable("Cita");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.EntidadHistoriaClinico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Diagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaAtencionCitaH")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistroCitaH")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("HistorialClinico");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.EntidadMascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("EdadMascota")
                        .HasColumnType("int");

                    b.Property<string>("Especie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdCita")
                        .HasColumnType("int");

                    b.Property<int?>("IdHistoriaClinica")
                        .HasColumnType("int");

                    b.Property<int>("IdPropietario")
                        .HasColumnType("int");

                    b.Property<int?>("IdVeterinario")
                        .HasColumnType("int");

                    b.Property<string>("NombreMascota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("peso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("raza")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdCita");

                    b.HasIndex("IdHistoriaClinica");

                    b.HasIndex("IdPropietario");

                    b.HasIndex("IdVeterinario");

                    b.ToTable("Mascota");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.EntidadPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Edad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("EntidadPersona");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.EntidadVacuna", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaRegistroVacuna")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreVacunaComplementaria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreVacunaObligatoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idMascota")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("idMascota");

                    b.ToTable("Vacuna");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.EntidadCliente", b =>
                {
                    b.HasBaseType("Veterinaria.App.Dominio.EntidadPersona");

                    b.HasDiscriminator().HasValue("EntidadCliente");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.EntidadVeterinario", b =>
                {
                    b.HasBaseType("Veterinaria.App.Dominio.EntidadPersona");

                    b.Property<string>("Especializacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TarjetaProfesional")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("EntidadVeterinario");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.EntidadCitas", b =>
                {
                    b.HasOne("Veterinaria.App.Dominio.EntidadHistoriaClinico", null)
                        .WithMany("listaCitas")
                        .HasForeignKey("EntidadHistoriaClinicoId");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.EntidadMascota", b =>
                {
                    b.HasOne("Veterinaria.App.Dominio.EntidadCitas", "Cita")
                        .WithMany()
                        .HasForeignKey("IdCita");

                    b.HasOne("Veterinaria.App.Dominio.EntidadHistoriaClinico", "HistoriaClinica")
                        .WithMany()
                        .HasForeignKey("IdHistoriaClinica");

                    b.HasOne("Veterinaria.App.Dominio.EntidadCliente", "Propietario")
                        .WithMany("listaMisMascotas")
                        .HasForeignKey("IdPropietario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Veterinaria.App.Dominio.EntidadVeterinario", "Veterinario")
                        .WithMany("listaMascotas")
                        .HasForeignKey("IdVeterinario")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Cita");

                    b.Navigation("HistoriaClinica");

                    b.Navigation("Propietario");

                    b.Navigation("Veterinario");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.EntidadVacuna", b =>
                {
                    b.HasOne("Veterinaria.App.Dominio.EntidadMascota", "Mascota")
                        .WithMany("listaVacunas")
                        .HasForeignKey("idMascota")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mascota");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.EntidadHistoriaClinico", b =>
                {
                    b.Navigation("listaCitas");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.EntidadMascota", b =>
                {
                    b.Navigation("listaVacunas");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.EntidadCliente", b =>
                {
                    b.Navigation("listaMisMascotas");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.EntidadVeterinario", b =>
                {
                    b.Navigation("listaMascotas");
                });
#pragma warning restore 612, 618
        }
    }
}
