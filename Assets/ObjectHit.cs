using System;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Hit");
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}