using CyberSportsPortal.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CyberSportsPortal.Data.StaticDataCreators
{
    public class ProbabilityOfVictoryCreator
    {
        public static void CreateProbabilityOfVictory(ModelBuilder builder)
        {
            builder.Entity<ProbabilityOfVictory>().HasData(
                new ProbabilityOfVictory()
                {
                    Id = 1,
                    WinnerId  = 1,
                    LoserId = 2,
                    Probability = 10
                },
                new ProbabilityOfVictory()
                {
                    Id = 2,
                    WinnerId = 1,
                    LoserId = 3,
                    Probability = 20
                },
                new ProbabilityOfVictory()
                {
                    Id = 3,
                    WinnerId = 1,
                    LoserId = 4,
                    Probability = 13
                },
                new ProbabilityOfVictory()
                {
                    Id = 4,
                    WinnerId = 1,
                    LoserId = 5,
                    Probability = 18
                },
                new ProbabilityOfVictory()
                {
                    Id = 5,
                    WinnerId = 1,
                    LoserId = 6,
                    Probability = 40
                },
                new ProbabilityOfVictory()
                {
                    Id = 6,
                    WinnerId = 1,
                    LoserId = 7,
                    Probability = 16
                },
                new ProbabilityOfVictory()
                {
                    Id = 7,
                    WinnerId = 1,
                    LoserId = 8,
                    Probability = 23
                },
                new ProbabilityOfVictory()
                {
                    Id = 8,
                    WinnerId = 1,
                    LoserId = 9,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 9,
                    WinnerId = 1,
                    LoserId = 10,
                    Probability = 39
                },
                new ProbabilityOfVictory()
                {
                    Id = 10,
                    WinnerId = 1,
                    LoserId = 11,
                    Probability = 70
                },
                new ProbabilityOfVictory()
                {
                    Id = 11,
                    WinnerId = 1,
                    LoserId = 12,
                    Probability = 40
                },
                new ProbabilityOfVictory()
                {
                    Id = 12,
                    WinnerId = 1,
                    LoserId = 13,
                    Probability = 56
                },
                new ProbabilityOfVictory()
                {
                    Id = 13,
                    WinnerId = 1,
                    LoserId = 14,
                    Probability = 36
                },
                new ProbabilityOfVictory()
                {
                    Id = 14,
                    WinnerId = 1,
                    LoserId = 15,
                    Probability = 34
                },
                new ProbabilityOfVictory()
                {
                    Id = 15,
                    WinnerId = 1,
                    LoserId = 16,
                    Probability = 68
                },
                new ProbabilityOfVictory()
                {
                    Id = 16,
                    WinnerId = 1,
                    LoserId = 17,
                    Probability = 80
                },
                new ProbabilityOfVictory()
                {
                    Id = 17,
                    WinnerId = 1,
                    LoserId = 18,
                    Probability = 90
                },
                new ProbabilityOfVictory()
                {
                    Id = 18,
                    WinnerId = 1,
                    LoserId = 19,
                    Probability = 95
                },
                new ProbabilityOfVictory()
                {
                    Id = 19,
                    WinnerId = 1,
                    LoserId = 20,
                    Probability = 88
                },
                new ProbabilityOfVictory()
                {
                    Id = 20,
                    WinnerId = 2,
                    LoserId = 3,
                    Probability = 70
                },
                new ProbabilityOfVictory()
                {
                    Id = 21,
                    WinnerId = 2,
                    LoserId = 4,
                    Probability = 45
                },
                new ProbabilityOfVictory()
                {
                    Id = 22,
                    WinnerId = 2,
                    LoserId = 5,
                    Probability = 55
                },
                new ProbabilityOfVictory()
                {
                    Id = 23,
                    WinnerId = 2,
                    LoserId = 6,
                    Probability = 80
                },
                new ProbabilityOfVictory()
                {
                    Id = 24,
                    WinnerId = 2,
                    LoserId = 7,
                    Probability = 63
                },
                new ProbabilityOfVictory()
                {
                    Id = 25,
                    WinnerId = 2,
                    LoserId = 8,
                    Probability = 65
                },
                new ProbabilityOfVictory()
                {
                    Id = 26,
                    WinnerId = 2,
                    LoserId = 9,
                    Probability = 73
                },
                new ProbabilityOfVictory()
                {
                    Id = 27,
                    WinnerId = 2,
                    LoserId = 10,
                    Probability = 69
                },
                new ProbabilityOfVictory()
                {
                    Id = 28,
                    WinnerId = 2,
                    LoserId = 11,
                    Probability = 92
                },
                new ProbabilityOfVictory()
                {
                    Id = 29,
                    WinnerId = 2,
                    LoserId = 12,
                    Probability = 78
                },
                new ProbabilityOfVictory()
                {
                    Id = 30,
                    WinnerId = 2,
                    LoserId = 13,
                    Probability = 81
                },
                new ProbabilityOfVictory()
                {
                    Id = 31,
                    WinnerId = 2,
                    LoserId = 14,
                    Probability = 62
                },
                new ProbabilityOfVictory()
                {
                    Id = 32,
                    WinnerId = 2,
                    LoserId = 15,
                    Probability = 76
                },
                new ProbabilityOfVictory()
                {
                    Id = 33,
                    WinnerId = 2,
                    LoserId = 16,
                    Probability = 95
                },
                new ProbabilityOfVictory()
                {
                    Id = 34,
                    WinnerId = 2,
                    LoserId = 17,
                    Probability = 100
                },
                new ProbabilityOfVictory()
                {
                    Id = 35,
                    WinnerId = 2,
                    LoserId = 18,
                    Probability = 100
                },
                new ProbabilityOfVictory()
                {
                    Id = 36,
                    WinnerId = 2,
                    LoserId = 19,
                    Probability = 100
                },
                new ProbabilityOfVictory()
                {
                    Id = 37,
                    WinnerId = 2,
                    LoserId = 20,
                    Probability = 100
                },
                new ProbabilityOfVictory()
                {
                    Id = 38,
                    WinnerId = 3,
                    LoserId = 4,
                    Probability = 33
                },
                new ProbabilityOfVictory()
                {
                    Id = 39,
                    WinnerId = 3,
                    LoserId = 5,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 40,
                    WinnerId = 3,
                    LoserId = 6,
                    Probability = 72
                },
                new ProbabilityOfVictory()
                {
                    Id = 41,
                    WinnerId = 3,
                    LoserId = 7,
                    Probability = 41
                },
                new ProbabilityOfVictory()
                {
                    Id = 42,
                    WinnerId = 3,
                    LoserId = 8,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 43,
                    WinnerId = 3,
                    LoserId = 9,
                    Probability = 64
                },
                new ProbabilityOfVictory()
                {
                    Id = 44,
                    WinnerId = 3,
                    LoserId = 10,
                    Probability = 68
                },
                new ProbabilityOfVictory()
                {
                    Id = 45,
                    WinnerId = 3,
                    LoserId = 11,
                    Probability = 79
                },
                new ProbabilityOfVictory()
                {
                    Id = 46,
                    WinnerId = 3,
                    LoserId = 12,
                    Probability = 56
                },
                new ProbabilityOfVictory()
                {
                    Id = 47,
                    WinnerId = 3,
                    LoserId = 13,
                    Probability = 67
                },
                new ProbabilityOfVictory()
                {
                    Id = 48,
                    WinnerId = 3,
                    LoserId = 14,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 49,
                    WinnerId = 3,
                    LoserId = 15,
                    Probability = 52
                },
                new ProbabilityOfVictory()
                {
                    Id = 50,
                    WinnerId = 3,
                    LoserId = 16,
                    Probability = 76
                },
                new ProbabilityOfVictory()
                {
                    Id = 51,
                    WinnerId = 3,
                    LoserId = 17,
                    Probability = 90
                },
                new ProbabilityOfVictory()
                {
                    Id = 52,
                    WinnerId = 3,
                    LoserId = 18,
                    Probability = 92
                },
                new ProbabilityOfVictory()
                {
                    Id = 53,
                    WinnerId = 3,
                    LoserId = 19,
                    Probability = 88
                },
                new ProbabilityOfVictory()
                {
                    Id = 54,
                    WinnerId = 3,
                    LoserId = 20,
                    Probability = 95
                },
                new ProbabilityOfVictory()
                {
                    Id = 55,
                    WinnerId = 4,
                    LoserId = 5,
                    Probability = 60
                },
                new ProbabilityOfVictory()
                {
                    Id = 56,
                    WinnerId = 4,
                    LoserId = 6,
                    Probability = 80
                },
                new ProbabilityOfVictory()
                {
                    Id = 57,
                    WinnerId = 4,
                    LoserId = 7,
                    Probability = 62
                },
                new ProbabilityOfVictory()
                {
                    Id = 58,
                    WinnerId = 4,
                    LoserId = 8,
                    Probability = 66
                },
                new ProbabilityOfVictory()
                {
                    Id = 59,
                    WinnerId = 4,
                    LoserId = 9,
                    Probability = 72
                },
                new ProbabilityOfVictory()
                {
                    Id = 60,
                    WinnerId = 4,
                    LoserId = 10,
                    Probability = 70
                },
                new ProbabilityOfVictory()
                {
                    Id = 61,
                    WinnerId = 4,
                    LoserId = 11,
                    Probability = 90
                },
                new ProbabilityOfVictory()
                {
                    Id = 62,
                    WinnerId = 4,
                    LoserId = 12,
                    Probability = 72
                },
                new ProbabilityOfVictory()
                {
                    Id = 63,
                    WinnerId = 4,
                    LoserId = 13,
                    Probability = 78
                },
                new ProbabilityOfVictory()
                {
                    Id = 64,
                    WinnerId = 4,
                    LoserId = 14,
                    Probability = 75
                },
                new ProbabilityOfVictory()
                {
                    Id = 65,
                    WinnerId = 4,
                    LoserId = 15,
                    Probability = 54
                },
                new ProbabilityOfVictory()
                {
                    Id = 66,
                    WinnerId = 4,
                    LoserId = 16,
                    Probability = 100
                },
                new ProbabilityOfVictory()
                {
                    Id = 67,
                    WinnerId = 4,
                    LoserId = 17,
                    Probability = 100
                },
                new ProbabilityOfVictory()
                {
                    Id = 68,
                    WinnerId = 4,
                    LoserId = 18,
                    Probability = 100
                },
                new ProbabilityOfVictory()
                {
                    Id = 69,
                    WinnerId = 4,
                    LoserId = 19,
                    Probability = 98
                },
                new ProbabilityOfVictory()
                {
                    Id = 70,
                    WinnerId = 4,
                    LoserId = 20,
                    Probability = 95
                },
                new ProbabilityOfVictory()
                {
                    Id = 71,
                    WinnerId = 5,
                    LoserId = 6,
                    Probability = 75
                },
                new ProbabilityOfVictory()
                {
                    Id = 72,
                    WinnerId = 5,
                    LoserId = 7,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 73,
                    WinnerId = 5,
                    LoserId = 8,
                    Probability = 55
                },
                new ProbabilityOfVictory()
                {
                    Id = 74,
                    WinnerId = 5,
                    LoserId = 9,
                    Probability = 63
                },
                new ProbabilityOfVictory()
                {
                    Id = 75,
                    WinnerId = 5,
                    LoserId = 10,
                    Probability = 71
                },
                new ProbabilityOfVictory()
                {
                    Id = 76,
                    WinnerId = 5,
                    LoserId = 11,
                    Probability = 80
                },
                new ProbabilityOfVictory()
                {
                    Id = 77,
                    WinnerId = 5,
                    LoserId = 12,
                    Probability = 61
                },
                new ProbabilityOfVictory()
                {
                    Id = 78,
                    WinnerId = 5,
                    LoserId = 13,
                    Probability = 67
                },
                new ProbabilityOfVictory()
                {
                    Id = 79,
                    WinnerId = 5,
                    LoserId = 14,
                    Probability = 55
                },
                new ProbabilityOfVictory()
                {
                    Id = 80,
                    WinnerId = 5,
                    LoserId = 15,
                    Probability = 53
                },
                new ProbabilityOfVictory()
                {
                    Id = 81,
                    WinnerId = 5,
                    LoserId = 16,
                    Probability = 87
                },
                new ProbabilityOfVictory()
                {
                    Id = 82,
                    WinnerId = 5,
                    LoserId = 17,
                    Probability = 94
                },
                new ProbabilityOfVictory()
                {
                    Id = 83,
                    WinnerId = 5,
                    LoserId = 18,
                    Probability = 100
                },
                new ProbabilityOfVictory()
                {
                    Id = 84,
                    WinnerId = 5,
                    LoserId = 19,
                    Probability = 91
                },
                new ProbabilityOfVictory()
                {
                    Id = 85,
                    WinnerId = 5,
                    LoserId = 20,
                    Probability = 90
                },
                new ProbabilityOfVictory()
                {
                    Id = 86,
                    WinnerId = 6,
                    LoserId = 7,
                    Probability = 34
                },
                new ProbabilityOfVictory()
                {
                    Id = 87,
                    WinnerId = 6,
                    LoserId = 8,
                    Probability = 35
                },
                new ProbabilityOfVictory()
                {
                    Id = 88,
                    WinnerId = 6,
                    LoserId = 9,
                    Probability = 49
                },
                new ProbabilityOfVictory()
                {
                    Id = 89,
                    WinnerId = 6,
                    LoserId = 10,
                    Probability = 41
                },
                new ProbabilityOfVictory()
                {
                    Id = 90,
                    WinnerId = 6,
                    LoserId = 11,
                    Probability = 60
                },
                new ProbabilityOfVictory()
                {
                    Id = 91,
                    WinnerId = 6,
                    LoserId = 12,
                    Probability = 35
                },
                new ProbabilityOfVictory()
                {
                    Id = 92,
                    WinnerId = 6,
                    LoserId = 13,
                    Probability = 47
                },
                new ProbabilityOfVictory()
                {
                    Id = 93,
                    WinnerId = 6,
                    LoserId = 14,
                    Probability = 39
                },
                new ProbabilityOfVictory()
                {
                    Id = 94,
                    WinnerId = 6,
                    LoserId = 15,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 95,
                    WinnerId = 6,
                    LoserId = 16,
                    Probability = 66
                },
                new ProbabilityOfVictory()
                {
                    Id = 96,
                    WinnerId = 6,
                    LoserId = 17,
                    Probability = 75
                },
                new ProbabilityOfVictory()
                {
                    Id = 97,
                    WinnerId = 6,
                    LoserId = 18,
                    Probability = 80
                },
                new ProbabilityOfVictory()
                {
                    Id = 98,
                    WinnerId = 6,
                    LoserId = 19,
                    Probability = 78
                },
                new ProbabilityOfVictory()
                {
                    Id = 99,
                    WinnerId = 6,
                    LoserId = 20,
                    Probability = 79
                },
                new ProbabilityOfVictory()
                {
                    Id = 100,
                    WinnerId = 7,
                    LoserId = 8,
                    Probability = 60
                },
                new ProbabilityOfVictory()
                {
                    Id = 101,
                    WinnerId = 7,
                    LoserId = 9,
                    Probability = 68
                },
                new ProbabilityOfVictory()
                {
                    Id = 102,
                    WinnerId = 7,
                    LoserId = 10,
                    Probability = 65
                },
                new ProbabilityOfVictory()
                {
                    Id = 103,
                    WinnerId = 7,
                    LoserId = 11,
                    Probability = 80
                },
                new ProbabilityOfVictory()
                {
                    Id = 104,
                    WinnerId = 7,
                    LoserId = 12,
                    Probability = 73
                },
                new ProbabilityOfVictory()
                {
                    Id = 105,
                    WinnerId = 7,
                    LoserId = 13,
                    Probability = 82
                },
                new ProbabilityOfVictory()
                {
                    Id = 106,
                    WinnerId = 7,
                    LoserId = 14,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 107,
                    WinnerId = 7,
                    LoserId = 15,
                    Probability = 55
                },
                new ProbabilityOfVictory()
                {
                    Id = 108,
                    WinnerId = 7,
                    LoserId = 16,
                    Probability = 87
                },
                new ProbabilityOfVictory()
                {
                    Id = 109,
                    WinnerId = 7,
                    LoserId = 17,
                    Probability = 91
                },
                new ProbabilityOfVictory()
                {
                    Id = 110,
                    WinnerId = 7,
                    LoserId = 18,
                    Probability = 93
                },
                new ProbabilityOfVictory()
                {
                    Id = 111,
                    WinnerId = 7,
                    LoserId = 19,
                    Probability = 87
                },
                new ProbabilityOfVictory()
                {
                    Id = 112,
                    WinnerId = 7,
                    LoserId = 20,
                    Probability = 90
                },
                new ProbabilityOfVictory()
                {
                    Id = 113,
                    WinnerId = 8,
                    LoserId = 9,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 114,
                    WinnerId = 8,
                    LoserId = 10,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 115,
                    WinnerId = 8,
                    LoserId = 11,
                    Probability = 70
                },
                new ProbabilityOfVictory()
                {
                    Id = 116,
                    WinnerId = 8,
                    LoserId = 12,
                    Probability = 67
                },
                new ProbabilityOfVictory()
                {
                    Id = 117,
                    WinnerId = 8,
                    LoserId = 13,
                    Probability = 55
                },
                new ProbabilityOfVictory()
                {
                    Id = 118,
                    WinnerId = 8,
                    LoserId = 14,
                    Probability = 45
                },
                new ProbabilityOfVictory()
                {
                    Id = 119,
                    WinnerId = 8,
                    LoserId = 15,
                    Probability = 66
                },
                new ProbabilityOfVictory()
                {
                    Id = 120,
                    WinnerId = 8,
                    LoserId = 16,
                    Probability = 80
                },
                new ProbabilityOfVictory()
                {
                    Id = 121,
                    WinnerId = 8,
                    LoserId = 17,
                    Probability = 100
                },
                new ProbabilityOfVictory()
                {
                    Id = 122,
                    WinnerId = 8,
                    LoserId = 18,
                    Probability = 100
                },
                new ProbabilityOfVictory()
                {
                    Id = 123,
                    WinnerId = 8,
                    LoserId = 19,
                    Probability = 83
                },
                new ProbabilityOfVictory()
                {
                    Id = 124,
                    WinnerId = 8,
                    LoserId = 20,
                    Probability = 90
                },
                new ProbabilityOfVictory()
                {
                    Id = 125,
                    WinnerId = 9,
                    LoserId = 10,
                    Probability = 35
                },
                new ProbabilityOfVictory()
                {
                    Id = 126,
                    WinnerId = 9,
                    LoserId = 11,
                    Probability = 75
                },
                new ProbabilityOfVictory()
                {
                    Id = 127,
                    WinnerId = 9,
                    LoserId = 12,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 128,
                    WinnerId = 9,
                    LoserId = 13,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 129,
                    WinnerId = 9,
                    LoserId = 14,
                    Probability = 45
                },
                new ProbabilityOfVictory()
                {
                    Id = 130,
                    WinnerId = 9,
                    LoserId = 15,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 131,
                    WinnerId = 9,
                    LoserId = 16,
                    Probability = 71
                },
                new ProbabilityOfVictory()
                {
                    Id = 132,
                    WinnerId = 9,
                    LoserId = 17,
                    Probability = 89
                },
                new ProbabilityOfVictory()
                {
                    Id = 133,
                    WinnerId = 9,
                    LoserId = 18,
                    Probability = 93
                },
                new ProbabilityOfVictory()
                {
                    Id = 134,
                    WinnerId = 9,
                    LoserId = 19,
                    Probability = 67
                },
                new ProbabilityOfVictory()
                {
                    Id = 135,
                    WinnerId = 9,
                    LoserId = 20,
                    Probability = 80
                },
                new ProbabilityOfVictory()
                {
                    Id = 136,
                    WinnerId = 10,
                    LoserId = 11,
                    Probability = 89
                },
                new ProbabilityOfVictory()
                {
                    Id = 137,
                    WinnerId = 10,
                    LoserId = 12,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 138,
                    WinnerId = 10,
                    LoserId = 13,
                    Probability = 61
                },
                new ProbabilityOfVictory()
                {
                    Id = 139,
                    WinnerId = 10,
                    LoserId = 14,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 140,
                    WinnerId = 10,
                    LoserId = 15,
                    Probability = 40
                },
                new ProbabilityOfVictory()
                {
                    Id = 141,
                    WinnerId = 10,
                    LoserId = 16,
                    Probability = 95
                },
                new ProbabilityOfVictory()
                {
                    Id = 142,
                    WinnerId = 10,
                    LoserId = 17,
                    Probability = 89
                },
                new ProbabilityOfVictory()
                {
                    Id = 143,
                    WinnerId = 10,
                    LoserId = 18,
                    Probability = 92
                },
                new ProbabilityOfVictory()
                {
                    Id = 144,
                    WinnerId = 10,
                    LoserId = 19,
                    Probability = 85
                },
                new ProbabilityOfVictory()
                {
                    Id = 145,
                    WinnerId = 10,
                    LoserId = 20,
                    Probability = 88
                },
                new ProbabilityOfVictory()
                {
                    Id = 146,
                    WinnerId = 11,
                    LoserId = 12,
                    Probability = 30
                },
                new ProbabilityOfVictory()
                {
                    Id = 147,
                    WinnerId = 11,
                    LoserId = 13,
                    Probability = 40
                },
                new ProbabilityOfVictory()
                {
                    Id = 148,
                    WinnerId = 11,
                    LoserId = 14,
                    Probability = 25
                },
                new ProbabilityOfVictory()
                {
                    Id = 149,
                    WinnerId = 11,
                    LoserId = 15,
                    Probability = 40
                },
                new ProbabilityOfVictory()
                {
                    Id = 150,
                    WinnerId = 11,
                    LoserId = 16,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 151,
                    WinnerId = 11,
                    LoserId = 17,
                    Probability = 75
                },
                new ProbabilityOfVictory()
                {
                    Id = 152,
                    WinnerId = 11,
                    LoserId = 18,
                    Probability = 65
                },
                new ProbabilityOfVictory()
                {
                    Id = 153,
                    WinnerId = 11,
                    LoserId = 19,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 154,
                    WinnerId = 11,
                    LoserId = 20,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 155,
                    WinnerId = 12,
                    LoserId = 13,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 156,
                    WinnerId = 12,
                    LoserId = 14,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 157,
                    WinnerId = 12,
                    LoserId = 15,
                    Probability = 35
                },
                new ProbabilityOfVictory()
                {
                    Id = 158,
                    WinnerId = 12,
                    LoserId = 16,
                    Probability = 70
                },
                new ProbabilityOfVictory()
                {
                    Id = 159,
                    WinnerId = 12,
                    LoserId = 17,
                    Probability = 75
                },
                new ProbabilityOfVictory()
                {
                    Id = 160,
                    WinnerId = 12,
                    LoserId = 18,
                    Probability = 65
                },
                new ProbabilityOfVictory()
                {
                    Id = 161,
                    WinnerId = 12,
                    LoserId = 19,
                    Probability = 80
                },
                new ProbabilityOfVictory()
                {
                    Id = 162,
                    WinnerId = 12,
                    LoserId = 20,
                    Probability = 90
                },
                new ProbabilityOfVictory()
                {
                    Id = 163,
                    WinnerId = 13,
                    LoserId = 14,
                    Probability = 39
                },
                new ProbabilityOfVictory()
                {
                    Id = 164,
                    WinnerId = 13,
                    LoserId = 15,
                    Probability = 43
                },
                new ProbabilityOfVictory()
                {
                    Id = 165,
                    WinnerId = 13,
                    LoserId = 16,
                    Probability = 54
                },
                new ProbabilityOfVictory()
                {
                    Id = 166,
                    WinnerId = 13,
                    LoserId = 17,
                    Probability = 78
                },
                new ProbabilityOfVictory()
                {
                    Id = 167,
                    WinnerId = 13,
                    LoserId = 18,
                    Probability = 69
                },
                new ProbabilityOfVictory()
                {
                    Id = 168,
                    WinnerId = 13,
                    LoserId = 19,
                    Probability = 70
                },
                new ProbabilityOfVictory()
                {
                    Id = 169,
                    WinnerId = 13,
                    LoserId = 20,
                    Probability = 78
                },
                new ProbabilityOfVictory()
                {
                    Id = 170,
                    WinnerId = 14,
                    LoserId = 15,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 171,
                    WinnerId = 14,
                    LoserId = 16,
                    Probability = 78
                },
                new ProbabilityOfVictory()
                {
                    Id = 172,
                    WinnerId = 14,
                    LoserId = 17,
                    Probability = 76
                },
                new ProbabilityOfVictory()
                {
                    Id = 173,
                    WinnerId = 14,
                    LoserId = 18,
                    Probability = 80
                },
                new ProbabilityOfVictory()
                {
                    Id = 174,
                    WinnerId = 14,
                    LoserId = 19,
                    Probability = 75
                },
                new ProbabilityOfVictory()
                {
                    Id = 175,
                    WinnerId = 14,
                    LoserId = 20,
                    Probability = 73
                },
                new ProbabilityOfVictory()
                {
                    Id = 176,
                    WinnerId = 15,
                    LoserId = 16,
                    Probability = 88
                },
                new ProbabilityOfVictory()
                {
                    Id = 177,
                    WinnerId = 15,
                    LoserId = 17,
                    Probability = 90
                },
                new ProbabilityOfVictory()
                {
                    Id = 178,
                    WinnerId = 15,
                    LoserId = 18,
                    Probability = 100
                },
                new ProbabilityOfVictory()
                {
                    Id = 179,
                    WinnerId = 15,
                    LoserId = 19,
                    Probability = 92
                },
                new ProbabilityOfVictory()
                {
                    Id = 180,
                    WinnerId = 15,
                    LoserId = 20,
                    Probability = 89
                },
                new ProbabilityOfVictory()
                {
                    Id = 181,
                    WinnerId = 16,
                    LoserId = 17,
                    Probability = 63
                },
                new ProbabilityOfVictory()
                {
                    Id = 182,
                    WinnerId = 16,
                    LoserId = 18,
                    Probability = 65
                },
                new ProbabilityOfVictory()
                {
                    Id = 183,
                    WinnerId = 16,
                    LoserId = 19,
                    Probability = 52
                },
                new ProbabilityOfVictory()
                {
                    Id = 184,
                    WinnerId = 16,
                    LoserId = 20,
                    Probability = 58
                },
                new ProbabilityOfVictory()
                {
                    Id = 185,
                    WinnerId = 17,
                    LoserId = 18,
                    Probability = 35
                },
                new ProbabilityOfVictory()
                {
                    Id = 186,
                    WinnerId = 17,
                    LoserId = 19,
                    Probability = 50
                },
                new ProbabilityOfVictory()
                {
                    Id = 187,
                    WinnerId = 17,
                    LoserId = 20,
                    Probability = 55
                },
                new ProbabilityOfVictory()
                {
                    Id = 188,
                    WinnerId = 18,
                    LoserId = 19,
                    Probability = 45
                },
                new ProbabilityOfVictory()
                {
                    Id = 189,
                    WinnerId = 18,
                    LoserId = 20,
                    Probability = 55
                },
                new ProbabilityOfVictory()
                {
                    Id = 190,
                    WinnerId = 19,
                    LoserId = 20,
                    Probability = 50
                }
            );
        }
    }
}