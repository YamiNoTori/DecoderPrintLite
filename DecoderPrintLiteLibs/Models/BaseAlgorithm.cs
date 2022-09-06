

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
        public string Encoding(string data) { throw new Exception(); }
        public string Decoding(string data) { throw new Exception(); }

    }

}