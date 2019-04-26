using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using System;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTest
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
      string sentence = "test sentence";
      Word newWord = new Word(sentence, "placeHolder", 0);
      Assert.AreEqual(sentence, newWord.GetSentence());
    }

    [TestMethod]
    public void GetWord_ChecksGets_Word()
    {
      string testWord = "testWord";
      Word newWord = new Word("place Holder", testWord, 0);
      Assert.AreEqual(testWord, newWord.GetWord());
    }

    [TestMethod]
    public void WordFind_FindsWords_2()
    {
      string testWord = "apple";
      string testSentence = "There is an apple in the apple tree, not applejam";
      Word newWord = new Word(testSentence, testWord, 0);
      Assert.AreEqual(2, newWord.WordFinder());
    }
    [TestMethod]
    public void FindWord_ChecksForSpace_false()
    {
      string testWord = "apple jam";
      string testSentence = "Apple is great for apple pie";
      Word newWord = new Word(testSentence, testWord, 0);
      Assert.AreEqual(false, newWord.FindWord());
    }
    [TestMethod]
    public void FindWord_ChecksForSpace_true()
    {
      string testWord = "applejam";
      string testSentence = "Apple is great for apple pie";
      Word newWord = new Word(testSentence, testWord, 0);
      Assert.AreEqual(true, newWord.FindWord());
    }
  }
}
