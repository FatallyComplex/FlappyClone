using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public CircleCollider2D myCollider;
    public Transform birdTransform;
    public float flap;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive){
            myRigidBody.velocity = Vector2.up * flap;
        }

        else if(!birdIsAlive){
            myRigidBody.velocity = Vector2.down * 10;
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Happened");
        logic.gameOver();
        birdIsAlive = false;
        Vector3 teleport = new Vector3(birdTransform.position.x, 0f, birdTransform.position.z);
        birdTransform.position = teleport;
        myCollider.enabled = false;
    }

}
