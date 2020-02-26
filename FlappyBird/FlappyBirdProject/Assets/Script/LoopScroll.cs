using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopScroll : MonoBehaviour {


    BoxCollider2D boxCollider2D = null;
    float groundWidth = 0;


    private void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
        groundWidth = boxCollider2D.size.x * transform.localScale.x;
    }
    private void Update()
    {
        if (transform.position.x < -groundWidth )
        {
            RespawnObject();
        }
    }
    void RespawnObject()
    {
        Vector2 groundOffest = new Vector2(groundWidth * 2, 0);
        transform.position = (Vector2)transform.position + groundOffest;
    }
}
