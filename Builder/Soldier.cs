namespace Builder
{
    public abstract class Soldier
    {
        public string weapon { get; protected set; }
        public string transport { get; protected set; }
        public string focus { get; protected set; }

        public abstract void ChooseWeapon(string weapon);
        public abstract void ChooseTransport(string transport);
        public abstract void SetFocus(string focus);
    }
}