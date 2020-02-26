using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleControl : MonoBehaviour {

    bool isDead = false;
    float upForce = 200;
    Rigidbody2D rig2D = null;
    Animator anim = null;

    void Start () {
        rig2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
	
	void Update () {
        if(isDead == false)
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetMouseButtonDown(0))
            {
                rig2D.AddForce(new Vector2(0, upForce));
                anim.SetTrigger("isUp");
            }
        }      
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "CannotTouch")
        {
            isDead = true;
            GameManager.Instance.RoleDead();
            anim.SetTrigger("isDead");
        }
    }
}
