using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using System;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class Word
  {
    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Word newWord = new Word("test sentence", "testWord", 0);
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }
    [TestMethod]
    public void GetSentence_ChecksGets_Sentence()
    {
      string sent = "test sentence";
      Word newWord = new Word(sent, "placeHolder", 0);
      Assert.AreEqual(sent, newWord.GetSent());
    }
  }
}
    [TestMethod]
        public void GetWord_ChecksGets_Word()
        {
            string testWord = "testWord";
            Word newWord = new Word("place Hold", testWord, 0);
            Assert.AreEqual(testWord, newWord.GetWord());
        }

        [TestMethod]
        public void WordFind_FindsWords_2()
        {
            string testWord = "apple";
            string testSent = "There is an apple in the apple tree, not applejam";
            Word newWord = new Word(testSent, testWord, 0);
            Assert.AreEqual(2, newWord.WordFinder());
        }
        [TestMethod]
        public void FindWord_ChecksForSpace_false()
        {
            string testWord = "applepie";
            string testSent = "Apple is great for apple pie";
            Word newWord = new Word(testSent, testWord, 0);
            Assert.AreEqual(false, newWord.CheckWord());
        }
        [TestMethod]
        public void FindWord_ChecksForSpace_true()
        {
            string testWord = "applepie";
            string testSent = "Apple is great for apple pie";
            Word newWord = new Word(testSent, testWord, 0);
            Assert.AreEqual(true, newWord.CheckWord());

//     }
//   }
// }
