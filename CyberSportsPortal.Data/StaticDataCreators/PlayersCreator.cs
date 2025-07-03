using CyberSportsPortal.Data.Entities;
using CyberSportsPortal.Data.Model.Enums;
using Microsoft.EntityFrameworkCore;

namespace CyberSportsPortal.Data.StaticDataCreators
{
    public class PlayersCreator
    {
        public static void CreatePlayers(ModelBuilder builder)
        {
            builder.Entity<Player>().HasData(
                new Player()
                {
                    Id = 1,
                    Name = "Liam",
                    Surname = "Tremblay",
                    Nickname = "Frostbite",
                    Country = Country.Канада,
                    TeamId = 1
                },
                new Player()
                {
                    Id = 2,
                    Name = "Juan",
                    Surname = "dela Cruz",
                    Nickname = "Nighthawk",
                    Country = Country.Филиппины,
                    TeamId = 1
                },
                new Player()
                {
                    Id = 3,
                    Name = "Wei",
                    Surname = "Lim",
                    Nickname = "Ironclad",
                    Country = Country.Сингапур,
                    TeamId = 1
                },
                new Player()
                {
                    Id = 4,
                    Name = "Mikkel",
                    Surname = "Nielsen",
                    Nickname = "Voidwalker",
                    Country = Country.Дания,
                    TeamId = 1
                },
                new Player()
                {
                    Id = 5,
                    Name = "Avi",
                    Surname = "Cohen",
                    Nickname = "Phoenix",
                    Country = Country.Израиль,
                    TeamId = 1
                },
                new Player()
                {
                    Id = 6,
                    Name = "Wei",
                    Surname = "Zhang",
                    Nickname = "Blitz",
                    Country = Country.Китай,
                    TeamId = 2
                },
                new Player()
                {
                    Id = 7,
                    Name = "Ahmad",
                    Surname = "Ibrahim",
                    Nickname = "Spectre",
                    Country = Country.Малайзия,
                    TeamId = 2
                },
                new Player()
                {
                    Id = 8,
                    Name = "Jian",
                    Surname = "Wang",
                    Nickname = "Rampage",
                    Country = Country.Китай,
                    TeamId = 2
                },
                new Player()
                {
                    Id = 9,
                    Name = "Xiao",
                    Surname = "Li",
                    Nickname = "Havoc",
                    Country = Country.Китай,
                    TeamId = 2
                },
                new Player()
                {
                    Id = 10,
                    Name = "Yong",
                    Surname = "Chen",
                    Nickname = "Warlock",
                    Country = Country.Китай,
                    TeamId = 2
                },
                new Player()
                {
                    Id = 11,
                    Name = "Dmitry",
                    Surname = "Ivanov",
                    Nickname = "Night",
                    Country = Country.Россия,
                    TeamId = 3
                },
                new Player()
                {
                    Id = 12,
                    Name = "Alexei",
                    Surname = "Petrov",
                    Nickname = "Overdrive",
                    Country = Country.Россия,
                    TeamId = 3
                },
                new Player()
                {
                    Id = 13,
                    Name = "Sergei",
                    Surname = "Volkov",
                    Nickname = "Doombringer",
                    Country = Country.Россия,
                    TeamId = 3
                },
                new Player()
                {
                    Id = 14,
                    Name = "Ion",
                    Surname = "Popov",
                    Nickname = "Paragon",
                    Country = Country.Молдавия,
                    TeamId = 3
                },
                new Player()
                {
                    Id = 15,
                    Name = "Vladimir",
                    Surname = "Kuznetsov",
                    Nickname = "Kingslayer",
                    Country = Country.Россия,
                    TeamId = 3
                },
                new Player()
                {
                    Id = 16,
                    Name = "Oleksandr",
                    Surname = "Shevchenko",
                    Nickname = "Tornado",
                    Country = Country.Белоруссия,
                    TeamId = 4
                },
                new Player()
                {
                    Id = 17,
                    Name = "Artyom",
                    Surname = "Sokolov",
                    Nickname = "Tormentor",
                    Country = Country.Россия,
                    TeamId = 4
                },
                new Player()
                {
                    Id = 18,
                    Name = "Magomed",
                    Surname = "Ibragimov",
                    Nickname = "Collapse",
                    Country = Country.Россия,
                    TeamId = 4
                },
                new Player()
                {
                    Id = 19,
                    Name = "Mykhailo",
                    Surname = "Kovalenko",
                    Nickname = "Mirage",
                    Country = Country.Белоруссия,
                    TeamId = 4
                },
                new Player()
                {
                    Id = 20,
                    Name = "Yaroslav",
                    Surname = "Borisov",
                    Nickname = "Warrior",
                    Country = Country.Россия,
                    TeamId = 4
                },
                new Player()
                {
                    Id = 21,
                    Name = "Elias",
                    Surname = "Korhonen",
                    Nickname = "NordicStorm",
                    Country = Country.Финляндия,
                    TeamId = 5
                },
                new Player()
                {
                    Id = 22,
                    Name = "Krzysztof",
                    Surname = "Nowak",
                    Nickname = "VoidPulse",
                    Country = Country.Польша,
                    TeamId = 5
                },
                new Player()
                {
                    Id = 23,
                    Name = "Erik",
                    Surname = "Andersson",
                    Nickname = "FrostGiant",
                    Country = Country.Швеция,
                    TeamId = 5
                },
                new Player()
                {
                    Id = 24,
                    Name = "Yousef",
                    Surname = "Al-Hashemi",
                    Nickname = "DuneRider",
                    Country = Country.Иордания,
                    TeamId = 5
                },
                new Player()
                {
                    Id = 25,
                    Name = "Mart",
                    Surname = "Tamm",
                    Nickname = "BalticFox",
                    Country = Country.Эстония,
                    TeamId = 5
                },
                new Player()
                {
                    Id = 26,
                    Name = "Georgi",
                    Surname = "Ivanov",
                    Nickname = "BlackHole",
                    Country = Country.Болгария,
                    TeamId = 6
                },
                new Player()
                {
                    Id = 27,
                    Name = "Oskar",
                    Surname = "Johansson",
                    Nickname = "TundraKing",
                    Country = Country.Швеция,
                    TeamId = 6
                },
                new Player()
                {
                    Id = 28,
                    Name = "Ludvig",
                    Surname = "Bergström",
                    Nickname = "IronFist",
                    Country = Country.Швеция,
                    TeamId = 6
                },
                new Player()
                {
                    Id = 29,
                    Name = "Viktor",
                    Surname = "Nilsson",
                    Nickname = "FrozenTide",
                    Country = Country.Швеция,
                    TeamId = 6
                },
                new Player()
                {
                    Id = 30,
                    Name = "Aliaksei",
                    Surname = "Kuzmich",
                    Nickname = "CrimsonDawn",
                    Country = Country.Белоруссия,
                    TeamId = 6
                },
                new Player()
                {
                    Id = 31,
                    Name = "Jing",
                    Surname = "Wong",
                    Nickname = "JadeDragon",
                    Country = Country.Китай,
                    TeamId = 7
                },
                new Player()
                {
                    Id = 32,
                    Name = "Wei",
                    Surname = "Liu",
                    Nickname = "ThunderFist",
                    Country = Country.Китай,
                    TeamId = 7
                },
                new Player()
                {
                    Id = 33,
                    Name = "Hakim",
                    Surname = "Abdullah",
                    Nickname = "Monsoon",
                    Country = Country.Малайзия,
                    TeamId = 7
                },
                new Player()
                {
                    Id = 34,
                    Name = "Xing",
                    Surname = "Zhao",
                    Nickname = "ShadowStep",
                    Country = Country.Китай,
                    TeamId = 7
                },
                new Player()
                {
                    Id = 35,
                    Name = "Wei",
                    Surname = "Chan",
                    Nickname = "SilentStrike",
                    Country = Country.Малайзия,
                    TeamId = 7
                },
                new Player()
                {
                    Id = 36,
                    Name = "Ali",
                    Surname = "Khan",
                    Nickname = "DesertWind",
                    Country = Country.Пакистан,
                    TeamId = 8
                },
                new Player()
                {
                    Id = 37,
                    Name = "Topias",
                    Surname = "Virtanen",
                    Nickname = "ArcticFox",
                    Country = Country.Финляндия,
                    TeamId = 8
                },
                new Player()
                {
                    Id = 38,
                    Name = "Sebastien",
                    Surname = "Dubois",
                    Nickname = "GaulishWarlord",
                    Country = Country.Франция,
                    TeamId = 8
                },
                new Player()
                {
                    Id = 39,
                    Name = "Martin",
                    Surname = "Stojanov",
                    Nickname = "BalkanSniper",
                    Country = Country.Македония,
                    TeamId = 8
                },
                new Player()
                {
                    Id = 40,
                    Name = "Johan",
                    Surname = "Hansen",
                    Nickname = "VikingKing",
                    Country = Country.Дания,
                    TeamId = 8
                },
                new Player()
                {
                    Id = 41,
                    Name = "Oleh",
                    Surname = "Kovalchuk",
                    Nickname = "CyberWolf",
                    Country = Country.Россия,
                    TeamId = 9
                },
                new Player()
                {
                    Id = 42,
                    Name = "Volodymyr",
                    Surname = "Melnyk",
                    Nickname = "NeonBlade",
                    Country = Country.Россия,
                    TeamId = 9
                },
                new Player()
                {
                    Id = 43,
                    Name = "Viktor",
                    Surname = "Savchenko",
                    Nickname = "SteelTitan",
                    Country = Country.Белоруссия,
                    TeamId = 9
                },
                new Player()
                {
                    Id = 44,
                    Name = "Ihor",
                    Surname = "Bondarenko",
                    Nickname = "PhantomDance",
                    Country = Country.Россия,
                    TeamId = 9
                },
                new Player()
                {
                    Id = 45,
                    Name = "Dmytro",
                    Surname = "Ivanov",
                    Nickname = "SiberianHusk",
                    Country = Country.Россия,
                    TeamId = 9
                },
                new Player()
                {
                    Id = 46,
                    Name = "Marcus",
                    Surname = "Johansson",
                    Nickname = "NovaStrike",
                    Country = Country.Швеция,
                    TeamId = 10
                },
                new Player()
                {
                    Id = 47,
                    Name = "Klaus",
                    Surname = "Müller",
                    Nickname = "BlitzKrieg",
                    Country = Country.Германия,
                    TeamId = 10
                },
                new Player()
                {
                    Id = 48,
                    Name = "Emil",
                    Surname = "Söderberg",
                    Nickname = "FrozenCore",
                    Country = Country.Швеция,
                    TeamId = 10
                },
                new Player()
                {
                    Id = 49,
                    Name = "Lars",
                    Surname = "Olsen",
                    Nickname = "FjordWarrior",
                    Country = Country.Норвегия,
                    TeamId = 10
                },
                new Player()
                {
                    Id = 50,
                    Name = "Axel",
                    Surname = "Bergman",
                    Nickname = "PixelHunter",
                    Country = Country.Швеция,
                    TeamId = 10
                },
                new Player()
                {
                    Id = 51,
                    Name = "Marek",
                    Surname = "Novak",
                    Nickname = "SlovakSniper",
                    Country = Country.Словакия,
                    TeamId = 11
                },
                new Player()
                {
                    Id = 52,
                    Name = "Heinrich",
                    Surname = "Schneider",
                    Nickname = "TeutonicKnight",
                    Country = Country.Германия,
                    TeamId = 11
                },
                new Player()
                {
                    Id = 53,
                    Name = "David",
                    Surname = "Levi",
                    Nickname = "MossadAgent",
                    Country = Country.Израиль,
                    TeamId = 11
                },
                new Player()
                {
                    Id = 54,
                    Name = "Brandon",
                    Surname = "Wilson",
                    Nickname = "LibertyPrime",
                    Country = Country.Сша,
                    TeamId = 11
                },
                new Player()
                {
                    Id = 55,
                    Name = "Adrian",
                    Surname = "Fischer",
                    Nickname = "BerlinWall",
                    Country = Country.Германия,
                    TeamId = 11
                },
                new Player()
                {
                    Id = 56,
                    Name = "Chen",
                    Surname = "Liang",
                    Nickname = "JadeEmperor",
                    Country = Country.Китай,
                    TeamId = 12
                },
                new Player()
                {
                    Id = 57,
                    Name = "Wei",
                    Surname = "Zhao",
                    Nickname = "DynastyWarrior",
                    Country = Country.Китай,
                    TeamId = 12
                },
                new Player()
                {
                    Id = 58,
                    Name = "Jian",
                    Surname = "Wu",
                    Nickname = "RedPhoenix",
                    Country = Country.Китай,
                    TeamId = 12
                },
                new Player()
                {
                    Id = 59,
                    Name = "Xiang",
                    Surname = "Liu",
                    Nickname = "DragonFist",
                    Country = Country.Китай,
                    TeamId = 12
                },
                new Player()
                {
                    Id = 60,
                    Name = "Yong",
                    Surname = "Sun",
                    Nickname = "GreatWall",
                    Country = Country.Китай,
                    TeamId = 12
                },
                new Player()
                {
                    Id = 61,
                    Name = "Peng",
                    Surname = "Wu",
                    Nickname = "GoldenDragon",
                    Country = Country.Китай,
                    TeamId = 13
                },
                new Player()
                {
                    Id = 62,
                    Name = "Yuhao",
                    Surname = "Lin",
                    Nickname = "WhiteStorm",
                    Country = Country.Китай,
                    TeamId = 13
                },
                new Player()
                {
                    Id = 63,
                    Name = "Jing",
                    Surname = "Zhou",
                    Nickname = "TigerStyle",
                    Country = Country.Китай,
                    TeamId = 13
                },
                new Player()
                {
                    Id = 64,
                    Name = "Zhibiao",
                    Surname = "Ye",
                    Nickname = "Obsidian",
                    Country = Country.Китай,
                    TeamId = 13
                },
                new Player()
                {
                    Id = 65,
                    Name = "Zhicheng",
                    Surname = "Zhang",
                    Nickname = "SilentButterfly",
                    Country = Country.Китай,
                    TeamId = 13
                },
                new Player()
                {
                    Id = 66,
                    Name = "Shaohan",
                    Surname = "Yang",
                    Nickname = "PoisonDart",
                    Country = Country.Китай,
                    TeamId = 14
                },
                new Player()
                {
                    Id = 67,
                    Name = "Jiaoyang",
                    Surname = "Zeng",
                    Nickname = "OracleEye",
                    Country = Country.Китай,
                    TeamId = 14
                },
                new Player()
                {
                    Id = 68,
                    Name = "Yangwei",
                    Surname = "Ren",
                    Nickname = "ElderMonk",
                    Country = Country.Китай,
                    TeamId = 14
                },
                new Player()
                {
                    Id = 69,
                    Name = "Jiahan",
                    Surname = "Xiong",
                    Nickname = "PandaWarrior",
                    Country = Country.Китай,
                    TeamId = 14
                },
                new Player()
                {
                    Id = 70,
                    Name = "Cong",
                    Surname = "Ding",
                    Nickname = "ShadowGale",
                    Country = Country.Китай,
                    TeamId = 14
                },
                new Player()
                {
                    Id = 71,
                    Name = "Igor",
                    Surname = "Volkov",
                    Nickname = "SiberianTiger",
                    Country = Country.Россия,
                    TeamId = 15
                },
                new Player()
                {
                    Id = 72,
                    Name = "Amir",
                    Surname = "Al-Farsi",
                    Nickname = "DesertMirage",
                    Country = Country.Иордания,
                    TeamId = 15
                },
                new Player()
                {
                    Id = 73,
                    Name = "Ivan",
                    Surname = "Georgiev",
                    Nickname = "BalkanBear",
                    Country = Country.Болгария,
                    TeamId = 15
                },
                new Player()
                {
                    Id = 74,
                    Name = "Maroun",
                    Surname = "El-Haddad",
                    Nickname = "PhoenixRising",
                    Country = Country.Ливан,
                    TeamId = 15
                },
                new Player()
                {
                    Id = 75,
                    Name = "Kurosh",
                    Surname = "Rahmani",
                    Nickname = "PersianPrince",
                    Country = Country.Германия,
                    TeamId = 15
                },
                new Player()
                {
                    Id = 76,
                    Name = "Somsak",
                    Surname = "Prachum",
                    Nickname = "ThaiTempest",
                    Country = Country.Тайланд,
                    TeamId = 16
                },
                new Player()
                {
                    Id = 77,
                    Name = "Carlos",
                    Surname = "Manalo",
                    Nickname = "IslandFury",
                    Country = Country.Филиппины,
                    TeamId = 16
                },
                new Player()
                {
                    Id = 78,
                    Name = "Ricardo",
                    Surname = "Santos",
                    Nickname = "MonsoonKing",
                    Country = Country.Филиппины,
                    TeamId = 16
                },
                new Player()
                {
                    Id = 79,
                    Name = "Budi",
                    Surname = "Prakoso",
                    Nickname = "SharpBlade",
                    Country = Country.Индонезия,
                    TeamId = 16
                },
                new Player()
                {
                    Id = 80,
                    Name = "Putra",
                    Surname = "Wijaya",
                    Nickname = "BaliStorm",
                    Country = Country.Индонезия,
                    TeamId = 16
                },
                new Player()
                {
                    Id = 81,
                    Name = "Guoliang",
                    Surname = "Huang",
                    Nickname = "JadeFang",
                    Country = Country.Китай,
                    TeamId = 17
                },
                new Player()
                {
                    Id = 82,
                    Name = "Heming",
                    Surname = "Xu",
                    Nickname = "GhostDancer",
                    Country = Country.Китай,
                    TeamId = 17
                },
                new Player()
                {
                    Id = 83,
                    Name = "Sen",
                    Surname = "Hu",
                    Nickname = "MountainHermit",
                    Country = Country.Китай,
                    TeamId = 17
                },
                new Player()
                {
                    Id = 84,
                    Name = "Hao",
                    Surname = "Lin",
                    Nickname = "CelestialGuard",
                    Country = Country.Китай,
                    TeamId = 17
                },
                new Player()
                {
                    Id = 85,
                    Name = "Ziqiang",
                    Surname = "Zhang",
                    Nickname = "DragonTamer",
                    Country = Country.Китай,
                    TeamId = 17
                },
                new Player()
                {
                    Id = 86,
                    Name = "Rizky",
                    Surname = "Pratama",
                    Nickname = "Archipelago",
                    Country = Country.Индонезия,
                    TeamId = 18
                },
                new Player()
                {
                    Id = 87,
                    Name = "Wei Jian",
                    Surname = "Tan",
                    Nickname = "StraitShooter",
                    Country = Country.Малайзия,
                    TeamId = 18
                },
                new Player()
                {
                    Id = 88,
                    Name = "Jian Wen",
                    Surname = "Kang",
                    Nickname = "LionCity",
                    Country = Country.Сингапур,
                    TeamId = 18
                },
                new Player()
                {
                    Id = 89,
                    Name = "Chin Wei",
                    Surname = "Ooi",
                    Nickname = "Mangrove",
                    Country = Country.Сингапур,
                    TeamId = 18
                },
                new Player()
                {
                    Id = 90,
                    Name = "Tri",
                    Surname = "Wibowo",
                    Nickname = "Komodo",
                    Country = Country.Индонезия,
                    TeamId = 18
                },
                new Player()
                {
                    Id = 91,
                    Name = "Artem",
                    Surname = "Shevchenko",
                    Nickname = "Hunter",
                    Country = Country.Белоруссия,
                    TeamId = 19
                },
                new Player()
                {
                    Id = 92,
                    Name = "Rostislav",
                    Surname = "Kovalenko",
                    Nickname = "Searunner",
                    Country = Country.Белоруссия,
                    TeamId = 19
                },
                new Player()
                {
                    Id = 93,
                    Name = "Vladislav",
                    Surname = "Petrov",
                    Nickname = "Taiga",
                    Country = Country.Россия,
                    TeamId = 19
                },
                new Player()
                {
                    Id = 94,
                    Name = "Danil",
                    Surname = "Boyko",
                    Nickname = "Baikal",
                    Country = Country.Россия,
                    TeamId = 19
                },
                new Player()
                {
                    Id = 95,
                    Name = "Semyon",
                    Surname = "Lysov",
                    Nickname = "Volga",
                    Country = Country.Россия,
                    TeamId = 19
                },
                new Player()
                {
                    Id = 96,
                    Name = "Aleksey",
                    Surname = "Morozov",
                    Nickname = "Tundra",
                    Country = Country.Россия,
                    TeamId = 20
                },
                new Player()
                {
                    Id = 97,
                    Name = "Vitaly",
                    Surname = "Kozlov",
                    Nickname = "Vostok",
                    Country = Country.Белоруссия,
                    TeamId = 20
                },
                new Player()
                {
                    Id = 98,
                    Name = "Pavel",
                    Surname = "Orlov",
                    Nickname = "BearPaw",
                    Country = Country.Белоруссия,
                    TeamId = 20
                },
                new Player()
                {
                    Id = 99,
                    Name = "Yevgeny",
                    Surname = "Sokolov",
                    Nickname = "Siberia",
                    Country = Country.Россия,
                    TeamId = 20
                },
                new Player()
                {
                    Id = 100,
                    Name = "Oleg",
                    Surname = "Kravchuk",
                    Nickname = "Steppe",
                    Country = Country.Белоруссия,
                    TeamId = 20
                }
            );
        }
    }
}
