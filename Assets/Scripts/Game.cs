using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour {

    public Text LevelText;

    [SerializeField] public string[] Levels;
    public int currentLevel = 0;

    void Start() {
        ShowLevel();
    }
    
    public void LoadScene(int level) {
            SceneManager.LoadScene(Levels[level]);
            ShowLevel();
    }

    public void ShowLevel() {
        LevelText.text = Levels[currentLevel];
    }
}
