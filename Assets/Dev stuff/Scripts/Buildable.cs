using UnityEngine;

public class Buildable : MonoBehaviour
{
    private enum Object { Tower }

    private Object obj;

    private void Start()
    {
    }

    private void Update()
    {
        switch (obj)
        {
            case Object.Tower:
                {
                    break;
                }
        }
    }
}