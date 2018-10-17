﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using asp_practice.Models;

namespace asp_practice.Migrations
{
    [DbContext(typeof(asp_practiceContext))]
    partial class asp_practiceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Practice_POSR_MVC.Models.Form", b =>
                {
                    b.Property<int>("Form_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(100);

                    b.Property<int>("Display_Seq");

                    b.Property<string>("File_Name")
                        .HasMaxLength(50);

                    b.Property<string>("Form_Name")
                        .HasMaxLength(50);

                    b.HasKey("Form_ID");

                    b.ToTable("Form");
                });
#pragma warning restore 612, 618
        }
    }
}