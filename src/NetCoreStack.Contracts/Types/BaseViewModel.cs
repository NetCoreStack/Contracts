namespace NetCoreStack.Contracts
{
    public class BaseViewModel
    {
        [PropertyDescriptor(IsIdentity = true)]
        public long? Id { get; set; }

        public ObjectState ObjectState { get; set; }
        
        [PropertyDescriptor(Order = -1)]
        public bool? Active { get; set; }

        public virtual bool IsNew
        {
            get
            {
                if (Id.HasValue && Id.Value > 0)
                    return false;
                return true;
            }
        }

        public BaseViewModel()
        {
            Active = true;
            ObjectState = ObjectState.Unchanged;
        }
    }
}
