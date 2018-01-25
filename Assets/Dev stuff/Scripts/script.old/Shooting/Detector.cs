using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    [SerializeField] private Gun gun;
    private Vector3 target;

    private void Update()
    {
        if (gun.Enemies != null)
        {
            target = gun.Enemies.transform.position;

            gun.transform.LookAt(target);
            gun.transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z *-1 , transform.rotation.w);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            gun.Enemies = other.gameObject;
        }
    }
}
