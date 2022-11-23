using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordCountLibrary;

namespace WordCountLibraryTests
{
    [TestClass]
    public class WordCountLibraryTestsClass
    {
        /// <summary>
        /// Ввод пустой строки
        /// </summary>
        [TestMethod]
        public void WordCount_TextAndWordEmpty_ReturnedZero()
        {
            //Arrange
            string text = "";
            string word = "";
            int excepted = 0;
            //Act
            int actual = WordCountLibraryClass.WordCount(text, word);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        /// <summary>
        /// Вывод кол-ва повторения слова из текста
        /// </summary>
        [TestMethod]
        public void WordCount_WordEmpty_ReturnedWordCount()
        {
            //Arrange
            string text = "Великолепный день сегодня вышел для этого города, который называют пасмурным городом городом";
            string word = "город";
            int excepted = 3;
            //Act
            int actual = WordCountLibraryClass.WordCount(text, word);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        /// <summary>
        /// Вывод кол-ва повторения слова из текста
        /// </summary>
        [TestMethod]
        public void WordCount_UncorrectWord_ReturnedZero()
        {
            //Arrange
            string text = "Великолепный день сегодня вышел для этого города, который называют пасмурным городом";
            string word = "динечек";
            int excepted = 0;
            //Act
            int actual = WordCountLibraryClass.WordCount(text, word);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
    }
}
