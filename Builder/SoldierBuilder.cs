namespace Builder
{
    public abstract class SoldierBuilder
    {
        protected Soldier _soldier;

        public Soldier GetSoldier()
        {
            return _soldier;
        }

        public abstract void Weapon();
        public abstract void Transport();
        public abstract void Focus();
    }
}