﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject TheEnemy;
    float EnemySpeed;
    public int MoveTrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MoveTrigger == 1)
        {
            EnemySpeed = 0.02f;
            transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
        }    
    
    }

}
