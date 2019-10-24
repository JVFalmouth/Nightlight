
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Camera : MonoBehaviour
{
    private Vector3 velocity;
    private void OnTriggerStay2D(Collider2D other)
    {
       velocity  = other.GetComponent<Rigidbody2D>().velocity;
        if (other.gameObject.tag == "Player")
        {
            if (other.GetComponent<Transform>().position.x > gameObject.transform.position.x)
            {

                transform.Translate(Vector3.right * velocity.x * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.left * -(velocity.x) *  Time.deltaTime);
            }
        }
    }

}
