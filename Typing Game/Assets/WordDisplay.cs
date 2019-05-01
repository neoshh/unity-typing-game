using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour {

	public Text text;
	public float fallSpeed = 1f;

    public void SetWord (string word)
	{
		text.text = word;
        text.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1);
    }

	public void RemoveLetter ()
	{
		text.text = text.text.Remove(0, 1);
		text.color = Color.red;
	}

	public void RemoveWord ()
	{
		Destroy(gameObject);
	}

	private void Update()
	{
		transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
	}

}
