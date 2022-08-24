using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20f;
    public float lowerBound = -10f;
    public float rightBound = 20f;
    public float leftBound = -20f;

    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z >= topBound )
        {
            Destroy(gameObject);
            
        }
        if ( transform.position.z <= lowerBound )
        {
            Destroy(gameObject);
            gameManager.AddLives(-1);
        }
        if ( transform.position.x >= rightBound )
        {
            Destroy(gameObject);
            gameManager.AddLives(-1);
        }
        if (transform.position.x <= leftBound)
        {
            Destroy(gameObject);
            gameManager.AddLives(-1);
        }
    }
}


