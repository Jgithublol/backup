using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public GameObject player;
    public float close = 5.0f;
    public float speed = 3.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 chaseDir = player.transform.position - transform.position;
        float chaseDis = chaseDir.magnitude;
        chaseDir.Normalize();
        if (chaseDis <= close)
        {
            //chase the player lol
            GetComponent<Rigidbody2D>().velocity = chaseDir;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
        GetComponent<Animator>().SetFloat("xInput", chaseDir.x);
        GetComponent<Animator>().SetFloat("yInput", chaseDir.y);
    }
}
