namespace Builder
{
    public class SoldierLightInfantry : Soldier
    {
        public override void ChooseWeapon(string choice)
        {
            weapon = choice;
        }

        public override void ChooseTransport(string choice)
        {
            transport = choice;
        }

        public override void SetFocus(string target)
        {
            focus = target;
        }
    }
}