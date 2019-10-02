using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{

    public bool runCalc;

    public float level;

    public Pokedex pokedex;

    public int att;
    public int def;
    public int spd;
    public int spclDef;
    public int spclAtt;
    public int HP;

    public float mathAtt;
    public float mathDef;
    public float mathSpd;
    public float mathSpclDef;
    public float mathSpclAtt;
    public float mathHP;

    public float testAtt;
    public float testDef;
    public float testSpd;
    public float testSpclDef;
    public float testSpclAtt;
    public float testHP;

    private void Update()
    {


        if(runCalc == true)
        {
            mathAtt = ((level * (testAtt * (0.02f))) + testAtt);
            att = Mathf.RoundToInt(mathAtt);

            mathDef = ((level * (testDef * (0.02f))) + testDef);
            def = Mathf.RoundToInt(mathDef);

            mathSpd = ((level * (testSpd * (0.02f))) + testSpd);
            spd = Mathf.RoundToInt(mathSpd);

            mathSpclDef = ((level * (testSpclDef * (0.02f))) + testSpclDef);
            spclDef = Mathf.RoundToInt(mathSpclDef);

            mathSpclAtt = ((level * (testSpclAtt * (0.02f))) + testSpclAtt);
            spclAtt = Mathf.RoundToInt(mathSpclAtt);

            mathHP = ((level * (testHP * (0.02f))) + testHP);
            HP = Mathf.RoundToInt(mathHP);

            runCalc = false;
        }

    }

   public void Stats(float a, float d, float s, float sd, float sa, float h)
    {
        testAtt = a;
        testDef = d;
        testSpd = s;
        testSpclDef = sd;
        testSpclAtt = sa;
        testHP = h;
    }

}
