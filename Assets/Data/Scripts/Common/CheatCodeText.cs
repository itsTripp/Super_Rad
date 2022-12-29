using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheatCodeText : MonoBehaviour
{
    public string cheatCode;
    public TMP_InputField inputField;
    public GameObject inputFieldText;
    public GameObject textDisplay;

    void Start()
    {
        inputField.onValueChanged.AddListener(delegate { RemoveSpaces(); });
    }

    public void StoreName()
    {
        cheatCode = inputFieldText.GetComponent<TextMeshProUGUI>().text;
        textDisplay.GetComponent<TextMeshProUGUI>().text = "Welcome " + cheatCode + " to the game";
    }
    
    void RemoveSpaces()
    {
        inputField.text = inputField.text.Replace(" ", "");
    }
}
