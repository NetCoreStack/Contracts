namespace NetCoreStack.Contracts
{
    public static class StringExtensionsOfBase
    {
        public static bool HasValue(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }
    }
}