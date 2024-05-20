using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinButton : MonoBehaviour
{
    public void JoinGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
