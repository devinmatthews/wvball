using System;
using System.Collections.Generic;

namespace WVB.Classes
{
    public class Game
    {
        public int ID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
    }

    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Participant> Members { get; set; }
        public int Score { get; set; }
    }

    public class Participant
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ParticipantType Type { get; set; }
    }
}
