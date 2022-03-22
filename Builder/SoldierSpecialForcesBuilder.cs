namespace Builder
{
    public class SoldierSpecialForcesBuilder : SoldierBuilder
    {
        public SoldierSpecialForcesBuilder()
        {
            _soldier = new SoldierSpecialForces();
        }

        public override void Weapon()
        {
            _soldier.ChooseWeapon("Fuzil");
        }

        public override void Transport()
        {
            _soldier.ChooseTransport("Carro de operações especiais");
        }

        public override void Focus()
        {
            _soldier.SetFocus("Combate em solo");
        }
    }
}