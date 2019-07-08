﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestAirline.ReadModel.EntityFramework.DBContext;

namespace RestAirline.ReadModel.EntityFramework.Migrations
{
    [DbContext(typeof(ReadModelContext))]
    [Migration("20190630070457_add journeys")]
    partial class addjourneys
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RestAirline.ReadModel.EntityFramework.Booking.Flight", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Aircraft");

                    b.Property<DateTime>("ArriveDate");

                    b.Property<string>("ArriveStation");

                    b.Property<DateTime>("DepartureDate");

                    b.Property<string>("DepartureStation");

                    b.Property<string>("FlightKey");

                    b.Property<string>("JourneyKey");

                    b.Property<string>("Number");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("JourneyKey")
                        .IsUnique()
                        .HasFilter("[JourneyKey] IS NOT NULL");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("RestAirline.ReadModel.EntityFramework.Booking.Journey", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ArriveDate");

                    b.Property<string>("ArriveStation");

                    b.Property<string>("BookingReadModelId");

                    b.Property<string>("BookingReadModelId1");

                    b.Property<DateTime>("DepartureDate");

                    b.Property<string>("DepartureStation");

                    b.Property<string>("Description");

                    b.Property<string>("JourneyKey");

                    b.HasKey("Id");

                    b.HasIndex("BookingReadModelId");

                    b.HasIndex("BookingReadModelId1");

                    b.ToTable("Journeys");
                });

            modelBuilder.Entity("RestAirline.ReadModel.EntityFramework.Booking.Passenger", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("BookingReadModelId");

                    b.Property<string>("BookingReadModelId1");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("PassengerKey");

                    b.Property<int>("PassengerType");

                    b.Property<long>("Version")
                        .IsConcurrencyToken();

                    b.HasKey("Id");

                    b.HasIndex("BookingReadModelId");

                    b.HasIndex("BookingReadModelId1");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("RestAirline.ReadModel.EntityFramework.BookingReadModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DepartureStation");

                    b.Property<long>("Version")
                        .IsConcurrencyToken();

                    b.HasKey("Id");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("RestAirline.ReadModel.EntityFramework.Booking.Flight", b =>
                {
                    b.HasOne("RestAirline.ReadModel.EntityFramework.Booking.Journey", "Journey")
                        .WithOne("Flight")
                        .HasForeignKey("RestAirline.ReadModel.EntityFramework.Booking.Flight", "JourneyKey");
                });

            modelBuilder.Entity("RestAirline.ReadModel.EntityFramework.Booking.Journey", b =>
                {
                    b.HasOne("RestAirline.ReadModel.EntityFramework.BookingReadModel", "BookingReadModel")
                        .WithMany()
                        .HasForeignKey("BookingReadModelId");

                    b.HasOne("RestAirline.ReadModel.EntityFramework.BookingReadModel")
                        .WithMany("Journeys")
                        .HasForeignKey("BookingReadModelId1");
                });

            modelBuilder.Entity("RestAirline.ReadModel.EntityFramework.Booking.Passenger", b =>
                {
                    b.HasOne("RestAirline.ReadModel.EntityFramework.BookingReadModel", "BookingReadModel")
                        .WithMany()
                        .HasForeignKey("BookingReadModelId");

                    b.HasOne("RestAirline.ReadModel.EntityFramework.BookingReadModel")
                        .WithMany("Passengers")
                        .HasForeignKey("BookingReadModelId1");
                });
#pragma warning restore 612, 618
        }
    }
}
