using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour
{
    public Transform target;
    public float smooth = 5.0f;
    public Vector3 offset = new Vector3(0, 5, -10); // Настройте это смещение по вашему усмотрению

    void Update()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smooth);
    }
}
