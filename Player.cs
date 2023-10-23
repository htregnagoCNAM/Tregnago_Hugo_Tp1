using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tregnago_Hugo_Tp1
{
    public class Player
    {
        private string FirstName { get; }
        private string LastName { get; }
        private string Alias { get; }
        public string Name { get; private set; }
        public Spaceship Spaceship { get; set; }

        public Player(string firstName, string lastName, string alias)
        {
            FirstName = FormatName(firstName);
            LastName = FormatName(lastName);
            Alias = alias;
            Spaceship = new Spaceship();
            Name = $"{FirstName} {LastName}";
        }
        public static string FormatName(string name)
        {
            if (name.Length == 0)
                return name;
            name = name.ToLower();
            return char.ToUpper(name[0]) + name.Substring(1);
        }

        public override string ToString()
        {
            return $"{Alias} ({Name})";
        }
        public void AssignSpaceship(Spaceship spaceship)
        {
            Spaceship = spaceship;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Player otherPlayer = (Player)obj;
            return Alias == otherPlayer.Alias;
        }

        public override int GetHashCode()
        {
            return Alias.GetHashCode();
        }
    }
}
