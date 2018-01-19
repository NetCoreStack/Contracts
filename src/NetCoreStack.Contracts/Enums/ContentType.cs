namespace NetCoreStack.Contracts
{
    /// <summary>
    /// Http request body content type
    /// </summary>
    public enum ContentType
    {
        ModelAware = 0,
        Json = 1,
        MultipartFormData = 2,
        FormUrlEncoded = 3,
        Xml = 4
    }
}