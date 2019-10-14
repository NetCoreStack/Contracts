namespace NetCoreStack.Contracts
{
    public class IdModel : ModelBase<long>
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

    public class KeyModel : ModelBase<string>
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

    public abstract class ModelBase<TKey> : IModel<TKey>
    {
        [PropertyDescriptor(IsIdentity = true)]
        public TKey Id { get; set; }

        [PropertyDescriptor(Order = -1)]
        public bool? Active { get; set; }

        public ModelBase()
        {
            Active = true;
        }

        public abstract bool IsNew { get; }
    }
}
