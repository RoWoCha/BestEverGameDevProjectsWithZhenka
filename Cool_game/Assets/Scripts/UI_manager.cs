using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class UI_manager : MonoBehaviour
{
    public Text gameText;

    // Start is called before the first frame update
    void Start()
    {
        gameText.text = "Press Space to start the game";
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.singleton.isGameStarted)
            gameText.text = "";
        if (GameManager.singleton.isGameFinished)
            gameText.text = "You're failed! Press R to restart";

    }
}
