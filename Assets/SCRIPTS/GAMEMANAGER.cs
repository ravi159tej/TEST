using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class GAMEMANAGER : MonoBehaviour
{
    public List<int> INPUT;
    public Text EnteredArray,Result;
    int TotalWater = 0;



    [Header("SORTING A WORDS")]
    public string GivenName;
    public GameObject SortingInput;
    public Text SortingResult;

    [Header("CAPITAL TO SMALL")]

    public string LETTERS;
    public string LETTERSRESULT;

    string CAPS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
     string SMALL = "abcdefghijklmnopqrstuvwxyz";

    public char[] capsCHAR;
    public char[] smallCHAR;
    void Start()
    {
        maxWater();
        SortTheName();
        capsCHAR = CAPS.ToCharArray();
        smallCHAR = SMALL.ToCharArray();
        convertingCaptoSmall();


    }

    public  void maxWater()
    {
        for (int i = 0; i < INPUT.Count; i++)
        {
            if (i < INPUT.Count - 1)
            {
                EnteredArray.text = EnteredArray.text + INPUT[i] + ",";
            }
            else
            {
                EnteredArray.text = EnteredArray.text + INPUT[i];
            }
        }
       

        for (int i = 1; i < INPUT.Count - 1; i++)
        {

            // Find maximum element on its left
            int left = INPUT[i];
            for (int j = 0; j < i; j++)
            {
                left = Mathf.Max(left, INPUT[j]);
            }

            // Find maximum element on its right
            int right = INPUT[i];
            for (int j = i + 1; j < INPUT.Count; j++)
            {
                right = Mathf.Max(right, INPUT[j]);
            }

            // Update maximum water value
            TotalWater += Mathf.Min(left, right) - INPUT[i];
        }
        Result.text ="TRAPPED WATER-"+ TotalWater.ToString();
    }

    public void SortTheName()
    {
        GivenName = SortingInput.GetComponent<InputField>().text;

        char temp;
           
            char[] charstr = GivenName.ToCharArray();
            for (int i = 1; i < charstr.Length; i++)
            {
                for (int j = 0; j < charstr.Length - 1; j++)
                {
                    if (charstr[j] > charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }
            }
        string result = new string(charstr);
        print(result);
     SortingResult.text=result;

}

void convertingCaptoSmall()
    {
        char[] dummy = LETTERS.ToCharArray();
        for (int i = 0; i <LETTERS.Length ; i++)
        {
            for (int j = 0; j < capsCHAR.Length; j++)
            {
                if (LETTERS[i] == capsCHAR[j])
                {
                    dummy[i] = smallCHAR[j];
                }
            }
        }
        LETTERSRESULT = new string(dummy);
    }
}
