using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool gameHasEnded = false;
    public float restartdelay = 1f;
    public GameObject completeLevelUI;
    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
    }
    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void EndGame() {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            Invoke("Restart", restartdelay);
        }
    }
}
