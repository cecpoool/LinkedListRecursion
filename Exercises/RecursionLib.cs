using System;
using System.Collections.Generic;

namespace Exercises
{
    public class RecursionLib {

        public int FactorialRec(int num, int ans = 1) {

            if (num == 0) {
                return ans;
            }

           return num*FactorialRec(num-1);
        }

        public List<int> CountRec(int num, List<int> numsList) {

            if(num == 0) return numsList;

            numsList.Insert(0, num);

            return CountRec(--num, numsList);
        }

        public long ExponentialRec(int num, int pow, long ans = 1) {
            if (pow == 0) return ans;

            ans = ans * num;

            return ExponentialRec(num, --pow, ans);
        }

        /// <summary>
        /// Returns word (string) in reverse order.  Treats all characters the same.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="revWord"></param>
        /// <returns></returns>    
        public string WordReverseRec(string word, string revWord = "") {

            if (word.Length > 0)
                return word[word.Length - 1] + WordReverseRec(word.Substring(0, word.Length - 1));
            else
                word = revWord;
                return revWord;

        }



    }
}
