using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    int level = 10;
    public int xp = 0;
    int xpToLevel = 100;
    int maxLevel = 12;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (level < maxLevel)
        {
            if (xp >= xpToLevel)
            {
                level++;
                Debug.Log("Ding! You reached level " + level);
                xp = xp - xpToLevel;
                xpToLevel += 50;
            }
        }
    }
}