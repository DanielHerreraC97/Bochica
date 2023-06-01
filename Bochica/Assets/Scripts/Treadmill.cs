using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treadmill : MonoBehaviour
{
    public float speed = 1f;

    private void Update()
    {
        // Move the object to the right
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
