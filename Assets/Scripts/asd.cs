using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class asd : MonoBehaviour
{
    private ScoreBoard scoreBoard;
    public Text scene;
    // Start is called before the first frame update
    void Start()
    {
       GameObject obj = GameObject.Find("scoreText");
        scoreBoard = obj.GetComponent<ScoreBoard>();
    }

    // Update is called once per frame
    public void Updateasd()
    {
        scene.text = scoreBoard.gamescore.ToString();
    }
}
