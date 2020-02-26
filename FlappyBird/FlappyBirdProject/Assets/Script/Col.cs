using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Col : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<RoleControl>() != null)
        {
            GameManager.Instance.CountScored();
        }
    }
}
