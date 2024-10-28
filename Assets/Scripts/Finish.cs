using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour {

    public Player Player;
    bool isTrigger = false;

    private void Update() {
        CheckContact();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            isTrigger = true;
        }
    }

    private void CheckContact()
    {
        if (isTrigger)
        {
            Player.RepulsePlayer();
            isTrigger = false;
        }
    }
}
