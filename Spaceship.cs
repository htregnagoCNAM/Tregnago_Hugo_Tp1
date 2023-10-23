using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tregnago_Hugo_Tp1
{
    public class Spaceship
    {
        private const int MAX_WEAPONS = 3;
        private const int DEFAULT_MAX_STRUCTURE = 100;
        private const int DEFAULT_MAX_SHIELD = 100;

        public int MaxStructure {  get; }
        public int MaxShield { get; }
        public int CurrentStructure { get; set; }
        public int CurrentShield { get; set; }
        private List<Weapon> Weapons { get; set; }
        //Currently, all spaceships have the same armory.
        //My idea is that each spaceship will have a limited armory depending on their stats (for balance)
        //Also this armory will depend on the SpaceInvaders general armory, like a draft league
        private Armory SpaceshipArmory { get; set; }
        public bool IsDestroyed
        {
            get
            {
                return CurrentStructure <= 0;
            }
        }
        public Spaceship(int maxStructure, int maxShield)
        {
            MaxStructure = maxStructure;
            MaxShield = maxShield;
            CurrentStructure = maxStructure;
            CurrentShield = maxShield;
            Weapons = new List<Weapon>();
            SpaceshipArmory = new Armory();
        }
        public Spaceship() : this(DEFAULT_MAX_STRUCTURE, DEFAULT_MAX_SHIELD) { }
        public void AddWeapon(Weapon weapon)
        {
            if (!SpaceshipArmory.Weapons.Contains(weapon))
                throw new ArmoryException("This spaceship cannot add a weapon not inside his armory.");
            if (Weapons.Count < MAX_WEAPONS)
                Weapons.Add(weapon);
            else
                Console.WriteLine("You have reached max weapon capacity!");
        }
        public void RemoveWeapon(Weapon weapon)
        {
            bool removed = Weapons.Remove(weapon);
            if (!removed)
                Console.WriteLine("This weapon was not found on the spaceship.");
        }
        public void ClearWeapons()
        {
            Weapons.Clear();
        }
        public void ViewShip()
        {
            Console.WriteLine("*-*-*-*-*-*-*-*");
            Console.WriteLine("Spaceship Information:");
            Console.WriteLine($"Max Structure: {MaxStructure}");
            Console.WriteLine($"Max Shield: {MaxShield}");
            Console.WriteLine($"Current Structure: {CurrentStructure}");
            Console.WriteLine($"Current Shield: {CurrentShield}");
            Console.WriteLine($"Is Destroyed: {IsDestroyed}");
            ViewWeapons();
            Console.WriteLine($"Average damage of all weapons inside the ship: {AverageDamages()}");
            Console.WriteLine("*-*-*-*-*-*-*-*");
        }
        public void ViewWeapons()
        {
            Console.WriteLine("Weapons on the spaceship:");
            if (Weapons.Count == 0)
                Console.WriteLine("Currently none.");
            else
                foreach (var weapon in Weapons)
                    ViewDetailedWeapon(weapon);
        }
        private void ViewDetailedWeapon(Weapon weapon)
        {
            Console.WriteLine($"Name: {weapon.Name}, Type: {weapon.WeaponType}, Damage: {weapon.MinDamage}-{weapon.MaxDamage}");
        }
        public double AverageDamages()
        {
            if (Weapons.Count == 0)
            {
                return 0.0;
            }

            double totalDamage = 0.0;
            foreach (var weapon in Weapons)
            {
                totalDamage += (weapon.MinDamage + weapon.MaxDamage) / 2.0;
            }

            return totalDamage / Weapons.Count;
        }
    }
}
