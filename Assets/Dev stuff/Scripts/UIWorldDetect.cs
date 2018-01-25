using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIWorldDetect : MonoBehaviour
{
    void Update()
    {
        RaycastWorldUI();
    }

    void RaycastWorldUI()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PointerEventData pointerData = new PointerEventData(EventSystem.current);

            pointerData.position = Input.mousePosition;

            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerData, results);

            if (results.Count > 0)
            {
                if (results[0].gameObject.layer == LayerMask.NameToLayer("WorldUI"))
                {
                    results.Clear();
                }
            }
        }
    }
}