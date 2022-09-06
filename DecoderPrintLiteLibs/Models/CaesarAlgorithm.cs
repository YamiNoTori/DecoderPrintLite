using System.Collections.Generic;
using DecoderPrintLiteLibs.Models.Data;

namespace DecoderPrintLiteLibs.Models
{
    // шифр Цезаря
    public class CaesarAlgorithm<T> : BaseAlgorithm<T>
    {
        public CaesarAlgorithm(T value) : base(value) {}

        // переопределённые методы шифрования/дешифрования
        public override string Encoding(string data)
        {
            if (AlgorithmKey.GetType()==typeof(int))
            {
                string result = "";
                //List<char> messageBuffers = new(data.Length);
                Dictionary<int, char> messageBuffers = new();
                // проверка исходного сообщения:
                //          1. Каждая буква принадлежит множеству букв русского алфавита и записывается в буфер
                for (int i = 0; i < data.Length; i++)
                {
                    for (int j = 0; j < AlphabetData.RusUpper.Length; j++)
                        if (Char.ToUpper(data[i])==AlphabetData.RusUpper[j])
                        {
                            // GOTO не могу использовать ключ =( 
                            result.Append(AlphabetData.RusUpper[j + AlgorithmKey.KeyValue]);

                            messageBuffers.Add(j, Char.ToUpper(data[i]));
                            break;
                        }

                    


                }



                if (string.IsNullOrEmpty(result))
                    throw new Exception("Ошибка в процессе шифрации данных! Выходное сообщение пусто или null");
                return result;
            }
            else
                throw new Exception("Ошибка типа ключа алгоритма шифрования Цезаря! KeyType: {AlgorithmKey.GetType()}");
        }

        public override string Decoding(string data)
        {
            return base.Decoding(data);
        }



        public override string ToString()
        {
            return $"\nШифр Цезаря:\n\tInfo - {AlgorithmKey.ToString()}";
        }
    }
}