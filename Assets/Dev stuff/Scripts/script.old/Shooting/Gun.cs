using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Enemies;
    private BoxCollider ViewRect;
    private AudioSource audio;
    public bool Scan;

    private float Timer;

    [Space]
    [Header("Shooting settings")]
    [SerializeField] private float damage;
    [SerializeField] private float fireRate;
    [SerializeField] private float weaponRange;
    [SerializeField] private float hitForce;

    [Space]
    [Header("Transform positions")]
    [SerializeField] private Transform origin;
    [SerializeField] private Transform EjectPoint;

    [Space]
    [Header("Particle Systems")]
    [SerializeField] private ParticleSystem muzzleflash;
    [SerializeField] private ParticleSystem cartridge;
    [SerializeField] private ParticleSystem BloodParticles;

    private void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Enemies != null)
        {
            Scan = false;
            Shoot();
        }

        if (Enemies == null)
        {
            if (audio.isPlaying) { audio.Stop(); }

            Scan = true;
        }

    }
    private void FixedUpdate()
    {

        if (Scan)
        {
            Timer += Time.deltaTime;
            transform.rotation = Quaternion.Euler(0f, 45 * Mathf.Sin(Timer), 0f);
        }
    }

    private void Shoot()
    {
        Instantiate(muzzleflash, origin.transform.position, origin.transform.rotation, origin);
        Instantiate(cartridge, EjectPoint.transform.position, EjectPoint.transform.rotation, EjectPoint);
        if (!audio.isPlaying) { audio.Play(); }

        RaycastHit hit;
        if (Physics.Raycast(origin.position, origin.forward, out hit, weaponRange))
        {
            Debug.Log(gameObject.name + " Is hitting " + hit.transform.gameObject.name);

            if (hit.transform.gameObject.GetComponent<Health>())
            {
                Instantiate(BloodParticles, hit.point, Quaternion.LookRotation(hit.normal));
                Health health = hit.transform.gameObject.GetComponent<Health>();

                health.Damage(damage);
            }
        }
    }

}