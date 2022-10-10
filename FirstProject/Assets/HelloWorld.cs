using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        string name = "J";
        int health = 20;
        float critChance = 0.2f;
        bool alive = true;
        Vector2 moveDir = new Vector2(1, -1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
