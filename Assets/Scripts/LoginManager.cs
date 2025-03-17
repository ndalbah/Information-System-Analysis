using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    // private + serialize = visible in editor but not accessible/usable by other scripts
    [SerializeField]
    private TMP_InputField loginUsername;

    [SerializeField]
    private TMP_InputField loginPassword;

    [SerializeField]
    private TextMeshProUGUI errorText;

    // Called when the login button is pressed: grab username and password and check they are correct
    public void OnLogin()
    {
        string username = loginUsername.text;
        string password = loginPassword.text;

        string infoValidationMessage = ValidateInfo(username, password);

        if (string.IsNullOrEmpty(infoValidationMessage))
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            errorText.text = "Error: " + infoValidationMessage;
        }
    }

    public void OnSignup()
    {
        string username = loginUsername.text;
        string password = loginPassword.text;

        string loginValidationMessage = ValidateInfo(username, password);

        if (string.IsNullOrEmpty(loginValidationMessage))
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            errorText.text = "Error: " + loginValidationMessage;
        }
    }

    //return empty string for correct login, otherwise return error message
    private string ValidateInfo(string username, string password)
    {
        string errorMessage;

        if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
        {
            errorMessage = "Username and password empty";
        }
        else if (string.IsNullOrEmpty(username))
        {
            errorMessage = "Username empty";
        }
        else if (string.IsNullOrEmpty(password))
        {
            errorMessage = "Password empty";
        }
        else
        {
            errorMessage = "";
        }

        return errorMessage;

    }

    //removes error message when user starts typing
    public void RemoveErrorMessage()
    {
        errorText.text = "";
    }
}
