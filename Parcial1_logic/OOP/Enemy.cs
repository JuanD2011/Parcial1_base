using System;
 namespace Parcial1_logic.OOP
 
{
    public class Enemy: Actor
    {
        protected override void Attack(Actor target)
        {
            Console.WriteLine("Atacando...");
        }

        protected override MovementType Move()
        {
            Console.WriteLine("Movimiento Enemy");
            return MovementType.AI;
        }
    }
}