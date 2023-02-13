using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnailController : MonoBehaviour
{
    public GameObject projectilePrefab;
    private float timer;
    public int waitingTime;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitingTime)
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.Euler(0f, 180f, 0f));
            timer = 0;
        }
    }
}
