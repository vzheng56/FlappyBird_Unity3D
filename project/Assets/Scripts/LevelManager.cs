using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public GameObject StartInfo_GO;

    public static LevelManager Instance
    {
        get
        {
            if (null == instance)
            {
                instance = FindObjectOfType(typeof(LevelManager)) as LevelManager;
                return instance;
            }
            else return instance;
        }
    }
    private static LevelManager instance;
    // Use this for initialization
    void Start()
    {
        instance = this;
        Time.timeScale = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ShowStart()
    {
        StartInfo_GO.SetActive(true);
    }

    public void BeginGame()
    {
        Time.timeScale = 1;
        StartInfo_GO.SetActive(false);
    }

    public void ReStartGame()
    {
        StartCoroutine(ReStartGameForAWhile());
    }

    IEnumerator ReStartGameForAWhile()
    {
        yield return new WaitForSeconds(1);
        Application.LoadLevel(0);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

   
}
