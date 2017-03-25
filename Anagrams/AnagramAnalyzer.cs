using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO.Compression;

namespace Anagrams
{
    class AnagramAnalyzer
    {
        private Dictionary<string, List<string>> _anagrams;
        private List<string> _words;
        private List<string> _ids;
        private readonly AesCryptoServiceProvider _aes;
        private readonly byte[] _key = new byte[] { 255, 27, 72, 60, 241, 23, 244, 226, 156, 39, 204, 98, 150, 152, 249, 186, 170, 230, 104, 204, 164, 28, 187, 46, 15, 123, 251, 117, 89, 23, 225, 62 };
        private readonly byte[] _iv = new byte[] { 202, 226, 111, 120, 78, 103, 99, 71, 189, 239, 222, 247, 70, 189, 20, 249 };
        public AnagramAnalyzer()
        {
            LoadWords();
            this._anagrams = new Dictionary<string, List<string>>();

            var ids = new List<string>();

            foreach (var s in _words)
            {
                string id = String.Concat(s.OrderBy((c) => c));
                if (!ids.Contains(id))
                    ids.Add(id);
            }

            this._aes = new AesCryptoServiceProvider
            {
                Mode = CipherMode.CBC,
                KeySize = 256,
                BlockSize = 128,
                Key = _key,
                IV = _iv
            };

        }

        private void LoadWords()
        {
            _words = new List<string>();
            //  var sr = new StreamReader("words.txt");
            //  string line = "";
            ///  while ((line = sr.ReadLine()) != null)//File.ReadAllLines
            //  {
            //      if (!words.Contains(line))
            //          words.Add(line);
            //   }
            _words.AddRange(File.ReadAllLines("words.txt"));
        }


        public void Analyze()
        {
            foreach (var word in _words)
            {
                string id = string.Concat(word.OrderBy((c) => c));

                if (!_anagrams.ContainsKey(id))
                    _anagrams.Add(id, new List<string>() { word });
                else
                    _anagrams[id].Add(word);
            }
        }

        public void WriteAll()
        {
            foreach (var a in _anagrams)
            {
                Console.Write("Key: " + a.Key + " | Anagrams: ");
                foreach (var w in _anagrams[a.Key])
                    Console.Write(w);
                Console.WriteLine();
            }

        }


        public List<string> GetAllStrings()
        {
            var sb = new StringBuilder();
            var strings = new List<string>();
            foreach (var a in _anagrams)
            {
                sb.Clear();
                sb.Append("Key: " + a.Key + " | Anagrams: ");
                foreach (var w in _anagrams[a.Key])
                    sb.Append(w);
                strings.Add(sb.ToString());
            }

            return strings;
        }


        public void Serialize(bool encrypt, bool compress)
        {
            Stream stream = File.Open("Anagrams.bin", FileMode.Create);

            if (encrypt)
                stream = new CryptoStream(stream, _aes.CreateEncryptor(_aes.Key, _aes.IV), CryptoStreamMode.Write);

            if (compress)
                stream = new GZipStream(stream, CompressionMode.Compress);



            BinaryFormatter bin = new BinaryFormatter();
            bin.Serialize(stream, _anagrams);
            stream.Close();
        }

        public void Deserialize(bool encrypt, bool compress)
        {
            //var list = Anagrams.ToList();
            Stream stream = File.Open("Anagrams.bin", FileMode.Open);

            if (encrypt)
                stream = new CryptoStream(stream, _aes.CreateDecryptor(_aes.Key, _aes.IV), CryptoStreamMode.Read);
            if (compress)
                stream = new GZipStream(stream, CompressionMode.Decompress);

            BinaryFormatter bin = new BinaryFormatter();

            this._anagrams = bin.Deserialize(stream) as Dictionary<string, List<string>>;

        }
    }
}
