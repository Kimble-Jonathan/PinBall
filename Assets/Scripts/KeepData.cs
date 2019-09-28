using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KeepData : MonoBehaviour
{
    
    private ScoreBoard Score;
    public static string PlayerName;// STATIC so it is preserved between classes
    public static string PlayerName_2;
    public InputField PlayerNameInput;
    public Text showPlayerName;
    public Text highscore;
    public Text score;
    public Text score_3;
    public Text Balls;
    public int number;

    void Start()
    {
        //score_3.text = PlayerPrefs.GetInt(PlayerName_2, 0).ToString();
        showPlayerName.text = PlayerPrefs.GetString(PlayerName,PlayerName);
        highscore.text = PlayerPrefs.GetInt(PlayerName, 0).ToString();
        //score_3.text = PlayerPrefs.GetInt(PlayerName_2, 0).ToString();
        GameObject obj = GameObject.Find("scoreText");
        Score = obj.GetComponent<ScoreBoard>();
        //score_3.text = PlayerPrefs.GetInt(PlayerName_2, 0).ToString();

    }
    // Update is called once per frame
    public void Update()
    {
        number = Score.gamescore;
        score.text = number.ToString();
        
        if (number > PlayerPrefs.GetInt(PlayerName, 0))
        {
            //PlayerPrefs.SetInt(PlayerName_2, number);
          
            PlayerPrefs.SetInt(PlayerName, number);
            highscore.text = number.ToString();
        }
    }
    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
        PlayerName_2 = PlayerNameInput.text;
        PlayerPrefs.SetString(PlayerName,PlayerName);
        PlayerPrefs.SetString(PlayerName_2, PlayerName_2);
    }
}
