﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NETCore_Angular_AwesomeApps.Models;

namespace NETCore_Angular_AwesomeApps.Migrations
{
    [DbContext(typeof(AwesomeAppsContext))]
    [Migration("20190904164633_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NETCore_Angular_AwesomeApps.Models.CareerCloud.Poco.ApplicantEducationPoco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Applicant");

                    b.Property<string>("CertificateDiploma")
                        .HasColumnName("Certificate_Diploma");

                    b.Property<DateTime?>("CompletionDate")
                        .HasColumnName("Completion_Date");

                    b.Property<byte?>("CompletionPercent")
                        .HasColumnName("Completion_Percent");

                    b.Property<string>("Major");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnName("Start_Date");

                    b.Property<byte[]>("TimeStamp")
                        .HasColumnName("Time_Stamp");

                    b.HasKey("Id");

                    b.ToTable("Applicant_Educations");
                });

            modelBuilder.Entity("NETCore_Angular_AwesomeApps.Models.CareerCloud.Poco.ApplicantProfilePoco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .HasColumnName("City_Town");

                    b.Property<string>("Country")
                        .HasColumnName("Country_Code");

                    b.Property<string>("Currency");

                    b.Property<decimal?>("CurrentRate")
                        .HasColumnName("Current_Rate");

                    b.Property<decimal?>("CurrentSalary")
                        .HasColumnName("Current_Salary");

                    b.Property<Guid>("Login");

                    b.Property<string>("PostalCode")
                        .HasColumnName("Zip_Postal_Code");

                    b.Property<string>("Province")
                        .HasColumnName("State_Province_Code");

                    b.Property<string>("Street")
                        .HasColumnName("Street_Address");

                    b.Property<byte[]>("TimeStamp")
                        .HasColumnName("Time_Stamp");

                    b.HasKey("Id");

                    b.ToTable("Applicant_Profiles");
                });

            modelBuilder.Entity("NETCore_Angular_AwesomeApps.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Genre");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });
#pragma warning restore 612, 618
        }
    }
}
