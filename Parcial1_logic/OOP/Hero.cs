using System;
namespace Parcial1_logic.OOP
    
{
    public class Hero: Actor
    {
        public Weapon CurrentWeapon { get; protected set; }
        public Armor CurrentArmor { get; protected set; }

        public float GetCurrentAtk
        {
            get
            {
                float val;
                if (CurrentWeapon == null)
                {
                    val = BaseAtk;
                }
                else
                {
                    if (CurrentWeapon.ParamMod >= 1)
                    {

                        val = BaseAtk + (BaseAtk * 0.99f);
                    }
                    else
                    {
                        val = BaseAtk + (BaseAtk * CurrentWeapon.ParamMod);
                    } 
                }
                return val;
            }

        }

        public float GetCurrentDef
        {
            get
            {
                float val;
                if (CurrentArmor == null)
                {
                    val = BaseDef;
                }
                else
                {
                    if (CurrentArmor.ParamMod >= 1)
                    {

                        val = BaseDef + (BaseDef * 0.99f);
                    }
                    else
                    {
                        val = BaseDef + (BaseDef * CurrentArmor.ParamMod);
                    }
                }
                return val;
            }
        }

        public void ResetEquipment()
        {
            CurrentArmor = null;
            CurrentWeapon = null;
        }

        public void Equip (Gear inputGear)
        {
            if (inputGear is Weapon)
            {
                CurrentWeapon = inputGear as Weapon;
            }
            else
            {
                CurrentArmor = inputGear as Armor;
            }
        }

        protected override MovementType Move()
        {
            Console.WriteLine("Movimiento Hero");
            return MovementType.Input;
        }
        protected override void Attack(Actor target)
        {
            Console.WriteLine("Atacando...");
        }
    }
}