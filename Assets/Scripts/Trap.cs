using UnityEngine;

public class Trap : MonoBehaviour {

    [SerializeField] private TrapType Type;
    [SerializeField] private Rigidbody Player;
    private enum TrapType {
        repulse, 
        blade, 
        launcher, 
        fan, 
        finish
    }

    private void OnTriggerEnter(Collider triggered) {
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
            break;

            case TrapType.fan:
            break;

            case TrapType.finish:
            break;
        }
    }

    public void Repulse(Rigidbody Object) {
        Object.AddForce(-Object.linearVelocity * Object.mass * 5, ForceMode.Impulse);
    }

    public void Slice(Rigidbody Object) {
        Destroy(Object);
    }
}
