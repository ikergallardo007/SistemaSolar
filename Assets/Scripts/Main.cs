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
    private Vector3 earthDirectionVector;
    private Vector3 moonDirectionVector;

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

        // Direction vectors.
        //earthDirectionVector = earthTransform.forward * (-1);

        // Rays of the sun.
        Debug.DrawRay(sunTransform.position, sunTransform.right, Color.red); 
        Debug.DrawRay(sunTransform.position, sunTransform.up, Color.green);
        Debug.DrawRay(sunTransform.position, sunTransform.forward, Color.blue);

        // Rays of the earth.
        Debug.DrawRay(earthTransform.position, earthTransform.right, Color.red);
        Debug.DrawRay(earthTransform.position, earthTransform.up, Color.green);
        Debug.DrawRay(earthTransform.position, earthTransform.forward, Color.blue);
        Debug.DrawRay(earthTransform.position, sunTransform.forward * (-1));

        // Rays of the moon.
        Debug.DrawRay(moonTransform.position, moonTransform.right, Color.red);
        Debug.DrawRay(moonTransform.position, moonTransform.up, Color.green);
        Debug.DrawRay(moonTransform.position, moonTransform.forward, Color.blue);
        Debug.DrawRay(moonTransform.position, earthTransform.forward * (-1));
    }
}
