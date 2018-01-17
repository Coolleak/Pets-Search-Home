﻿// <auto-generated />
using DAL.EF.Context;
using Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DAL.EF.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20180116173734_DeletedShelterFieldInUserTable")]
    partial class DeletedShelterFieldInUserTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.EF.Records.AddressRecord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<DateTime>("DateAdded");

                    b.Property<int>("House");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Street");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("DAL.EF.Records.AnimalRecord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnimalType");

                    b.Property<string>("Breed");

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<int>("Gender");

                    b.Property<string>("Name");

                    b.Property<string>("Photo");

                    b.HasKey("Id");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("DAL.EF.Records.ColorRecord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("AnimalRecordId");

                    b.Property<int>("Color");

                    b.Property<DateTime>("DateAdded");

                    b.HasKey("Id");

                    b.HasIndex("AnimalRecordId");

                    b.ToTable("AnimalColors");
                });

            modelBuilder.Entity("DAL.EF.Records.ComplainsRecord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateAdded");

                    b.Property<long?>("ShelterId");

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ShelterId");

                    b.HasIndex("UserId");

                    b.ToTable("Complains");
                });

            modelBuilder.Entity("DAL.EF.Records.FavoritesRecord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("AnimalId");

                    b.Property<DateTime>("DateAdded");

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("UserId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("DAL.EF.Records.PostRecord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("AnimalId");

                    b.Property<DateTime>("DateAdded");

                    b.Property<int>("PostType");

                    b.Property<int>("State");

                    b.Property<long?>("UserRecordId");

                    b.Property<DateTime>("When");

                    b.Property<long?>("WhereId");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("UserRecordId");

                    b.HasIndex("WhereId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("DAL.EF.Records.ShelterRecord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("AdressId");

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("Photo");

                    b.Property<string>("Requisites");

                    b.Property<int>("State");

                    b.HasKey("Id");

                    b.HasIndex("AdressId");

                    b.ToTable("Shelter");
                });

            modelBuilder.Entity("DAL.EF.Records.UserRecord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("AdressId");

                    b.Property<DateTime>("BirthDate");

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.Property<string>("Photo");

                    b.Property<long?>("ShelterRecordId");

                    b.Property<int>("State");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("AdressId");

                    b.HasIndex("ShelterRecordId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DAL.EF.Records.ColorRecord", b =>
                {
                    b.HasOne("DAL.EF.Records.AnimalRecord")
                        .WithMany("Colors")
                        .HasForeignKey("AnimalRecordId");
                });

            modelBuilder.Entity("DAL.EF.Records.ComplainsRecord", b =>
                {
                    b.HasOne("DAL.EF.Records.ShelterRecord", "Shelter")
                        .WithMany()
                        .HasForeignKey("ShelterId");

                    b.HasOne("DAL.EF.Records.UserRecord", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DAL.EF.Records.FavoritesRecord", b =>
                {
                    b.HasOne("DAL.EF.Records.AnimalRecord", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId");

                    b.HasOne("DAL.EF.Records.UserRecord", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DAL.EF.Records.PostRecord", b =>
                {
                    b.HasOne("DAL.EF.Records.AnimalRecord", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId");

                    b.HasOne("DAL.EF.Records.UserRecord")
                        .WithMany("UserPosts")
                        .HasForeignKey("UserRecordId");

                    b.HasOne("DAL.EF.Records.AddressRecord", "Where")
                        .WithMany()
                        .HasForeignKey("WhereId");
                });

            modelBuilder.Entity("DAL.EF.Records.ShelterRecord", b =>
                {
                    b.HasOne("DAL.EF.Records.AddressRecord", "Adress")
                        .WithMany()
                        .HasForeignKey("AdressId");
                });

            modelBuilder.Entity("DAL.EF.Records.UserRecord", b =>
                {
                    b.HasOne("DAL.EF.Records.AddressRecord", "Adress")
                        .WithMany()
                        .HasForeignKey("AdressId");

                    b.HasOne("DAL.EF.Records.ShelterRecord")
                        .WithMany("UsersWorkers")
                        .HasForeignKey("ShelterRecordId");
                });
#pragma warning restore 612, 618
        }
    }
}
