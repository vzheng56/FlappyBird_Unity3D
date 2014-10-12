using UnityEngine;
using System.Collections;

public class MoveBackGround : MonoBehaviour {

    public int SkyBoxCound = 6;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnTriggerEnter2D(Collider2D other)
    {
        Vector3 position = other.transform.position;

        float skyBoxWidth = ((BoxCollider2D)other).size.x;//other.GetComponent<BoxCollider2D>().size.x;

        position.x+=skyBoxWidth * 6;

        other.transform.position = position;
    }
}
