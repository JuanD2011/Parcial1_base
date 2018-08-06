using System;
namespace Parcial1_logic.OOP

{
    public class NPC: ICharacter
    {
        protected override MovementType Move()
        {
            Console.WriteLine("Movimiento Npc");
            return MovementType.Waypoint;
        }
    }
}