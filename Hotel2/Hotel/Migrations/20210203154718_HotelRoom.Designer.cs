﻿// <auto-generated />
using System;
using Hotel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hotel.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20210203154718_HotelRoom")]
    partial class HotelRoom
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Hotel.Data.Models.HotelRoomItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("HotelRoomId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<int?>("roomid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("roomid");

                    b.ToTable("HotelRoomItem");
                });

            modelBuilder.Entity("Hotel.Data.Models.category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("categoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("desc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Hotel.Data.Models.room", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("LongDEsc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("available")
                        .HasColumnType("bit");

                    b.Property<int>("categoryID")
                        .HasColumnType("int");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isFavourite")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("shortDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("categoryID");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("Hotel.Data.Models.HotelRoomItem", b =>
                {
                    b.HasOne("Hotel.Data.Models.room", "room")
                        .WithMany()
                        .HasForeignKey("roomid");

                    b.Navigation("room");
                });

            modelBuilder.Entity("Hotel.Data.Models.room", b =>
                {
                    b.HasOne("Hotel.Data.Models.category", "Category")
                        .WithMany("room")
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Hotel.Data.Models.category", b =>
                {
                    b.Navigation("room");
                });
#pragma warning restore 612, 618
        }
    }
}
