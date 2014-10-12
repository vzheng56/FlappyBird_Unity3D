using UnityEngine;
using System.Collections;

public class BackgroundMove : MonoBehaviour {

    public GameObject BackCount_GO;
    private int _backGroundCount = 0;
	// Use this for initialization
	void Start () {
        _backGroundCount = BackCount_GO.transform.childCount/2;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D colider)
    {

        float currentColiderWidth = ((BoxCollider2D)colider).size.x;
        Vector3 position = colider.transform.position;
        position.x += currentColiderWidth * _backGroundCount;
        if (colider.tag == "Sewesr")
        {
            position.y = Random.Range(-0.1968052f, 0.7774522f);
        }
        colider.transform.position = position;
    }
}
