using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_script : MonoBehaviour
{
    private GameObject Text_Manager;
    Rigidbody2D rb2d;
    // Start is called before the first frame update
    private void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        Text_Manager = GameObject.FindWithTag("DialogueManager");
    }

    // Update is called once per frame
    private void Update()
    {
        if (Text_Manager.GetComponent<Text_Display>().intro_playing == false)
        {
            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var mouseDir = mousePos - gameObject.transform.position;
            mouseDir.z = 0.0f;
            mouseDir = mouseDir.normalized;
            if (Input.GetMouseButton(0))
            {
                rb2d.AddForce(mouseDir * 10);
            }
        }
    }
}