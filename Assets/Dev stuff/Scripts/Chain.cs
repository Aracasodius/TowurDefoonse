using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour
{
    void Update()
    {
        Physics.IgnoreLayerCollision(8, 8);
    }
}
