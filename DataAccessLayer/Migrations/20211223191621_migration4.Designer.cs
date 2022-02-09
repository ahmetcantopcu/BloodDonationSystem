﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211223191621_migration4")]
    partial class migration4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("AboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutDetails1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutDetails2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutImage1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutImage2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutMapLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AboutStatus")
                        .HasColumnType("bit");

                    b.HasKey("AboutID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blood", b =>
                {
                    b.Property<int>("BloodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BloodStock")
                        .HasColumnType("int");

                    b.Property<string>("BloodType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BloodID");

                    b.ToTable("Bloods");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("CommentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("CommentTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ContactDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContactMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ContactStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ContactSubject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Donation", b =>
                {
                    b.Property<int>("DonationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DonationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DonationID");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Donor", b =>
                {
                    b.Property<int>("DonorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BloodID")
                        .HasColumnType("int");

                    b.Property<int>("DonationID")
                        .HasColumnType("int");

                    b.Property<string>("DonorAbout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DonorAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DonorAge")
                        .HasColumnType("int");

                    b.Property<string>("DonorImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DonorMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DonorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DonorPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DonorSex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DonorStatus")
                        .HasColumnType("bit");

                    b.HasKey("DonorID");

                    b.HasIndex("BloodID");

                    b.HasIndex("DonationID");

                    b.ToTable("Donors");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Evaluation", b =>
                {
                    b.Property<int>("EvaluationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EvaluationContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EvaluationCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EvaluationImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EvaluationStatus")
                        .HasColumnType("bit");

                    b.Property<string>("EvaluationThumbNailImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EvaluationTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EvaluationID");

                    b.ToTable("Evaluations");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Hospital", b =>
                {
                    b.Property<int>("HospitalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HospitalCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HospitalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HospitalStatus")
                        .HasColumnType("bit");

                    b.HasKey("HospitalID");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Donor", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Blood", "Blood")
                        .WithMany("Donors")
                        .HasForeignKey("BloodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Donation", "Donation")
                        .WithMany("Donors")
                        .HasForeignKey("DonationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blood");

                    b.Navigation("Donation");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blood", b =>
                {
                    b.Navigation("Donors");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Donation", b =>
                {
                    b.Navigation("Donors");
                });
#pragma warning restore 612, 618
        }
    }
}
