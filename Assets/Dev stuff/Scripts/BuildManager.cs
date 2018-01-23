using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public GameObject Socket;

    void Start()
    {

    }

    void Update()
    {

    }

    public void PlaceTower(GameObject tower)
    {
        Instantiate(tower, Socket.transform.position, Socket.transform.rotation, Socket.transform);
    }
}
