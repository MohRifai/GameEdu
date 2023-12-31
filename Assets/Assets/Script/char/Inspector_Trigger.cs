﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Inspector_Trigger : MonoBehaviour
{

    [Header("Main Settings")]
    public string TagObject;
    public UnityEvent TriggerEvent;
    public bool DestroyTrigger;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InvokeTrigger()
    {
        TriggerEvent.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            TriggerEvent.Invoke();
            if (DestroyTrigger)
            {
                Destroy(collision.gameObject);
                GetComponent<PlayerMovement>().enabled = false;

            }
        }
    }
}