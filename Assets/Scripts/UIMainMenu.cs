using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] Button _newGame;

    private LevelManager _levelManager;

    // Start is called before the first frame update
    void Start()
    {
        _levelManager = LevelManager.Instance;
        _newGame.onClick.AddListener(StartNewGame);
    }

    private void StartNewGame(){
        //_levelManager.LoadNewGame();
        _levelManager.LoadAsyncScene(LevelManager.Scene.ExamenA_01);
    }
}
