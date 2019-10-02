using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroDialogueStorage : MonoBehaviour
{
    public Text TextBox;
    public string[] introText;
    public bool advanceText;
    private int i;

    private void Update()
    {

        if(advanceText == true)
        {
            i++;
            advanceText = false;
        }

        if(Input.GetKeyDown(KeyCode.Return))
        {
            i++;
        }

        TextBox.text = introText[i];
    }

}
