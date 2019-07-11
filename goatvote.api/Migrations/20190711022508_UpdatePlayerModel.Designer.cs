﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using goatvote.api.Data;

namespace goatvote.api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190711022508_UpdatePlayerModel")]
    partial class UpdatePlayerModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("goatvote.api.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AllNBASelections");

                    b.Property<float>("AssistsPerGame");

                    b.Property<float>("BlocksPerGame");

                    b.Property<float>("FG3Percentage");

                    b.Property<float>("FGPercentage");

                    b.Property<float>("FTPercentage");

                    b.Property<int>("FinalMVPAwards");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("MVPAwards");

                    b.Property<float>("PlayerEffeciencyRating");

                    b.Property<float>("PointsPerGame");

                    b.Property<float>("ReboundsPerGame");

                    b.Property<float>("StealsPerGame");

                    b.Property<int>("Total50PointPlusGames");

                    b.Property<int>("TotalAllStarGames");

                    b.Property<int>("TotalGamesPlayed");

                    b.Property<int>("TotalMinutesPlayed");

                    b.Property<int>("TotalPlayoffGames");

                    b.Property<int>("TotalPoints");

                    b.Property<int>("TotalSeasonsPlayed");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
