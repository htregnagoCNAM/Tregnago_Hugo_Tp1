using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tregnago_Hugo_Tp1
{
    public class SpaceInvaders
    {
        private List<Player> Players;
        private Armory GeneralArmory;
        public SpaceInvaders()
        {
            Players = new List<Player>();
            GeneralArmory = new Armory();
            Init();
        }
        public static void Main()
        {
            SpaceInvaders game = new SpaceInvaders();
            game.DisplayAllPlayers();
            game.GeneralArmory.ViewArmory();
            game.DisplayPlayerDetailedInformations(0);
            game.DisplayPlayerDetailedInformations(1);
            game.DisplayPlayerDetailedInformations(2);
        }
        private void Init()
        {
            Players.Add(new Player("Pierre", "Muller", "p.muller"));
            Players.Add(new Player("Jean", "Frey", "j.frey"));
            Players.Add(new Player("Jacques", "Meyer", "j.meyer"));
            InitPlayer1SpaceShip();
            InitPlayer2SpaceShip();
            InitPlayer3SpaceShip();
        }
        private void InitPlayer1SpaceShip()
        {
            Players[0].Spaceship = new Spaceship(150, 50);
            Players[0].Spaceship.AddWeapon(GeneralArmory.Weapons[2]);
            Players[0].Spaceship.AddWeapon(GeneralArmory.Weapons[5]);
            Players[0].Spaceship.AddWeapon(GeneralArmory.Weapons[7]);
        }
        private void InitPlayer2SpaceShip()
        {
            Players[1].Spaceship = new Spaceship(140, 70);
            Players[1].Spaceship.AddWeapon(GeneralArmory.Weapons[4]);
            Players[1].Spaceship.AddWeapon(GeneralArmory.Weapons[8]);
            Players[1].Spaceship.AddWeapon(GeneralArmory.Weapons[13]);
        }
        private void InitPlayer3SpaceShip()
        {
            Players[2].Spaceship = new Spaceship(200, 0);
            Players[2].Spaceship.AddWeapon(GeneralArmory.Weapons[0]);
            Players[2].Spaceship.AddWeapon(GeneralArmory.Weapons[9]);
            Players[2].Spaceship.AddWeapon(GeneralArmory.Weapons[15]);
        }
        public void DisplayAllPlayers()
        {
            Console.WriteLine("*-*-*-*-*-*-*-*");
            Console.WriteLine("List of all current players:");
            foreach (Player player in Players)
                Console.WriteLine(player.ToString());
            Console.WriteLine("*-*-*-*-*-*-*-*" + Environment.NewLine + Environment.NewLine);
        }
        public void DisplayPlayerDetailedInformations(int index)
        {
            Console.WriteLine("*-*-*-*-*-*-*-*");
            Console.WriteLine($"Player {index+1}: {Players[index].ToString()}");
            Players[index].Spaceship.ViewShip();
            Console.WriteLine("*-*-*-*-*-*-*-*" + Environment.NewLine + Environment.NewLine);
        }
    }
}
