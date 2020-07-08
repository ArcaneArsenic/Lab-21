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
        char temp;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool Contains(string s)
        {
            for (int x = 0; x < s.Length; x++)
            {
                temp = Convert.ToChar(chil[x]); //SOS
                if (temp < 'z' && temp > 'a')
                {
                    if (temp.Equals(s.Substring(x))) return true;
                    else { return false; }
                }
                else { return false; }
            }
            return true;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        public void Add(string s)
        {
            while (!chil[0].EmptyCheck)
            {
                chil[0].Add(s);
                if (Convert.ToChar(chil[0]) < 'z' && Convert.ToChar(chil[0]) > 'a') 
                    throw ArgumentException("Character range is lower-case onyl");
            }


        }

        private Exception ArgumentException(string v)
        {
            throw new NotImplementedException();
        }
    }
}
