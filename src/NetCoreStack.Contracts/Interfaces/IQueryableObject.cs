﻿namespace NetCoreStack.Contracts
{
    public interface IQueryableObject<TKey>
    {
        TKey Id { get; set; }
    }
}