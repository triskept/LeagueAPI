using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueAPI.Models;

namespace LeagueAPI.Context
{
    public class LeagueContext : DbContext
    {


        public DbSet<Character> Characters { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Build> Builds { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=LeagueAPI;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
            //.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData(
                new Character()
                {
                    Id = 1,
                    Name = "Aatrox",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/1.png",
                },
                new Character()
                {
                    Id = 2,
                    Name = "Ahri",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/2.png",
                },
                new Character()
                {
                    Id = 3,
                    Name = "Akali",
                    PositionId = 3,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/3.png",
                },
                new Character()
                {
                    Id = 4,
                    Name = "Alistar",
                    PositionId = 5,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/4.png",
                },
                new Character()
                {
                    Id = 5,
                    Name = "Amumu",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/5.png",
                },
                new Character()
                {
                    Id = 6,
                    Name = "Anivia",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/6.png",
                },
                new Character()
                {
                    Id = 7,
                    Name = "Annie",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/7.png",
                },
                new Character()
                {
                    Id = 8,
                    Name = "Ashe",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/8.png",
                },

                new Character()
                {
                    Id = 9,
                    Name = "Aurrelion Sol",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/9.png",
                },
                new Character()
                {
                    Id = 10,
                    Name = "Azir",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/10.png",
                },
                new Character()
                {
                    Id = 11,
                    Name = "Bard",
                    PositionId = 5,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/11.png",
                },
                new Character()
                {
                    Id = 12,
                    Name = "Blitzcrank",
                    PositionId = 5,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/12.png",
                },
                new Character()
                {
                    Id = 13,
                    Name = "Brand",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/13.png",
                },
                new Character()
                {
                    Id = 14,
                    Name = "Braum",
                    PositionId = 5,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/14.png",
                },
                new Character()
                {
                    Id = 15,
                    Name = "Caitlyn",
                    PositionId = 4,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/15.png",
                },
                new Character()
                {
                    Id = 16,
                    Name = "Camille",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/16.png",
                },

                new Character()
                {
                    Id = 17,
                    Name = "Cassilopeia",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/17.png",
                },
                new Character()
                {
                    Id = 18,
                    Name = "Cho’Gath",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/18.png",
                },
                new Character()
                {
                    Id = 19,
                    Name = "Corki",
                    PositionId = 4,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/19.png",
                },
                new Character()
                {
                    Id = 20,
                    Name = "Darius",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/20.png",
                },
                new Character()
                {
                    Id = 21,
                    Name = "Diana",
                    PositionId = 3,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/21.png",
                },
                new Character()
                {
                    Id = 22,
                    Name = "Dr. Mundo",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/22.png",
                },

                new Character()
                {
                    Id = 23,
                    Name = "Draven",
                    PositionId = 4,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/23.png",
                },
                new Character()
                {
                    Id = 24,
                    Name = "Ekko",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/24.png",
                },
                new Character()
                {
                    Id = 25,
                    Name = "Elise",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/25.png",
                },
                new Character()
                {
                    Id = 26,
                    Name = "Evelynn",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/26.png",
                },
                new Character()
                {
                    Id = 27,
                    Name = "Ezreal",
                    PositionId = 4,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/27.png",
                },

                new Character()
                {
                    Id = 28,
                    Name = "Fiddlesticks",
                    PositionId = 2,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/28.png",
                },
                new Character()
                {
                    Id = 29,
                    Name = "Fiora",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/29.png",
                },
                new Character()
                {
                    Id = 30,
                    Name = "Fizz",
                    PositionId = 3,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/30.png",
                },
                new Character()
                {
                    Id = 31,
                    Name = "Galio",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/31.png",
                },
                new Character()
                {
                    Id = 32,
                    Name = "Gangplank",
                    PositionId = 1,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/32.png",
                },
                new Character()
                {
                    Id = 33,
                    Name = "Garen",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/33.png",
                },

                new Character()
                {
                    Id = 34,
                    Name = "Gnar",
                    PositionId = 1,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/34.png",
                },
                new Character()
                {
                    Id = 35,
                    Name = "Gragas",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/35.png",
                },
                new Character()
                {
                    Id = 36,
                    Name = "Graves",
                    PositionId = 5,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/36.png",
                },
                new Character()
                {
                    Id = 37,
                    Name = "Hecarim",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/37.png",
                },
                new Character()
                {
                    Id = 38,
                    Name = "Heimerdinger",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/38.png",
                },
                new Character()
                {
                    Id = 39,
                    Name = "Illaoi",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/39.png",
                },
                new Character()
                {
                    Id = 40,
                    Name = "Irelia",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/40.png",
                },

                new Character()
                {
                    Id = 41,
                    Name = "Ivern",
                    PositionId = 2,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/41.png",
                },
                new Character()
                {
                    Id = 42,
                    Name = "Janna",
                    PositionId = 5,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/42.png",
                },
                new Character()
                {
                    Id = 43,
                    Name = "Jarvan IV",
                    PositionId = 2,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/43.png",
                },
                 new Character()
                 {
                     Id = 44,
                     Name = "Jayce",
                     PositionId = 1,
                     AtkType = "Ranged",
                     DmgType = "Attack Damage",
                     Image = "/images/44.png",
                 },
                new Character()
                {
                    Id = 45,
                    Name = "Jax",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/45.png",
                },
                new Character()
                {
                    Id = 46,
                    Name = "Jhin",
                    PositionId = 4,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/46.png",
                },
                new Character()
                {
                    Id = 47,
                    Name = "Jinx",
                    PositionId = 4,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/47.png",
                },
                new Character()
                {
                    Id = 48,
                    Name = "Kai’Sa",
                    PositionId = 4,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/48.png",
                },

                new Character()
                {
                    Id = 49,
                    Name = "Kalista",
                    PositionId = 4,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/49.png",
                },
                new Character()
                {
                    Id = 50,
                    Name = "Karma",
                    PositionId = 5,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/50.png",
                },
                new Character()
                {
                    Id = 51,
                    Name = "Karthas",
                    PositionId = 2,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/51.png",
                },
                new Character()
                {
                    Id = 52,
                    Name = "Kassadin",
                    PositionId = 3,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/52.png",
                },
                new Character()
                {
                    Id = 53,
                    Name = "Katarina",
                    PositionId = 3,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/53.png",
                },
                new Character()
                {
                    Id = 54,
                    Name = "Kayle",
                    PositionId = 1,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/54.png",
                },
                new Character()
                {
                    Id = 55,
                    Name = "Kayn",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/55.png",
                },

                new Character()
                {
                    Id = 56,
                    Name = "Kennen",
                    PositionId = 1,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/56.png",
                },
                new Character()
                {
                    Id = 57,
                    Name = "Kha’Zix",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/57.png",
                },
                new Character()
                {
                    Id = 58,
                    Name = "Kindred",
                    PositionId = 2,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/58.png",
                },
                new Character()
                {
                    Id = 59,
                    Name = "Kled",
                    PositionId = 1,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/59.png",
                },
                new Character()
                {
                    Id = 60,
                    Name = "Kog’Maw",
                    PositionId = 4,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/60.png",
                },
                new Character()
                {
                    Id = 61,
                    Name = "LeBlanc",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/61.png",
                },

                new Character()
                {
                    Id = 62,
                    Name = "Lee Sin",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/62.png",
                },
                new Character()
                {
                    Id = 63,
                    Name = "Leona",
                    PositionId = 5,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/63.png",
                },
                new Character()
                {
                    Id = 64,
                    Name = "Lissandra",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/64.png",
                },
                new Character()
                {
                    Id = 65,
                    Name = "Lucian",
                    PositionId = 4,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/65.png",
                },
                new Character()
                {
                    Id = 66,
                    Name = "Lulu",
                    PositionId = 5,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/66.png",
                },
                new Character()
                {
                    Id = 67,
                    Name = "Lux",
                    PositionId = 5,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/67.png",
                },

                new Character()
                {
                    Id = 68,
                    Name = "Malphite",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/68.png",
                },
                new Character()
                {
                    Id = 69,
                    Name = "Malzahar",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/69.png",
                },
                new Character()
                {
                    Id = 70,
                    Name = "Maokai",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/70.png",
                },
                new Character()
                {
                    Id = 71,
                    Name = "Master Yi",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/71.png",
                },
                new Character()
                {
                    Id = 72,
                    Name = "Miss Fortune",
                    PositionId = 4,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/72.png",
                },

                new Character()
                {
                    Id = 73,
                    Name = "Mordekaiser",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/73.png",
                },
                new Character()
                {
                    Id = 74,
                    Name = "Morgana",
                    PositionId = 5,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/74.png",
                },
                new Character()
                {
                    Id = 75,
                    Name = "Nami",
                    PositionId = 5,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/75.png",
                },
                new Character()
                {
                    Id = 76,
                    Name = "Nasus",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/76.png",
                },
                new Character()
                {
                    Id = 77,
                    Name = "Nautilus",
                    PositionId = 5,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/77.png",
                },
                new Character()
                {
                    Id = 78,
                    Name = "Neeko",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/78.png",
                },
                new Character()
                {
                    Id = 79,
                    Name = "Nidalee",
                    PositionId = 2,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/79.png",
                },

                new Character()
                {
                    Id = 80,
                    Name = "Nocturne",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/80.png",
                },
                new Character()
                {
                    Id = 81,
                    Name = "Nunu",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/81.png",
                },
                new Character()
                {
                    Id = 82,
                    Name = "Olaf",
                    PositionId = 2,
                    AtkType = "Melee",
                    Image = "/images/82.png",
                    DmgType = "Attack Damage"
                },
                new Character()
                {
                    Id = 83,
                    Name = "Orianna",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/83.png",
                },
                new Character()
                {
                    Id = 84,
                    Name = "Ornn",
                    PositionId = 1,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/84.png",
                },


                new Character()
                {
                    Id = 85,
                    Name = "Pantheon",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/85.png",
                },
                new Character()
                {
                    Id = 86,
                    Name = "Poppy",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/86.png",
                },
                new Character()
                {
                    Id = 87,
                    Name = "Pyke",
                    PositionId = 5,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/87.png",
                },
                new Character()
                {
                    Id = 88,
                    Name = "Qiyana",
                    PositionId = 3,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/88.png",
                },

                new Character()
                {
                    Id = 89,
                    Name = "Quinn",
                    PositionId = 1,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/89.png",
                },

                new Character()
                {
                    Id = 90,
                    Name = "Rakan",
                    PositionId = 5,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/90.png",
                },

                new Character()
                {
                    Id = 91,
                    Name = "Rammus",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/91.png",
                },


                new Character()
                {
                    Id = 92,
                    Name = "Rek’Sai",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/92.png",
                },

                new Character()
                {
                    Id = 93,
                    Name = "Renekton",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/93.png",
                },

                new Character()
                {
                    Id = 94,
                    Name = "Rengar",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/94.png",
                },

                new Character()
                {
                    Id = 95,
                    Name = "Riven",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/95.png",
                },

                new Character()
                {
                    Id = 96,
                    Name = "Rumble",
                    PositionId = 1,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/96.png",
                },

                new Character()
                {
                    Id = 97,
                    Name = "Ryze"
, PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/97.png",
                },

                new Character()
                {
                    Id = 98,
                    Name = "Sejuani",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/98.png",
                },

                new Character()
                {
                    Id = 99,
                    Name = "Senna",
                    PositionId = 5,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/99.png",
                },

                new Character()
                {
                    Id = 100,
                    Name = "Shaco",
                    PositionId = 5,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/100.png",
                },

                new Character()
                {
                    Id = 101,
                    Name = "Shen",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/101.png",
                },

                new Character()
                {
                    Id = 102,
                    Name = "Shyvana",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/102.png",
                },

                new Character()
                {
                    Id = 103,
                    Name = "Singed",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/103.png",
                },

                new Character()
                {
                    Id = 104,
                    Name = "Rumble",
                    PositionId = 1,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/104.png",
                },

                new Character()
                {
                    Id = 105,
                    Name = "Sion",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/105.png",
                },

                new Character()
                {
                    Id = 106,
                    Name = "Sivir",
                    PositionId = 5,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/106.png",
                },

                new Character()
                {
                    Id = 107,
                    Name = "Skarner",
                    PositionId = 5,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/107.png",
                },

                new Character()
                {
                    Id = 108,
                    Name = "Sona",
                    PositionId = 5,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/108.png",
                },

                new Character()
                {
                    Id = 109,
                    Name = "Soraka",
                    PositionId = 5,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/109.png",
                },

                new Character()
                {
                    Id = 110,
                    Name = "Swain",
                    PositionId = 1,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/110.png",
                },

                new Character()
                {
                    Id = 111,
                    Name = "Sylas",
                    PositionId = 3,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/111.png",
                },

                new Character()
                {
                    Id = 112,
                    Name = "Syndra",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/112.png",
                },

                new Character()
                {
                    Id = 113,
                    Name = "Tahm Kench",
                    PositionId = 5,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/113.png",
                },

                new Character()
                {
                    Id = 114,
                    Name = "Taliyah",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/114.png",
                },

                new Character()
                {
                    Id = 115,
                    Name = "Talon",
                    PositionId = 5,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/115.png",
                },

                new Character()
                {
                    Id = 116,
                    Name = "Teemo",
                    PositionId = 5,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/116.png",
                },

                new Character()
                {
                    Id = 117,
                    Name = "Thresh",
                    PositionId = 5,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/117.png",
                },

                new Character()
                {
                    Id = 118,
                    Name = "Tristana",
                    PositionId = 4,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/118.png",
                },

                new Character()
                {
                    Id = 119,
                    Name = "Trundle",
                    PositionId = 2,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/119.png",
                },

                new Character()
                {
                    Id = 120,
                    Name = "Tryndamere",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/120.png",
                },

                new Character()
                {
                    Id = 121,
                    Name = "Twisted Fate",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/121.png",
                },

                new Character()
                {
                    Id = 122,
                    Name = "Twitch",
                    PositionId = 4,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/122.png",
                },

                new Character()
                {
                    Id = 123,
                    Name = "Udyr",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/123.png",
                },

                new Character()
                {
                    Id = 124,
                    Name = "Urgot",
                    PositionId = 1,
                    AtkType = "Ranged",
                    DmgType = "Ability Damage",
                    Image = "/images/124.png",
                },

                new Character()
                {
                    Id = 125,
                    Name = "Varus",
                    PositionId = 4,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/125.png",
                },

                new Character()
                {
                    Id = 126,
                    Name = "Vayne",
                    PositionId = 4,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/126.png",
                },

                new Character()
                {
                    Id = 127,
                    Name = "Veigar",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/127.png",
                },

                new Character()
                {
                    Id = 128,
                    Name = "Velkoz",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/128.png",
                },

                new Character()
                {
                    Id = 129,
                    Name = "Vi",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/129.png",
                },

                new Character()
                {
                    Id = 130,
                    Name = "Viktor",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/130.png",
                },

                new Character()
                {
                    Id = 131,
                    Name = "Vladmir",
                    PositionId = 1,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/131.png",
                },

                new Character()
                {
                    Id = 132,
                    Name = "Volibear",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/132.png",
                },

                new Character()
                {
                    Id = 133,
                    Name = "Warwick",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/133.png",
                },

                new Character()
                {
                    Id = 134,
                    Name = "Wukong",
                    PositionId = 2,
                    AtkType = "Melee",
                    Image = "/images/134.png",
                    DmgType = "Attack Damage"
                },

                new Character()
                {
                    Id = 135,
                    Name = "Xayah",
                    PositionId = 4,
                    AtkType = "Ranged",
                    DmgType = "Attack Damage",
                    Image = "/images/135.png",
                },
                new Character()
                {
                    Id = 136,
                    Name = "Xerath",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/136.png",
                },

                new Character()
                {
                    Id = 137,
                    Name = "Xin Zhao",
                    PositionId = 2,
                    AtkType = "Melee",
                    DmgType = "Ability Power",
                    Image = "/images/137.png",
                },

                new Character()
                {
                    Id = 138,
                    Name = "Yasuo",
                    PositionId = 3,
                    AtkType = "Melee",
                    DmgType = "Attack",
                    Image = "/images/138.png",
                },

                new Character()
                {
                    Id = 139,
                    Name = "Yorick",
                    PositionId = 1,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/139.png",
                },
                new Character()
                {
                    Id = 140,
                    Name = "Yuumi",
                    PositionId = 5,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/140.png",
                },
                new Character()
                {
                    Id = 141,
                    Name = "Zac",
                    PositionId = 2,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/141.png",
                },

                new Character()
                {
                    Id = 142,
                    Name = "Zed",
                    PositionId = 3,
                    AtkType = "Melee",
                    DmgType = "Attack Damage",
                    Image = "/images/142.png",
                },

                new Character()
                {
                    Id = 143,
                    Name = "Ziggs",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/143.png",
                },

                new Character()
                {
                    Id = 144,
                    Name = "Zilean",
                    PositionId = 5,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/144.png",
                },

                new Character()
                {
                    Id = 145,
                    Name = "Zoe",
                    PositionId = 3,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/145.png",
                },

                new Character()
                {
                    Id = 146,
                    Name = "Zyra",
                    PositionId = 1,
                    AtkType = "Ranged",
                    DmgType = "Ability Power",
                    Image = "/images/146.png",
                });


            modelBuilder.Entity<Position>().HasData(
                    new Position()
                    {
                        Id = 1,
                        Name = "Top",

                    },
                    new Position()
                    {
                        Id = 2,
                        Name = "Jungle",

                    },
                    new Position()
                    {
                        Id = 3,
                        Name = "Mid",

                    },
                    new Position()
                    {
                        Id = 4,
                        Name = "ADC",

                    },
                    new Position()
                    {
                        Id = 5,
                        Name = "Support",

                    });
            modelBuilder.Entity<Build>().HasData(
            new Build()
            {
                Id = 1,
                Name = "Life Steal",
                Items = "Death's Dance, BloodThirster, Blade of the Ruine King, Mercurial Scimitar, Berserker Greaves, Hectech Gunblade",
                CharacterId = 1,

            });

        }
    }
}