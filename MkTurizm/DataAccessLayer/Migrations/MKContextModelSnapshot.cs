﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(MKContext))]
    partial class MKContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.BusService", b =>
                {
                    b.Property<int>("BusServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("StationId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("BusServiceId");

                    b.HasIndex("StationId");

                    b.ToTable("BusServices");
                });

            modelBuilder.Entity("EntityLayer.Concrete.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SeatNo")
                        .HasColumnType("int");

                    b.HasKey("SeatId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Station", b =>
                {
                    b.Property<int>("StationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FromCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Station1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Station2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToCity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StationId");

                    b.ToTable("Stations");
                });

            modelBuilder.Entity("EntityLayer.Passenger", b =>
                {
                    b.Property<int>("PassengerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PassengerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassengerTc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassengerTel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PassengerId");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("EntityLayer.Reservation", b =>
                {
                    b.Property<int>("BusServiceId")
                        .HasColumnType("int");

                    b.Property<int>("SeatNo")
                        .HasColumnType("int");

                    b.Property<int>("PassengerId")
                        .HasColumnType("int");

                    b.HasKey("BusServiceId", "SeatNo");

                    b.HasIndex("PassengerId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("EntityLayer.BusService", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Station", "Station")
                        .WithMany("BusServices")
                        .HasForeignKey("StationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Station");
                });

            modelBuilder.Entity("EntityLayer.Reservation", b =>
                {
                    b.HasOne("EntityLayer.BusService", "BusService")
                        .WithMany("Reservation")
                        .HasForeignKey("BusServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Passenger", "Passenger")
                        .WithMany("Reservations")
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusService");

                    b.Navigation("Passenger");
                });

            modelBuilder.Entity("EntityLayer.BusService", b =>
                {
                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Station", b =>
                {
                    b.Navigation("BusServices");
                });

            modelBuilder.Entity("EntityLayer.Passenger", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
