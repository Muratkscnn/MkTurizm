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
    [DbContext(typeof(MKContext))]
    [Migration("20220603211135_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            BusServiceId = 1,
                            Date = new DateTime(2022, 5, 12, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            StationId = 1,
                            Status = true
                        },
                        new
                        {
                            BusServiceId = 2,
                            Date = new DateTime(2022, 5, 12, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            StationId = 2,
                            Status = true
                        },
                        new
                        {
                            BusServiceId = 3,
                            Date = new DateTime(2022, 5, 12, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            StationId = 3,
                            Status = true
                        },
                        new
                        {
                            BusServiceId = 4,
                            Date = new DateTime(2022, 5, 12, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            StationId = 4,
                            Status = true
                        },
                        new
                        {
                            BusServiceId = 5,
                            Date = new DateTime(2022, 5, 12, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            StationId = 5,
                            Status = true
                        },
                        new
                        {
                            BusServiceId = 6,
                            Date = new DateTime(2022, 5, 12, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            StationId = 6,
                            Status = true
                        },
                        new
                        {
                            BusServiceId = 7,
                            Date = new DateTime(2022, 5, 12, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            StationId = 7,
                            Status = true
                        },
                        new
                        {
                            BusServiceId = 8,
                            Date = new DateTime(2022, 5, 12, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            StationId = 8,
                            Status = true
                        },
                        new
                        {
                            BusServiceId = 9,
                            Date = new DateTime(2022, 5, 12, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            StationId = 9,
                            Status = true
                        },
                        new
                        {
                            BusServiceId = 10,
                            Date = new DateTime(2022, 5, 12, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            StationId = 10,
                            Status = true
                        },
                        new
                        {
                            BusServiceId = 11,
                            Date = new DateTime(2022, 5, 12, 23, 0, 0, 0, DateTimeKind.Unspecified),
                            StationId = 11,
                            Status = true
                        },
                        new
                        {
                            BusServiceId = 12,
                            Date = new DateTime(2022, 5, 12, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            StationId = 2,
                            Status = true
                        },
                        new
                        {
                            BusServiceId = 13,
                            Date = new DateTime(2022, 5, 12, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            StationId = 3,
                            Status = true
                        },
                        new
                        {
                            BusServiceId = 14,
                            Date = new DateTime(2022, 5, 12, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            StationId = 1,
                            Status = true
                        },
                        new
                        {
                            BusServiceId = 15,
                            Date = new DateTime(2022, 5, 12, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            StationId = 2,
                            Status = true
                        });
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

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            CityName = "İstanbul"
                        },
                        new
                        {
                            CityId = 2,
                            CityName = "Bolu"
                        },
                        new
                        {
                            CityId = 3,
                            CityName = "Kocaeli"
                        },
                        new
                        {
                            CityId = 4,
                            CityName = "Karabük"
                        },
                        new
                        {
                            CityId = 5,
                            CityName = "Adana"
                        },
                        new
                        {
                            CityId = 6,
                            CityName = "Gaziantep"
                        });
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

                    b.HasData(
                        new
                        {
                            SeatId = 1,
                            SeatNo = 1
                        },
                        new
                        {
                            SeatId = 2,
                            SeatNo = 2
                        },
                        new
                        {
                            SeatId = 3,
                            SeatNo = 3
                        },
                        new
                        {
                            SeatId = 4,
                            SeatNo = 4
                        },
                        new
                        {
                            SeatId = 5,
                            SeatNo = 5
                        },
                        new
                        {
                            SeatId = 6,
                            SeatNo = 6
                        },
                        new
                        {
                            SeatId = 7,
                            SeatNo = 7
                        },
                        new
                        {
                            SeatId = 8,
                            SeatNo = 8
                        },
                        new
                        {
                            SeatId = 9,
                            SeatNo = 9
                        },
                        new
                        {
                            SeatId = 10,
                            SeatNo = 10
                        },
                        new
                        {
                            SeatId = 11,
                            SeatNo = 11
                        },
                        new
                        {
                            SeatId = 12,
                            SeatNo = 12
                        },
                        new
                        {
                            SeatId = 13,
                            SeatNo = 13
                        },
                        new
                        {
                            SeatId = 14,
                            SeatNo = 14
                        },
                        new
                        {
                            SeatId = 15,
                            SeatNo = 15
                        },
                        new
                        {
                            SeatId = 16,
                            SeatNo = 16
                        },
                        new
                        {
                            SeatId = 17,
                            SeatNo = 17
                        },
                        new
                        {
                            SeatId = 18,
                            SeatNo = 18
                        },
                        new
                        {
                            SeatId = 19,
                            SeatNo = 19
                        },
                        new
                        {
                            SeatId = 20,
                            SeatNo = 20
                        },
                        new
                        {
                            SeatId = 21,
                            SeatNo = 21
                        },
                        new
                        {
                            SeatId = 22,
                            SeatNo = 22
                        },
                        new
                        {
                            SeatId = 23,
                            SeatNo = 23
                        },
                        new
                        {
                            SeatId = 24,
                            SeatNo = 24
                        },
                        new
                        {
                            SeatId = 25,
                            SeatNo = 25
                        },
                        new
                        {
                            SeatId = 26,
                            SeatNo = 26
                        },
                        new
                        {
                            SeatId = 27,
                            SeatNo = 27
                        },
                        new
                        {
                            SeatId = 28,
                            SeatNo = 28
                        },
                        new
                        {
                            SeatId = 29,
                            SeatNo = 29
                        },
                        new
                        {
                            SeatId = 30,
                            SeatNo = 30
                        });
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

                    b.HasData(
                        new
                        {
                            StationId = 1,
                            FromCity = "Karabük",
                            Price = 300,
                            Station1 = "Kocaeli",
                            Station2 = "Bolu",
                            ToCity = "İstanbul"
                        },
                        new
                        {
                            StationId = 2,
                            FromCity = "Gaziantep",
                            Price = 500,
                            Station1 = "Bolu",
                            Station2 = "Adana",
                            ToCity = "İstanbul"
                        },
                        new
                        {
                            StationId = 3,
                            FromCity = "Bolu",
                            Price = 200,
                            Station1 = "",
                            Station2 = "",
                            ToCity = "İstanbul"
                        },
                        new
                        {
                            StationId = 4,
                            FromCity = "Kocaeli",
                            Price = 100,
                            Station1 = "",
                            Station2 = "",
                            ToCity = "İstanbul"
                        },
                        new
                        {
                            StationId = 5,
                            FromCity = "Adana",
                            Price = 400,
                            Station1 = "",
                            Station2 = "",
                            ToCity = "İstanbul"
                        },
                        new
                        {
                            StationId = 6,
                            FromCity = "İstanbul",
                            Price = 300,
                            Station1 = "",
                            Station2 = "",
                            ToCity = "Karabük"
                        },
                        new
                        {
                            StationId = 7,
                            FromCity = "Kocaeli",
                            Price = 200,
                            Station1 = "",
                            Station2 = "",
                            ToCity = "Karabük"
                        },
                        new
                        {
                            StationId = 8,
                            FromCity = "Bolu",
                            Price = 100,
                            Station1 = "",
                            Station2 = "",
                            ToCity = "Karabük"
                        },
                        new
                        {
                            StationId = 9,
                            FromCity = "Adana",
                            Price = 200,
                            Station1 = "",
                            Station2 = "",
                            ToCity = "Gaziantep"
                        },
                        new
                        {
                            StationId = 10,
                            FromCity = "Bolu",
                            Price = 400,
                            Station1 = "",
                            Station2 = "",
                            ToCity = "Gaziantep"
                        },
                        new
                        {
                            StationId = 11,
                            FromCity = "İstabul",
                            Price = 500,
                            Station1 = "Adana",
                            Station2 = "Bolu",
                            ToCity = "Gaziantep"
                        });
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

                    b.HasData(
                        new
                        {
                            PassengerId = 1,
                            PassengerName = "Murat Kuşcan",
                            PassengerTc = "2545897468",
                            PassengerTel = "5364665961"
                        });
                });

            modelBuilder.Entity("EntityLayer.Reservation", b =>
                {
                    b.Property<int>("BusServiceId")
                        .HasColumnType("int");

                    b.Property<int>("SeatNo")
                        .HasColumnType("int");

                    b.Property<int>("PassengerId")
                        .HasColumnType("int");

                    b.Property<int>("PnrNo")
                        .HasColumnType("int");

                    b.HasKey("BusServiceId", "SeatNo");

                    b.HasIndex("PassengerId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            BusServiceId = 1,
                            SeatNo = 10,
                            PassengerId = 1,
                            PnrNo = 25302530
                        });
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