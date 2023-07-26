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
    public GameObject bestScoreUI;
    public TextMeshProUGUI topUserName;
    public TextMeshProUGUI bestScore;
    public TMP_InputField usernameInput;
    // Start is called before the first frame update
    void Start()
    {
        if(DataManager.Instance.bestScore != 0) {
            bestScoreUI.SetActive(true);
            topUserName.text = "Name: "+DataManager.Instance.topUserName;
            bestScore.text = "Score: "+ DataManager.Instance.bestScore.ToString();
        }

        if (DataManager.Instance.userName !=null) {
            usernameInput.text = DataManager.Instance.userName;
        }

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
