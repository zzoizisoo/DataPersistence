using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class IntroSceneUI : MonoBehaviour
{
    //public InputField usernameInput;
    //public TextMesh
    public TMP_InputField usernameInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetUserName()
    {
        DataManager.Instance.SetUserName(usernameInput.text);
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene(1);
    }
}
