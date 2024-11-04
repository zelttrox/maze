using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuLogic : MonoBehaviour {

    public void Play() {
        SceneManager.LoadScene("Level 1");
    }

    public void Exit() {
        Application.Quit();
    }
}
