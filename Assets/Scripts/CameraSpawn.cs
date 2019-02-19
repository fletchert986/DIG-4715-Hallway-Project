using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSpawn : MonoBehaviour
{
    public GameObject player;
    public GameObject guard;
    public GameObject cinematicCamera;
    public GameObject step2;
    public GameObject step1;
    public float time;
    public float step2time;
    private float startTime = 0;


    private void Start()
    {

        
            startTime = Time.time;

        
    }

    private void Update ()
    {
        if ((Time.time >= startTime + step2time))
        {
            step1.SetActive(false);
            step2.SetActive(true);
        }


        if ((Time.time >= startTime + time))
        {
            step2.SetActive(false);
            player.SetActive(true);
            guard.SetActive(true);
            cinematicCamera.SetActive(false);
        }
    }
}
