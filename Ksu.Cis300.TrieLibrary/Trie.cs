using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    public class Trie
    {
        private bool EmptyCheck = false;
        private Trie[] chil = new Trie[26];

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool Contains(string s)
        {
            for (int x = 0; x < s.Length; x++)
            {
                string newStr = chil[].Clone; //SOS
                if (chil[] < 'z' && chil[] > 'a') return false;
                if (newStr.Contains(s.Substring(x))) return true;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        public void Add(string s)
        {
            chil[].Concat(s);
            if (chil[] < 'z' && chil[] > 'a')  throw ArgumentException("Character range is lower-case onyl");


        }

        private Exception ArgumentException(string v)
        {
            throw new NotImplementedException();
        }
    }
}
