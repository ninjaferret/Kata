﻿using System;
using NUnit.Framework;

namespace DataMiningTests
{
    [TestFixture]
    public class FootballMiningTests
    {
         [Test]
         public void LowestGoalDifferenceIsWolves()
         {
             Assert.That(FootballMining.GetClubWithLowestGoalDifference(LeagueTable), Is.EqualTo("Sunderland"));
         }

        [Test]
        public void TestExtractVarianceReturnsCorrectValue()
        {
           // Assert.That(FootballMining.ExtractVariance(FootballMining.modSubtract, new string[] {"2.",  "Manchester_U",    "38",    "28",   "5",   "5",    "89",  "-",  "33","89"}, 1, 6, 8 ), Is.EqualTo(new Tuple<string, decimal>("Manchester_U", 56)));
        }

        private const string LeagueTable = @"    1. Manchester_C    38    28   5   5    93  -  29    89
    2. Manchester_U    38    28   5   5    89  -  33    89
    3. Arsenal         38    21  10   7    74  -  49    70
    4. Tottenham       38    20   9   9    66  -  41    69
    5. Newcastle_U     38    19  11   8    56  -  51    65
    6. Chelsea         38    18  10  10    65  -  46    64
    7. Everton         38    15  12  11    50  -  40    56
    8. Liverpool       38    14  14  10    47  -  40    52
    9. Fulham          38    14  14  10    48  -  51    52
   10. West_Brom       38    13  17   8    45  -  52    47
   11. Swansea_City    38    12  15  11    44  -  51    47
   12. Norwich_City    38    12  15  11    52  -  66    47
   13. Sunderland      38    11  15  12    45  -  46    45
   14. Stoke_City      38    11  15  12    36  -  53    45
   15. Wigan_Athletic  38    11  17  10    42  -  62    43
   16. Aston_Villa	   38     7  14  17    37  -  53    38
   17. QPR             38    10  21   7    43  -  66    37
   -------------------------------------------------------
   18. Bolton          38    10  22   6    46  -  77    36
   19. Blackburn       38     8  23   7    48  -  78    31
   20. Wolverhampton   38     5  23  10    40  -  82    25";
    }
}