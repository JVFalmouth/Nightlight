﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class owl_move_script : MonoBehaviour
{

    private Rigidbody2D rb2d;
    public AudioSource screach;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            screach.Play();
        }
    }

    // Update is called once per frame
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            var batPos = other.transform.position;
            var dir = batPos - gameObject.transform.position;
            dir.z = 0.0f;
            dir = dir.normalized;
            rb2d.AddForce(dir * 10);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<fear_script>().fear = 0;
        }
    }
}