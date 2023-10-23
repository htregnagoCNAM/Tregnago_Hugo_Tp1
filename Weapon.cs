using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tregnago_Hugo_Tp1
{
    public class Weapon
    {
        public string Name { get; }
        public int MinDamage { get; }
        public int MaxDamage { get; }
        public EWeaponType WeaponType { get; }

        public Weapon(string name, int minDamage, int maxDamage, EWeaponType weaponType)
        {
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            WeaponType = weaponType;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Weapon otherWeapon = (Weapon)obj;
            return Name == otherWeapon.Name &&
                MinDamage == otherWeapon.MinDamage &&
                MaxDamage == otherWeapon.MaxDamage &&
                WeaponType == otherWeapon.WeaponType;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
    public enum EWeaponType
    {
        Direct,
        Explosive,
        Guided
    }
}
