using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;
    public WordManager updateScore;
	
	// Update is called once per frame
	void Update () {
        scoreText.text = updateScore.score.ToString();
	}
}
