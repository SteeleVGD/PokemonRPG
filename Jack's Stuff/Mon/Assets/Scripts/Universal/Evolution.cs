using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evolution : MonoBehaviour
{
    public int currentEvolvingPokemonID;

    public int endPokemonID;


    public void GetID (int CEPID, int EPID)
    {
        currentEvolvingPokemonID = CEPID;
        endPokemonID = EPID;

        for(int i = 0; i < 30000; i++)
        {
            if(i == 29998)
            {

                //evolution stuff goes here

            }
        }
    }
}
