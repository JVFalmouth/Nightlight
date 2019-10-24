using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class set_respawn : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if ("Bat_PH" == other.gameObject.name)
        {
            other.GetComponent<fear_script>().respawn = gameObject.transform.position;
        }
    }
}
