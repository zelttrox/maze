using UnityEngine;

public class PlatMovement : MonoBehaviour {

    [SerializeField] private float rotationSpeed = 0F;

    private bool isInverted = false;
    private float rotationX;
    private float rotationZ;

    void Update() {

        if (isInverted) {
        rotationX = Input.GetAxis("Vertical");
        rotationZ = Input.GetAxis("Horizontal");
        } else {
        rotationX = Input.GetAxis("Horizontal");
        rotationZ = Input.GetAxis("Vertical");
        }

        Vector3 rotation = new Vector3(rotationX, 0F, -rotationZ);

        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);
    }

    public void InvertInput() {
        isInverted = !isInverted;
    }
}
