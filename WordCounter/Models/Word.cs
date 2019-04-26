using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class Word
  {
    private string _Sentence;
    private string _Word;
    private static Dictionary<int, string> _rndSentence = new Dictionary<int, string>()
    {
      {1, "the"},
      {2, "quick"},
      {3, "brown"},
      {4, "fox"},
      {5, "jumped"},
      {6, "over"},
      {7, "the"},
      {8, "lazy"},
      {9, "dog"}
    };

    public Word (string sentence, string word, int intIs)
    {
      if (intIs == 0)
      {
        _Sentence = sentence;
        _Word = word;
      }
      else if (intIs == 1)
      {
        _Sentence = MakeSentence();
        _Word = word;
      }
    }
    public string MakeSentence()
    {
      string contSentence = " ";
      int i = 0;
      while(i < 5)
      {
        Random random = new Random();
        contSentence += _rndSentence[random.Next(1, 5) + i] + " ";
        i++;
      }
      return contSentence;
    }
    public string GetWord()
    {
      return _Word;
    }

    public string GetSentence()
    {

      return _Sentence;
    }

    public bool FindWord()
    {
      char[] inputtedWord = _Word.ToCharArray();
      int i = 0;
      while(i < inputtedWord.Length)
      {
        if(inputtedWord[i] == ' ')
        {
          return false;
        }
        i++;
      }
      if (i == inputtedWord.Length)
      {
        return true;
      }
      else return false;
    }

    public int WordFinder()

    {
      string lowerSentence = _Sentence.ToLower();
      string[] holdWord = lowerSentence.Split(' ');
      string lowerIntIs = _Word.ToLower();
      int wordCount = 0;
      int i = 0;
      while(i < holdWord.Length)
      {
        if(holdWord[i] == lowerIntIs)
        {
          wordCount++;
        }
          i++;
      }

      return wordCount;
    }
  }
}
