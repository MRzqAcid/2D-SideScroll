using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target; //untuk objek yang akan diikuti sama kamera
    public float smoothSpeed = 0.125f; // setting kecelpatan pergerakan kamera

    public Vector3 offset; //untuk jarak antara kamera dan objek yang diikuti

    private void FixedUpdate()
    {
        // untuk mengambil posisi kamera saat ini
        Vector3 desiredPosition = target.position + offset;

        // untuk menghitung posisi kamera yang diinginkan dengan smooth
        Vector3 smoothetPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // untuk ngatur posisi kamera sesuai keinginan
        transform.position = new Vector3(smoothetPosition.x, transform.position.y, transform.position.z);
    }



}
