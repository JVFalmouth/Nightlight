using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fear_script : MonoBehaviour
{
    [Range(0, 1000)]
    public int fear = 1000;
    public bool isTouchingLight;
    public Vector3 respawn;
    public Slider BraveryMeter;
    private GameObject Camera;
    public Vector3 camera_respawn;
    
    private void Start()
    {
        respawn = new Vector3(0f, 0f);
        Camera = GameObject.FindWithTag("MainCamera");
        camera_respawn = new Vector3(0f, 0f, -10f);
    }

    private void Update()
    {
        BraveryMeter.value = fear;
        if (isTouchingLight && fear < 1000)
        {
            fear += 5;
        }
        else if (!isTouchingLight && fear > 0)
        {
            fear --;
        }

        if (fear == 0 && !isTouchingLight)
        {
            gameObject.transform.position = respawn;
            camera_respawn.x = respawn.x;
            Camera.GetComponent<Transform>().position = camera_respawn;
        }
    }
}
