using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    int a;
    float b;
    double c;
    GameObject player;
    public GameObject player2;
    public float speed;
    float randomX = 0, randomY = 0;

    int counter = 0;
    public int N = 10;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
       
    }

    // Update is called once per frame
    void Update()
    {
        counter += 1;
        if(counter % N == 0)
        {
            randomX = Random.Range(-5, 5);
            randomY = Random.Range(-5, 5);
            Vector3 vector = new Vector3(randomX, randomY, 0);
            player.transform.position = vector;
        }
        
    }
}
