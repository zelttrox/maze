using UnityEngine;

public class Trap : MonoBehaviour {

    public Player Player;

    [SerializeField] private enum TrapType {
        repulse, 
        blade, 
        launcher, 
        fan, 
        finish
    }

    private TrapType Type;

    private void OnTriggerEnter(Collider triggered) {
        if (triggered.tag == "Player") {
            TriggerTrap();
        }
    }

    private void TriggerTrap() {

        switch(Type) {

            case TrapType.repulse:
            Player.Repulse();
            break;
                
            case TrapType.blade:
            break;

            case TrapType.launcher:
            break;

            case TrapType.fan:
            break;

            case TrapType.finish:
            break;
        }
    }
}
