using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{
    [SerializeField] private Transform Crystal;

    void Start()
    {

    }

    void Update()
    {
        Crystal.transform.Rotate(Vector3.up);
        Crystal.transform.Rotate(Vector3.left);
    }
}
