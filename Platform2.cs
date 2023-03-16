using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public bool isActive;
    public Transform StopPoint1;
    public Transform StopPoint2;

    private void Update()
    {
        if (isActive)
        {
            transform.position += direction * speed * Time.deltaTime;
        }

        if (gameObject.transform.position.z <= StopPoint1.position.z || gameObject.transform.position.z >= StopPoint2.position.z) 
        {
            direction *= -1;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isActive = true;
        }
    }
}
