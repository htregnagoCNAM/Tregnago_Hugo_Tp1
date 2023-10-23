using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tregnago_Hugo_Tp1
{
    public class Armory
    {
        public List<Weapon> Weapons { get; set; }

        public Armory()
        {
            Weapons = new List<Weapon>();
            Init();
        }

        private void Init()
        {
            //Based on Worms weapons
            Weapons.Add(new Weapon("Bazooka", 20, 40, EWeaponType.Direct));
            Weapons.Add(new Weapon("Shotgun", 15, 30, EWeaponType.Direct));
            Weapons.Add(new Weapon("Uzi", 10, 20, EWeaponType.Direct));
            Weapons.Add(new Weapon("Grenade", 30, 50, EWeaponType.Explosive));
            Weapons.Add(new Weapon("Dynamite", 40, 60, EWeaponType.Explosive));
            Weapons.Add(new Weapon("Holy Hand Grenade", 50, 80, EWeaponType.Explosive));
            Weapons.Add(new Weapon("Homing Missile", 35, 60, EWeaponType.Guided));
            Weapons.Add(new Weapon("Air Strike", 40, 70, EWeaponType.Guided));
            Weapons.Add(new Weapon("Sheep Launcher", 25, 40, EWeaponType.Guided));
            Weapons.Add(new Weapon("Banana Bomb", 35, 70, EWeaponType.Explosive));
            Weapons.Add(new Weapon("Minigun", 10, 15, EWeaponType.Direct));
            Weapons.Add(new Weapon("Baseball Bat", 15, 25, EWeaponType.Direct));
            Weapons.Add(new Weapon("Handgun", 5, 10, EWeaponType.Direct));
            Weapons.Add(new Weapon("Cluster Bomb", 30, 50, EWeaponType.Explosive));
            Weapons.Add(new Weapon("Old Lady", 60, 80, EWeaponType.Explosive));
            Weapons.Add(new Weapon("Super Sheep", 40, 70, EWeaponType.Guided));
            Weapons.Add(new Weapon("Bunker Buster", 25, 40, EWeaponType.Guided));
            Weapons.Add(new Weapon("Concrete Donkey", 70, 100, EWeaponType.Explosive));
        }

        public void ViewArmory()
        {
            Console.WriteLine("*-*-*-*-*-*-*-*");
            Console.WriteLine("Detailed list of armory weapons:");
            foreach (var weapon in Weapons)
            {
                ViewDetailedWeapon(weapon);
            }
            Console.WriteLine("*-*-*-*-*-*-*-*" + Environment.NewLine + Environment.NewLine);
        }
        public void ViewDirectWeapons()
        {
            Console.WriteLine("*-*-*-*-*-*-*-*");
            Console.WriteLine("Detailed list of armory direct weapons:");
            foreach (var weapon in Weapons)
            {
                if(weapon.WeaponType == EWeaponType.Direct)
                    ViewDetailedWeapon(weapon);
            }
            Console.WriteLine("*-*-*-*-*-*-*-*");
        }
        public void ViewExplosiveWeapons()
        {
            Console.WriteLine("*-*-*-*-*-*-*-*");
            Console.WriteLine("Detailed list of armory explosive weapons:");
            foreach (var weapon in Weapons)
            {
                if (weapon.WeaponType == EWeaponType.Explosive)
                    ViewDetailedWeapon(weapon);
            }
            Console.WriteLine("*-*-*-*-*-*-*-*");
        }
        public void ViewGuidedWeapons()
        {
            Console.WriteLine("*-*-*-*-*-*-*-*");
            Console.WriteLine("Detailed list of armory guided weapons:");
            foreach (var weapon in Weapons)
            {
                if (weapon.WeaponType == EWeaponType.Guided)
                    ViewDetailedWeapon(weapon);
            }
            Console.WriteLine("*-*-*-*-*-*-*-*");
        }
        private void ViewDetailedWeapon(Weapon weapon)
        {
            Console.WriteLine($"Name: {weapon.Name}, Type: {weapon.WeaponType}, Damage: {weapon.MinDamage}-{weapon.MaxDamage}");
        }
    }
}
