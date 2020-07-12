using System;
using System.Collections.Generic;
using System.Text;

namespace P05.FootballTeamGenerator.Common
{
   public static class ExeptionMessages
    {
        public static string InvalidStatMessage =
            "{0} should be between {1} and {2}";

        public static string EmptyName = "A name should not be empty.";

        public static string RemovingMIssingPlayer =
            "Player {0} is not in {1} team.";

        public static string MissingTeam =
            "Team {0} does not exist.";

    }
}
