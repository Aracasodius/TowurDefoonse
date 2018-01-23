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
                Debug.Log("I right Clicked " + hit.transform.name + " To build a tower");
                GameObject canv = (GameObject)Instantiate(Resources.Load("TowerSelect"));
                canv.GetComponent<Canvas>().worldCamera = cam;
                canv.GetComponent<RectTransform>().localPosition = hit.transform.position + new Vector3(0, 1.5f, 0.1f);
                //canv.GetComponent<RectTransform>().eulerAngles = new Vector3(25, 180, 0);
                canv.transform.LookAt(cam.transform);
            }
        }
    }
}

