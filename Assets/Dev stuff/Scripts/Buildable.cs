using UnityEngine;

public class Buildable : MonoBehaviour
{

    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        if ( Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Tower" )
            {
                GameObject canv = (GameObject)Instantiate(Resources.Load("TowerSelect"));
                canv.GetComponent<Canvas>().worldCamera = cam;
                canv.GetComponent<RectTransform>().localPosition = hit.transform.position + new Vector3(0, 1.5f, 0.1f);
                canv.transform.LookAt(cam.transform);
                canv.GetComponentInChildren<BuildManager>().Socket = hit.transform.gameObject;
            }
        }
    }
}

