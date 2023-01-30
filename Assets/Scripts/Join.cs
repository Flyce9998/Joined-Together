using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Join : MonoBehaviour
{
    public Transform prefab;
    int times = 0;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey("space"))
        {
            if (times == 0)
            {
                FindObjectOfType<AudioManager>().Play("Click");
                Instantiate(prefab, transform.position, Quaternion.identity, collision.gameObject.transform);
                times++;
            }
            Object.Destroy(gameObject);
        }
    }
}
