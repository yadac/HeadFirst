using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst.Model
{
    public abstract class Character
    {
        public WeaponBehavior WeaponBehavior { get; set; }

        protected Character()
        {
            WeaponBehavior = new KnifeBehavior();
        }

        public void Fight()
        {
            WeaponBehavior.UseWeapon();
        }
    }

    public class King : Character
    {

    }

    public interface WeaponBehavior
    {
        void UseWeapon();
    }

    public class KnifeBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Debug.WriteLine("attack by Knife");
        }
    }
    public class BowAndArrowBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Debug.WriteLine("attack by Arrow");
        }
    }

}
