namespace DecoderPrintLiteLibs.Models
{
    // тип ключа
    public enum KeyType
    {
        IntValue,
        StringValue
    }

    // класс данных о ключе шифрования
    public class Key<T>
    {
        public T KeyValue {get; private set;}
        public Key(T key) { KeyValue = key; }
        public override string ToString()
        {
            return $"KeyData:\n\tType - {KeyValue?.GetType()}\n\tValue - {KeyValue?.ToString()}";
        }
    }
}