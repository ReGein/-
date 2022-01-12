using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour
{
    public float mapSpeed = 0.5f;

    void Update()
    {
        transform.Translate(-mapSpeed * Time.deltaTime, 0, 0);
    }
}
