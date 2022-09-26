

namespace DecoderPrintLiteLibs.Models
{
    public abstract class BaseAlgorithm<T>
    {
        ///<summary> Ключ <summary>
        private protected Key<T> AlgorithmKey {get; set;}

        public BaseAlgorithm(T value)
        {
            AlgorithmKey = new Key<T>(value);
        }

        // Методы шифрования/дешифрования данных
        public virtual string Encoding(string data) { throw new NotImplementedException(); }
        public virtual string Decoding(string data) { throw new NotImplementedException(); }


        public override string ToString()
        {
            return $"BaseAlgorithm";
        }

    }

}