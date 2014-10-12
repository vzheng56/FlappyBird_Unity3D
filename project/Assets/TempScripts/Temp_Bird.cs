using UnityEngine;
using System.Collections;

public class Temp_Bird : MonoBehaviour {

    public Sprite[] BirdBodyTexture_Sprite;

    private bool _isAlive = true;
	// Use this for initialization
	void Start () {
        StartCoroutine(WavingWings());
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    void FixedUpdate()
    {
        if (_isAlive)
        {
            rigidbody2D.AddForce(Vector2.right);

        }
        

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.AddForce(Vector2.up * 100);
            GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 0);
        }

        else
        {
            float angle = Mathf.Lerp(0, 90, (-rigidbody2D.velocity.y) / 3.0f);
            GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, -angle);
        }
    }

    IEnumerator WavingWings()
    {
        int textureIndex = 0;
        while (_isAlive)
        {
            yield return new WaitForSeconds(0.1f);
            if (textureIndex > 2) textureIndex = 0;
            GetComponent<SpriteRenderer>().sprite = BirdBodyTexture_Sprite[textureIndex];
            textureIndex = textureIndex + 1;
 
        }
    }
}
