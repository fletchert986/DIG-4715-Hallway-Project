using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSpawn : MonoBehaviour
{
    public GameObject player;
    public GameObject guard;
    public GameObject cinematicCamera;
    public float time = 7;
  
    private void Update ()
    {
        if ((Time.time >= time))
        {
            player.SetActive(true);
            guard.SetActive(true);
            cinematicCamera.SetActive(false);
        }
    }
}
