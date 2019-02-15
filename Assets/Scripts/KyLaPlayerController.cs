﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyLaPlayerController : MonoBehaviour {

    //Movement
    private Rigidbody rb;
    public float speed;
    
    //Item Pickup Logic
    public GameObject MessagePanel;
    public GameObject ObjectivePanel;

    void Start() {

        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {

        // Player Movement
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);


        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

    }

    // Start of PickUP Logic
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            MessagePanel.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            MessagePanel.SetActive(false);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup") && Input.GetKey("g"))
        {
            MessagePanel.SetActive(false);
            other.gameObject.SetActive(false);
            ObjectivePanel.SetActive(true);
        }
    }
}
