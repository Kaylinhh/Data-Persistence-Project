using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public string playerName;
    public TMP_InputField inputField;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetName()
    {
        playerName = inputField.text;
        Debug.Log(playerName);
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
        SetName();
    }
}
