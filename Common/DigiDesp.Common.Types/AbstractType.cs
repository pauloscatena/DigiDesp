namespace DigiDesp.Common.Types
{
    public abstract class AbstractType<T>
    {
        public T Value{get; private set;}
        public bool IsValid(){
            return true;
        }

        public T Get(){
            return Value;
        }

        public void Set(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}