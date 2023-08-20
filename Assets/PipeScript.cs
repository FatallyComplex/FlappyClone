using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{

    public float moveSpeed = 5;

    private int deadZone = -30;

    private bool isGameOver = false;

    public PipeSpawnScript pipeSpawnScript;



    // Start is called before the first frame update
    void Start()
    {
        GameObject spawnerObject = GameObject.FindWithTag("Spawner");
        if (spawnerObject != null)
        {
            pipeSpawnScript = spawnerObject.GetComponent<PipeSpawnScript>();
        }
        else
        {
            Debug.LogWarning("No object with the 'Spawner' tag found.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

            if (transform.position.x < deadZone)
            {
                pipeSpawnScript.deletePipe(gameObject);
                Destroy(gameObject);
            }
        }
    }

    public void gameOver()
    {
        isGameOver = true;
    }

}
