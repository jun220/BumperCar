using UnityEngine;

public class FollowCarRotation : MonoBehaviour
{
    public Transform car;
    public float rotationSpeed = 5f;

    void Update()
    {
        Quaternion targetRotation = Quaternion.LookRotation(car.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}
