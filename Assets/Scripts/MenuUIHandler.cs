using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public string playerName;
    public TMP_InputField inputField;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetInputValue()
    {
        playerName = inputField.text;
        Debug.Log(playerName);
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
}
