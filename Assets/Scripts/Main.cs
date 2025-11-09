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
        sunTransform.Rotate(Vector3.up, sunRotationSpeed *  Time.deltaTime);
        earthTransform.Rotate(Vector3.up, earthRotationSpeed * Time.deltaTime);
        moonTransform.Rotate(Vector3.up, moonRotationSpeed * Time.deltaTime);
    }
}
