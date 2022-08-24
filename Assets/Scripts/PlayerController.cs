using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 2f;
    private float leftBoundary = -10f;
    private float rightBoundary = 10f;

    private float upperBoundary = 15f;
    private float downBoundary = -1;
    public GameObject projecttilePrefab;

   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        
        
    }
    void MovePlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        if (transform.position.x <= leftBoundary)
        {
            transform.position = new Vector3(leftBoundary, transform.position.y, transform.position.z);
        }
        if (transform.position.x >= rightBoundary)
        {
            transform.position = new Vector3(rightBoundary, transform.position.y, transform.position.z);
        }
        if(transform.position.z <= downBoundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, downBoundary);
        }
        if (transform.position.z >= upperBoundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, upperBoundary);
        }

        //SHoot food
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 shootdistance = new Vector3(0, 0, 2);
            Instantiate(projecttilePrefab, transform.position + shootdistance , projecttilePrefab.transform.rotation);
        }
    }
    
}
