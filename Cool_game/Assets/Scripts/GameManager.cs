using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager singleton = null;

    public bool isGameStarted = false;
    public bool isGameFinished = false;

    // Start is called before the first frame update
    void Start()
    {
        if (singleton == null)
            singleton = this;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && !isGameFinished)
            isGameStarted = true;
        if (isGameFinished)
            Cursor.visible = false;
        if ((isGameFinished) && (Input.GetKeyUp(KeyCode.R)))
            SceneManager.LoadScene(0);
    }

    public void FinishGame()
    {
        isGameFinished = true;
        isGameStarted = false;
    }
}
