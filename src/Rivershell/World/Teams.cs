using System.Collections.Generic;

namespace Rivershell.World
{
    public static class Teams
    {
        private static readonly Dictionary<int, Team> _teams = new Dictionary<int, Team>();

        public static void Add(Team team)
        {
            _teams[team.Id] = team;
        }

        public static Team Get(int id)
        {
            return _teams[id];
        }
    }
}