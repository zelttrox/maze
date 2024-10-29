using UnityEngine;

public class Player : MonoBehaviour {

    public Rigidbody Ball;

    public void Repulse(Rigidbody Object) {
        Object.AddForce(-Ball.linearVelocity * Ball.mass * 5, ForceMode.Impulse);
    }
}