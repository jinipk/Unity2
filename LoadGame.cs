using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    public void LoadGameScene() {
        UIController.gameOver = false;
        SceneManager.LoadScene(sceneName);
        Score.score = 0;
    }
}
