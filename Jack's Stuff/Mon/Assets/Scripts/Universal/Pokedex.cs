using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pokedex : MonoBehaviour
{


    public string[] entry;

    public int currentEntry;

    public int[] unlockedEntry;

    public bool display;

    public Text Text;
    public Text Text2;

    public int i;

    public string[] pokemonNames;

    // Start is called before the first frame update
    void Start()
    {
        entry[0] = "Test Entry";
        entry[1] = "2";


        pokemonNames[0] = "Placeholder";
    }

    // Update is called once per frame
    void Update()
    {

        if(display == true)
        {
            Text.enabled = true;
        }
        else
        {
            Text.enabled = false;
        }

        if(unlockedEntry[i] == 0)
        {
            Text.alignment = TextAnchor.UpperLeft;
            Text.text = entry[i];
        }
        else
        {
            Text.alignment = TextAnchor.MiddleCenter;
            Text.text = "?????????????????????????????????????????";
        }


        if (display == true)
        {
            Text2.enabled = true;
            Text2.text = pokemonNames[i];
        }
        else
        {
            Text2.enabled = false;
        }
    }
}
