using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    public GUIText ScoreText;
    public static ScoreManager Instance
    {
        get
        {
            if (null == instance)
            {
                instance = FindObjectOfType(typeof(ScoreManager)) as ScoreManager;
                return instance;
            }
            else return instance;
        }
    }
    private static ScoreManager instance;
	// Use this for initialization
	void Start () {
        instance = this;
        _currentScore = 0;
        _hiScore = PlayerPrefs.GetInt(_hiScoreString);
        if (!PlayerPrefs.HasKey(_hiScoreString))
        {
            PlayerPrefs.SetInt(_hiScoreString, _hiScore);
        }
        ScoreText.text = "Score:" + _currentScore + "\nHiScore:" + PlayerPrefs.GetInt(_hiScoreString);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private int _currentScore = 0;
    private int _hiScore = 0;
    private string _hiScoreString = "HiScore";

    private void ShowScore()
    {
        ScoreText.text = "Score:" + _currentScore + "\nHiScore:" + PlayerPrefs.GetInt(_hiScoreString);
    }

    public void AddScore()
    {
        _currentScore++;
        if (_currentScore > _hiScore)
        {
            _hiScore = _currentScore;
            PlayerPrefs.SetInt(_hiScoreString, _hiScore);
        }

        ShowScore();
    }

    void OnDestory()
    {
        PlayerPrefs.SetInt(_hiScoreString, _hiScore);
    }
}
