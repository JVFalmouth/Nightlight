using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class direction_script : MonoBehaviour
{
    Transform parentTransform;
    SpriteRenderer spriteRenderer;
    private float objectX;

    // Start is called before the first frame update
    void Start()
    {
        parentTransform = gameObject.GetComponentInParent<Transform>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        objectX = parentTransform.position.x;
    }

    void Update()
    {
        if (objectX > parentTransform.position.x)
        {
            spriteRenderer.flipX = true;
        }
        else if (objectX < parentTransform.position.x)
        {
            spriteRenderer.flipX = false;
        }
        objectX = parentTransform.position.x;
    }
}
