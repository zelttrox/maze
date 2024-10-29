using System.Runtime.CompilerServices;
using UnityEngine;

public class Trap : MonoBehaviour {

    [SerializeField] private TrapType Type;
    [SerializeField] private Rigidbody Player;

    private float RepulseForce = 5f;
    private float LaunchForce = 10f;

    private enum TrapType {
        repulse, 
        blade, 
        launcher, 
        button,
        finish
    }

    public void OnTriggerEnter(Collider triggered) {
        if (triggered.tag == "Player") {
            TriggerTrap();
        }
    }

    private void TriggerTrap() {

        switch(Type) {

            case TrapType.repulse:
            Repulse(Player);
            break;
                
            case TrapType.blade:
            Slice(Player);
            break;

            case TrapType.launcher:
            Launch(Player);
            break;

            case TrapType.button:
            PressButton(Player);
            break;


            case TrapType.finish:
            Finish(Player);
            break;
        }
    }

    public void Repulse(Rigidbody Object) {
        Object.AddForce(-Object.linearVelocity * Object.mass * RepulseForce, ForceMode.Impulse);
    }

    public void Slice(Rigidbody Object) {
        Destroy(Object);
    }

    public void Launch(Rigidbody Object) {
        Object.AddForce(Vector3.up * (Object.mass * LaunchForce), ForceMode.Impulse);
    }

    public void Finish(Rigidbody Object) {
        // Load next level
    }

    public void PressButton(Rigidbody Object) {
        // Button press action
    }
}
