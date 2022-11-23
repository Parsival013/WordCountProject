using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCountLibrary
{
    public class WordCountLibraryClass
    {
        /// <summary>
        /// Возвращение числа повторяющегося слова
        /// </summary>
        /// <param name="textString">
        /// Строка, в которую может входить слово
        /// </param>
        /// <param name="word">
        /// Cлово, которое мы задаем в фильтре
        /// </param>
        /// <returns>
        /// Возвращает сколько раз повторяется то или иное слово
        /// </returns>
        public static int WordCount(string textString, string word)
        {
            if (textString == String.Empty || word == String.Empty)
            {
                return 0;
            }
            textString = textString.ToLower();
            int count = 0;
            var text = textString.Split(' ');
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Contains(word.ToLower()))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
