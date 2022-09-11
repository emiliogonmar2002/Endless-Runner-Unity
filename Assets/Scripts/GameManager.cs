using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _gameManager;
    public static GameManager Instance {
        get => _gameManager;
        set => _gameManager = value;
    }

    [SerializeField] private GemsCollected _uiController;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        }    
    }

    private bool _gameOver;
    public bool GameOver {
        get => _gameOver;
        set {
            _gameOver = value;
            print("Game Over");
            _uiController.ShowGameOverScreen();
        }
    }

    public void ReloadGame() {
        SceneManager.LoadScene("SampleScene");
    }
}
