namespace Builder
{
    public class Army
    {
        public void BuildSoldier(SoldierBuilder soldierBuilder)
        {
            soldierBuilder.Weapon();
            soldierBuilder.Transport();
            soldierBuilder.Focus();
        }
    }
}