namespace Builder
{
    public class SoldierLightInfantryBuilder : SoldierBuilder
    {
        public SoldierLightInfantryBuilder()
        {
            _soldier = new SoldierLightInfantry();
        }

        public override void Weapon()
        {
            _soldier.ChooseWeapon("Ataque aéreo");
        }

        public override void Transport()
        {
            _soldier.ChooseTransport("Helicóptero de ataque do Exército");
        }

        public override void Focus()
        {
            _soldier.SetFocus("Resposta rápida aérea");
        }
    }
}