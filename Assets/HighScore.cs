using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//also used the TEXT fix from working with Kevin on this portion as well


public class HighScore : MonoBehaviour {

    static public int score = 1000;

    void Awake()
    {
        if (PlayerPrefs.HasKey("ApplePickerHigheScore"))
        {
            score = PlayerPrefs.GetInt("ApplePickerHighScore");
        }
        PlayerPrefs.SetInt("ApplePickerHighScore", score);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " + score;

        if(score > PlayerPrefs.GetInt("ApplePickerHighScore"))
        {
            PlayerPrefs.SetInt("ApplePickerHighScore", score);
        }
	}
}
