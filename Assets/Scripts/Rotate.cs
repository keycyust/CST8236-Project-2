using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
    private float angle = 0.0f;

    public float Speed = 1.0f;

    void Start()
    {

    }

    void Update()
    {
        angle += 50.0f * Speed * Time.deltaTime;

        transform.localRotation = Quaternion.Euler(0.0f, angle, 0.0f);
    }
}