namespace _Game_.Scripts.Character
{
    public interface ICharacter
    {
        
    }

    public interface IHasDamage
    {
        public void Damage();
    }

    public interface IHasAttack
    {
        public void Attack();
    }
}