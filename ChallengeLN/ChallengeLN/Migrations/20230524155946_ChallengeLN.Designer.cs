﻿// <auto-generated />
using System;
using ChallengeLN.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChallengeLN.Migrations
{
    [DbContext(typeof(ChallengeLnContext))]
    [Migration("20230524155946_ChallengeLN")]
    partial class ChallengeLN
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ChallengeLN.Models.Contacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DomicilioId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasDefaultValueSql("('')");

                    b.Property<string>("Empresa")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasDefaultValueSql("('')");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasDefaultValueSql("('')");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasDefaultValueSql("('')");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)")
                        .HasDefaultValueSql("('')");

                    b.HasKey("Id")
                        .HasName("PK__Contacto__3214EC274B87E835");

                    b.ToTable("Contacto", (string)null);
                });

            modelBuilder.Entity("ChallengeLN.Models.Domicilio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasDefaultValueSql("('')");

                    b.Property<int?>("ContactoId")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasDefaultValueSql("('')");

                    b.HasKey("Id")
                        .HasName("PK__Domicilio__3214EC27BCC346F7");

                    b.HasIndex("ContactoId")
                        .IsUnique()
                        .HasFilter("[ContactoId] IS NOT NULL");

                    b.ToTable("Domicilio", (string)null);
                });

            modelBuilder.Entity("ChallengeLN.Models.Domicilio", b =>
                {
                    b.HasOne("ChallengeLN.Models.Contacto", "Contacto")
                        .WithOne("Domicilio")
                        .HasForeignKey("ChallengeLN.Models.Domicilio", "ContactoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("FK_Contacto_Domicilio");

                    b.Navigation("Contacto");
                });

            modelBuilder.Entity("ChallengeLN.Models.Contacto", b =>
                {
                    b.Navigation("Domicilio")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}