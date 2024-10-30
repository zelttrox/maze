using System.Diagnostics;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {

    public string[] Levels = {
        "Level 1",
        "Level 2",
        "Level 3",
        "Level 4",
        "Level 5",
        "Level 6",
        "Level 7",
        "Level 8",
        "Level 9",
        "Level 10"};

    public int currentLevel;
    public string currentScene;

    void Start() {
        //currentLevel = 0;
        //currentScene = Levels[currentLevel];
    }
    public void LoadScene(int level) {
            SceneManager.LoadScene(Levels[level]);
            currentLevel = level;
    }
}
