using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeInputFieldText : MonoBehaviour
{
    public InputField input;
    void Start()
    {
        input.text = "some text for input";
    }
}
