namespace NetCoreStack.Contracts
{
    public class CollectionModel : CollectionModelBase<long>
    {
        public override bool IsNew
        {
            get
            {
                if (Id > 0)
                    return false;

                return true;
            }
        }
    }

    public class CollectionModelBson : CollectionModelBase<string>
    {
        public override bool IsNew
        {
            get
            {
                if (!string.IsNullOrEmpty(Id))
                    return false;

                return true;
            }
        }
    }

    public abstract class CollectionModelBase<TKey> : ICollectionModel<TKey>
    {
        [PropertyDescriptor(IsIdentity = true)]
        public TKey Id { get; set; }

        public ObjectState ObjectState { get; set; }

        [PropertyDescriptor(Order = -1)]
        public bool? Active { get; set; }

        public CollectionModelBase()
        {
            Active = true;
            ObjectState = ObjectState.Unchanged;
        }

        public abstract bool IsNew { get; }
    }
}
