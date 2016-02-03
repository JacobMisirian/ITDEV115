using System;

namespace Assignment1
{
    /// <summary>
    /// Base ball player.
    /// </summary>
    public class BaseBallPlayer
    {
        /// <summary>
        /// Gets or sets the batting avg.
        /// </summary>
        /// <value>The batting avg.</value>
        public double BattingAvg { get { return battingAvg; } set { battingAvg = value; } }
        private double battingAvg;
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public string FirstName { get { return firstName; } set { firstName = value; } }
        private string firstName;
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName { get { return lastName; } set { lastName = value; } }
        private string lastName;
        /// <summary>
        /// Gets or sets the team.
        /// </summary>
        /// <value>The team.</value>
        public string Team { get { return team; } set { team = value; } }
        private string team;
    }
}

