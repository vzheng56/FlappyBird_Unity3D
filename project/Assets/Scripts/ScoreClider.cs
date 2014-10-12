using UnityEngine;
using System.Collections;

public class ScoreClider : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D colider)
    {
        Debug.Log(colider);
        if (colider.tag == "BirdPlayer")
        {
            ScoreManager.Instance.AddScore();
        }
    }
}
