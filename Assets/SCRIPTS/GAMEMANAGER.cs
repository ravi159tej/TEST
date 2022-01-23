using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class GAMEMANAGER : MonoBehaviour
{
    public string NAME;
    public GameObject InputField;
    public GameObject DISPLAY;
    public Text Result;
    int TotalWater = 0;

    public List<int> INPUT;


    [Header("SORTING A WORDS")]
    public string GivenName;


    [Header("CAPITAL TO SMALL")]

    public string ALPHABETS;

   //public char CAPS = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ';
    void Start()
    {
        maxWater();
        SortTheName();
        convertingCaptoSmall();
    }

    public  void maxWater()
    {

       

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
        Result.text = TotalWater.ToString();
    }

    public void SortTheName()
    {
       
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
    }
    
    void convertingCaptoSmall()
    {

    }
}
