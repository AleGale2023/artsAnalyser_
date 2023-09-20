﻿// <auto-generated />
using DbReliques;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DbReliques.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DbReliques.Relique", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<double>("critmass")
                        .HasColumnType("double precision");

                    b.Property<double>("est")
                        .HasColumnType("double precision");

                    b.Property<int>("idset")
                        .HasColumnType("integer");

                    b.Property<int>("idtype")
                        .HasColumnType("integer");

                    b.Property<int>("idupstate")
                        .HasColumnType("integer");

                    b.Property<bool>("isgold")
                        .HasColumnType("boolean");

                    b.Property<int>("level")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Relique");
                });

            modelBuilder.Entity("DbReliques.Set", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("effect2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("effect4")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("islegendary")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Set");
                });

            modelBuilder.Entity("DbReliques.State", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<bool>("issubst")
                        .HasColumnType("boolean");

                    b.Property<bool>("isupstate")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("State");
                });

            modelBuilder.Entity("DbReliques.Substates", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("idrel")
                        .HasColumnType("integer");

                    b.Property<int>("idstate")
                        .HasColumnType("integer");

                    b.Property<double>("value")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.ToTable("Substates");
                });

            modelBuilder.Entity("DbReliques.Type", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Type");
                });

            modelBuilder.Entity("DbReliques.TypeUpValue", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("idtype")
                        .HasColumnType("integer");

                    b.Property<int>("idupstate")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("TypeUpValue");
                });

            modelBuilder.Entity("DbReliques.UpStateValue", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("idstate")
                        .HasColumnType("integer");

                    b.Property<int>("level")
                        .HasColumnType("integer");

                    b.Property<double>("value")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.ToTable("UpStateValue");
                });
#pragma warning restore 612, 618
        }
    }
}