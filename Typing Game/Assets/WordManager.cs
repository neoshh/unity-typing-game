using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour {
    public int score = 0;

    public List<Word> words;

	public WordSpawner wordSpawner;

	private bool hasActiveWord;
	private Word activeWord;

	public void AddWord ()
	{
		Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
		words.Add(word);
	}

	public void TypeLetter (char letter)
	{
		if (hasActiveWord)
		{
			if (activeWord.GetNextLetter() == letter)
			{
				activeWord.TypeLetter();
			}
		} else
		{
			foreach(Word word in words)
			{
				if (word.GetNextLetter() == letter)
				{
					activeWord = word;
					hasActiveWord = true;
					word.TypeLetter();
					break;
				}
			}
		}

		if (hasActiveWord && activeWord.WordTyped())
		{
            score++;
            Debug.Log(score);
            hasActiveWord = false;
			words.Remove(activeWord);
		}
	}
}
