using UnityEngine;
using System.Collections;

public class SkyBody : MonoBehaviour {

    public GameObject SkyBody1;
	// Use this for initialization
	void Start () {

        GetComponent<SpriteRenderer>().sprite = SkyBody1.GetComponent<MyBird>().BirdAnimations[1];
    }
	
	// Update is called once per frame
	void Update () {
	}
}
