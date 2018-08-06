namespace Parcial1_logic.OOP
{
    public abstract class Actor: ICharacter
    {
        private float baseAtk;
        private float baseDef;

        public float BaseAtk { get => baseAtk; set => baseAtk = value; }
        public float BaseDef { get => baseDef; set => baseDef = value; }

        protected abstract void Attack(Actor target);
    }
}