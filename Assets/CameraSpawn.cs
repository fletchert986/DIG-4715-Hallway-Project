using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSpawn : MonoBehaviour
{
    public GameObject player;
    public GameObject guard;
    public GameObject cinematicCamera;
    public float time;
    private float startTime;

    private void Start()
    {
        startTime = Time.time;
    }

    private void Update ()
    {
        if ((Time.time >= startTime + time))
        {
            player.SetActive(true);
            guard.SetActive(true);
            cinematicCamera.SetActive(false);
        }
    }
}
