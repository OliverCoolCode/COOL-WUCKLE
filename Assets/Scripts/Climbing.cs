using UnityEngine;

public class Climbing : MonoBehaviour
{
    private Rigidbody body;

    private void Awake()
    {
        body = GetComponentInParent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
                GetComponentInParent<FirstPersonMovement>().enabled = false;
                GetComponentInParent<Jump>().enabled = false;
                GetComponentInParent<Crouch>().enabled = false;

                Vector3 distance = hit.point - transform.position;
                body.linearVelocity = distance;
            }
        }
    }
}
