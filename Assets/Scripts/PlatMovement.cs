using UnityEngine;

public class PlatMovement : MonoBehaviour {

    [Header("Nom")]
    [SerializeField] private float rotationSpeed = 0F;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotationX = Input.GetAxis("Vertical");
        float rotationZ = Input.GetAxis("Horizontal");

        Vector3 rotation = new Vector3(rotationX, 0F, -rotationZ);

        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);

    }
}
