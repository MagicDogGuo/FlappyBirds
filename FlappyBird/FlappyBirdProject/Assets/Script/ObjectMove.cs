using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour {

    Rigidbody2D rig2D = null;
    float scrollSpeed = -2;

    void Start()
    {
        rig2D = GetComponent<Rigidbody2D>();
        rig2D.velocity = new Vector2(scrollSpeed, 0);

    }

    private void Update()
    {
        if (GameManager.Instance.isGameOver == true)
        {
            rig2D.velocity = Vector2.zero;
        }
    }
}
