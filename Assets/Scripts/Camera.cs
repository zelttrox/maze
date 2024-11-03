using UnityEngine;

public class Camera : MonoBehaviour {

    public GameObject Cam;
    public PlatMovement Plat;

    private bool isSwitched = false;

    private Vector3 CamPosition1;
    private Vector3 CamRotation1;

    private Vector3 CamPosition2;
    private Vector3 CamRotation2;

    void Start() {
        CamPosition1 = new Vector3(-8, 8, 0);
        CamRotation1 = new Vector3(50, 90, 0);
        CamPosition2 = new Vector3(0, 8, -8);
        CamRotation2 = new Vector3(50, 0, 0);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            SwitchView();
            Plat.InvertInput();
        }
    }

    public void SwitchView() {
        if (isSwitched) {
            Cam.transform.position = CamPosition1;
            Cam.transform.rotation = Quaternion.Euler(CamRotation1);
        } else {
            Cam.transform.position = CamPosition2;
            Cam.transform.rotation = Quaternion.Euler(CamRotation2);
        }
        isSwitched = !isSwitched;
    }
}
