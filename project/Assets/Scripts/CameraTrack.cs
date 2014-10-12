using UnityEngine;
using System.Collections;

public class CameraTrack : MonoBehaviour {

    public Transform Player_Trans;

    public float Offset_X = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 position = transform.position;
        position.x = Player_Trans.position.x + Offset_X;
        transform.position = position;

	}
}
