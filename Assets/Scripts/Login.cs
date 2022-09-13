using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    [SerializeField] private string toCommonRoom = "Common Room";

    public void loginButton()
    {
        SceneManager.LoadScene(toCommonRoom);
    }

}
