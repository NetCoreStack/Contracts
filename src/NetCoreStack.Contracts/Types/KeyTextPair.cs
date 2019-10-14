namespace NetCoreStack.Contracts
{
    public class KeyTextPair : KeyModel
    {
        public string Parent { get; set; }
        public bool Disabled { get; set; }
        public string Text { get; set; }
    }
}
