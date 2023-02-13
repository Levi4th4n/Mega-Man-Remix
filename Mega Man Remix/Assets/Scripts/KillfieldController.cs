using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillfieldController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }
}
