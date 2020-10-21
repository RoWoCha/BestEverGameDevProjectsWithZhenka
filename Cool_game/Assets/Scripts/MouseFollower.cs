using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseFollower : MonoBehaviour
{
    public float divisor;
    public float distEat;
    GameObject player;
    public Sprite startSprite;
    public Sprite deadSprite;

    SpriteRenderer mySpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        mySpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        mySpriteRenderer.sprite = startSprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.singleton.isGameStarted)
            Follow();
    }

    void Follow()
    {
        Vector3 mouse_pose = Input.mousePosition;
        Vector3 adjusted_pose = Camera.main.ScreenToWorldPoint(mouse_pose);
        adjusted_pose.z = 0f;

        transform.position += (-transform.position + adjusted_pose) / divisor;

        if((adjusted_pose-transform.position).magnitude < distEat)
        {
            mySpriteRenderer.sprite = deadSprite;
            GameManager.singleton.FinishGame();
        }
    }
}
