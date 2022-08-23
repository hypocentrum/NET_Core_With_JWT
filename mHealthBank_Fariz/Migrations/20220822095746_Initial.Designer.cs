﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mHealthBank_Fariz.Entities;

#nullable disable

namespace mHealthBank_Fariz.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220822095746_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("mHealthBank_Fariz.Entities.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alamat")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageProfileUrl")
                        .HasColumnType("TEXT");

                    b.Property<int>("JenisKelamin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nama")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TanggalLahir")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserProfiles", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
