using System.Collections.Generic;
using DecoderPrintLiteLibs.Models.Data;

namespace DecoderPrintLiteLibs.Models
{
    // шифр Цезаря
    public class CaesarAlgorithm<T> : BaseAlgorithm<T>
    {
        public CaesarAlgorithm(T value) : base(value) {}

        // переопределённые методы шифрования/дешифрования
        /// <summary>Шифрование</summary>
        /// <param name="data">Исходное сообщение</param>
        /// <returns>(string) зашифрованное сообщение</returns>
        public override string Encoding(string data)
        {
            if (AlgorithmKey.KeyValue!=null && AlgorithmKey.KeyValue is int key)
            {
                string result = "";
                for (int i = 0; i < data.Length; i++)
                {
                    for (int j = 0; j < AlphabetData.RusUpper.Length; j++)
                    {
                        // если буква верхнего регистра
                        if (data[i]==Char.ToUpper(data[i]))
                        {
                            if (data[i]==AlphabetData.RusUpper[j])
                            { 
                                result += AlphabetData.RusUpper[(j + key) % 33];
                                break;
                            }
                        }
                        else if (data[i]==Char.ToLower(data[i]))
                        {
                            if (data[i]==AlphabetData.RusLower[j])
                            {
                                result += AlphabetData.RusLower[(j + key) % 33];
                                break;
                            }
                        }
                    }
                }
                if (string.IsNullOrEmpty(result))
                    throw new Exception("Ошибка в процессе шифрации данных! Выходное сообщение пусто или null");
                return result;
            }
            else
                throw new Exception("Ошибка типа ключа алгоритма шифрования Цезаря! KeyType: {AlgorithmKey.GetType()}");
            
        }


        /// <summary>Дешифрование</summary>
        /// <param name="data">Зашифрованное сообщение</param>
        /// <returns>(string) расшифрованное сообщение</returns>
        public override string Decoding(string data)
        {
            if (AlgorithmKey.KeyValue!=null && AlgorithmKey.KeyValue is int key)
            {
                string result = "";
                for (int i = 0; i < data.Length; i++)
                {
                    for (int j = 0; j < AlphabetData.RusUpper.Length; j++)
                    {
                        // если буква верхнего регистра
                        if (data[i]==Char.ToUpper(data[i]))
                        {
                            if (data[i]==AlphabetData.RusUpper[j])
                            { 
                                result += AlphabetData.RusUpper[((j - key) + 33) % 33];
                                break;
                            }
                        }
                        else if (data[i]==Char.ToLower(data[i]))
                        {
                            if (data[i]==AlphabetData.RusLower[j])
                            {
                                result += AlphabetData.RusLower[((j - key) + 33) % 33];
                                break;
                            }
                        }
                    }
                }
                if (string.IsNullOrEmpty(result))
                    throw new Exception("Ошибка в процессе дешифрации данных! Исходное сообщение пусто или null");
                return result;
            }
            else
                throw new Exception("Ошибка типа ключа алгоритма шифрования Цезаря! KeyType: {AlgorithmKey.GetType()}");
        }



        public override string ToString()
        {
            return $"\nШифр Цезаря:\n\tInfo - {AlgorithmKey.ToString()}";
        }
    }
}