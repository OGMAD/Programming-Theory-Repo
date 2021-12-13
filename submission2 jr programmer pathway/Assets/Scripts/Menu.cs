using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    [SerializeField] Button startGameButton;
    // Start is called before the first frame update
    void Start()
    {
        startGameButton.onClick.AddListener(startGame);
    }

    void startGame()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
}
