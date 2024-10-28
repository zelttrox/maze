using UnityEngine;

public class Player : MonoBehaviour {

    public Rigidbody Ball;
    public void RepulsePlayer() {

        Debug.Log("Repulse");
        Ball.AddForce(Ball.linearVelocity);
    
    }
}
