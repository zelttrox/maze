using UnityEngine;

public class PlatMovement : MonoBehaviour {

    [SerializeField] private float rotationSpeed = 0F;
    void Update() {
        float rotationX = Input.GetAxis("Vertical");
        float rotationZ = Input.GetAxis("Horizontal");

        Vector3 rotation = new Vector3(rotationX, 0F, -rotationZ);

        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);
    }
}
