using UnityEngine;
using System.Collections;

public class MyBird : MonoBehaviour
{
    //代码的注释 详细
    //完成小鸟的 动画 所用的所有的Sprite
    public Sprite[] BirdAnimations;

    private bool _isAlive = true;
    private bool _isUpFly = false;

    // Use this for initialization

    //
    void Start()    
    {
        StartCoroutine(WavingWings());
    }

    // Update is called once per frame
    void Update()
    {
        if (_isAlive&&Input.GetMouseButtonDown(0))
        {
            LevelManager.Instance.BeginGame();
            UpFly();
        }

        if (!_isAlive)
        {
            GetComponent<SpriteRenderer>().sprite=BirdAnimations[3];
            LevelManager.Instance.ReStartGame();
           // LevelManager.Instance.ExitGame();
        }
    }

    void FixedUpdate()
    {
        rigidbody2D.AddForce(Vector2.right);
        if (_isUpFly)
        {
            rigidbody2D.AddForce(Vector2.up * 100);
            _isUpFly = false;
        }

        if (rigidbody2D.velocity.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            float angle = Mathf.Lerp(0, 90, (-rigidbody2D.velocity.y / 3f));
            transform.rotation = Quaternion.Euler(0, 0, -angle);
        }

    }

    void UpFly()
    {
        _isUpFly = true;
    }

    //协程
    IEnumerator WavingWings()
    {
        int birdAnimIndex = 0;
        while (_isAlive)
        {
            yield return new WaitForSeconds(0.3f);
            if (birdAnimIndex > 2) birdAnimIndex = 0;
           // GetComponent<SpriteRenderer>().sprite = BirdAnimations[birdAnimIndex];
            GetComponent<SpriteRenderer>().sprite=BirdAnimations[birdAnimIndex];
            birdAnimIndex++;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        _isAlive = false;
    }

    void Hello()
    { }
}