﻿namespace NetCoreStack.Contracts
{
    public class IdTextPair : IdModel
    {
        public string Parent { get; set; }
        public bool Disabled { get; set; }
        public string Text { get; set; }
    }
}
