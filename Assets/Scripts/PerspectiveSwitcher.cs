using UnityEngine;
using System.Collections;


public class PerspectiveSwitcher : MonoBehaviour
{

    void Start()
    {
     
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Camera mainCamera = GetComponent<Camera>();
            if (mainCamera == null)
                return;

            mainCamera.orthographic = !mainCamera.orthographic;
        }
    }
}
