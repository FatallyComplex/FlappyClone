using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleTriggerScript : MonoBehaviour
{

    public LogicScript logicScript;

    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logicScript.addScore(1);
        }
    }
}
