using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {

	private static string[] wordList = {"andrewquitmeyer","dennis","get1033","computational","media",
        "art","encyclopedic","participatory","procedural","spatial","machine","robot","hacking","cyber",
    "bitcoin","ethereum","cryptocurrency","digital","privacy","data","algorithms","analytics","security",
    "creative","virtual","augmented","reality","network","social","arduino","coding","games"};

	public static string GetRandomWord ()
	{
		int randomIndex = Random.Range(0, wordList.Length);
		string randomWord = wordList[randomIndex];

		return randomWord;
	}

}
