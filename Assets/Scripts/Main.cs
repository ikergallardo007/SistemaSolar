using UnityEngine;

// Main class that controls all the Solar System.
public class Main : MonoBehaviour
{
    // Public Properties
    public float sunRotationSpeed;
    public float earthRotationSpeed;
    public float moonRotationSpeed;
    public Transform sunTransform;
    public Transform earthTransform;
    public Transform moonTransform;

    // Private Attributes

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotation of sun, earth and moon.
        sunTransform.Rotate(Vector3.up, sunRotationSpeed *  Time.deltaTime);
        earthTransform.Rotate(Vector3.up, earthRotationSpeed * Time.deltaTime);
        moonTransform.Rotate(Vector3.up, moonRotationSpeed * Time.deltaTime);

        // Rays of the sun.
        Debug.DrawRay(sunTransform.position, sunTransform.right, Color.red); // Local X axis
        Debug.DrawRay(sunTransform.position, sunTransform.up, Color.green); // Local Y axis
        Debug.DrawRay(sunTransform.position, sunTransform.forward, Color.blue); // Local Z axis
        // The sun is only rotating, so it has no movement vector.

        // Rays of the earth.
        Debug.DrawRay(earthTransform.position, earthTransform.right, Color.red); // Local X axis
        Debug.DrawRay(earthTransform.position, earthTransform.up, Color.green); // Local Y axis
        Debug.DrawRay(earthTransform.position, earthTransform.forward, Color.blue); // Local Z axis
        Debug.DrawRay(earthTransform.position, sunTransform.forward * (-1)); // Movement vector

        // Rays of the moon.
        Debug.DrawRay(moonTransform.position, moonTransform.right, Color.red); // Local X axis
        Debug.DrawRay(moonTransform.position, moonTransform.up, Color.green); // Local Y axis
        Debug.DrawRay(moonTransform.position, moonTransform.forward, Color.blue); // Local Z axis
        Debug.DrawRay(moonTransform.position, earthTransform.forward * (-1)); // Movement vector
    }
}
