using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerMenu : MonoBehaviour
{
    public void Close()
    {
        Debug.Log("Closing Menu");
        Destroy(transform.parent.gameObject);
    }
}
