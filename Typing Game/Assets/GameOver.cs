using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public bool gameOver = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Word"))
        {
            gameOver = true;
            Debug.Log("GAME OVER");
            SceneManager.LoadScene(1);
        }
    }
}
