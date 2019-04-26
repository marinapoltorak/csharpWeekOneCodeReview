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
      Word newWord = new Word();
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }
    [TestMethod]
    public void GetSentence_ChecksGets_Sentence()
    {
      string sent = "test sentence";
      Word newWord = new Word(sent);
      Assert.AreEqual(sent, newWord.GetSent());
    }
  }
}
    // [TestMethod]
    //     public void GetWord_ChecksGets_Word()
    //     {
    //         string testWord = "testWord";
    //         Word newWord = new Word("place Hold", testWord);
    //         Assert.AreEqual(testWord, newWord.GetWord());
    //     }
    //
    //     [TestMethod]
    //     public void WordFind_FindsWords_2()
    //     {
    //         string testWord = "apple";
    //         string testSent = "There is an apple in the apple tree, not applejam";
    //         Word newWord = new Word(testSent, testWord);
    //         Assert.AreEqual(2, newWord.WordFinder());

    // [TestMethod]
    // public void SetDescription_SetDescription_String()
    // {
    //   string description = "One apple on the apple tree";
    //   RepeatCounter newRepeatCounter = new RepeatCounter(description);
    //   string updatedDescription = "Just pears on the apple tree";
    //   newRepeatCounter.SetDescription(updatedDescription);
    //   string result = newRepeatCounter.GetDescription();
    //   Assert.AreEqual(updatedDescription, result);
    // }
    // [TestMethod]
    // public void GetAll_ReturnsEmptyList_RepeatCounterList()
    // {
    //   List<RepeatCounter> newList = new List<RepeatCounter> { };
    //   List<RepeatCounter> result = RepeatCounter.GetAll();
    //   CollectionAssert.AreEqual(newList, result);
//     }
//   }
// }
