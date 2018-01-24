using UnityEngine;

public class Buildable : MonoBehaviour
{

    private Camera cam;
    private bool CanvasOpen;

    private void Start()
    {
        cam = Camera.main;
    }

    private void FixedUpdate()
    {
        if ( Input.GetMouseButtonUp(1))
        {
            Spawn();
        }
    }

    void Spawn()
    {
        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Tower" && !CanvasOpen)
        {
            GameObject canv = (GameObject)Instantiate(Resources.Load("TowerSelect"));
            canv.GetComponent<Canvas>().worldCamera = cam;
            canv.GetComponent<RectTransform>().localPosition = hit.transform.position + new Vector3(0, 3f, 0.1f);
            canv.transform.LookAt(cam.transform);
            canv.GetComponentInChildren<BuildManager>().Socket = hit.transform.gameObject;
            CanvasOpen = true;
        }
    }
}

