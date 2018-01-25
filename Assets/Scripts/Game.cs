using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {

    public static Game instance;
    public GameObject player;
    public int currentScene;

    int lives = 3;
    int collectables = 0;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Singleton Error");
        }
        instance = this;
    }

    private void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        currentScene = scene.buildIndex;
    }

    private void Update()
    {
        if (lives == 0)
        {
            GameOver();
        }
    }

    public void Die()
    {
        lives--;
        // player.transform.position = Vector3.MoveTowards(transform.position, startPos, 10);
        SceneManager.LoadScene(2);
    }

    public void AddCollectables()
    {
        collectables = +1;
        Debug.Log(collectables);
    }

    public void GameOver()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(1);
    }
}
