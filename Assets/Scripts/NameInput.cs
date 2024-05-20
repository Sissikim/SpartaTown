using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    public InputField nameInput;
    private string playerName = null;

    private void Awake()
    {
        playerName = nameInput.GetComponent<InputField>().text;
    }

    void Update()
    {
        if (playerName.Length > 2 && playerName.Length < 10)
        {
            InputName();
        }
    }

    public void InputName()
    {
        playerName = nameInput.text;
    }
}
