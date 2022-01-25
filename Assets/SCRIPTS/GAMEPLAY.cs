using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GAMEPLAY : MonoBehaviour
{
    public GameObject Player;
    public int TotalPlayers;
    public GameObject INPUTFIELD;
    void Start()
    {
        //SetPlayers();
    }

    public void SET()
    {
        string str = INPUTFIELD.GetComponent<InputField>().text.ToString();
        TotalPlayers = int.Parse(str);
        INPUTFIELD.SetActive(false);
        if (TotalPlayers > 50)
        {
            TotalPlayers = 50;
        }
        SetPlayers();

    }
    int k = 0,j=0;
    public void SetPlayers()
    {
        for (int i = 0; i < TotalPlayers; i++)
        {
            if (i == 0)
            {
                Instantiate(Player, new Vector3(-k * 4, 1.6f, 0.625f * (i)), Quaternion.identity);
            }
            else if (i % 9 != 0) 
            {
                if (i % 2 == 0)
                {
                    Instantiate(Player, new Vector3(-k*4, 1.6f,0.625f*2 * (j)), Quaternion.identity);
                }
                else
                {
                        j++;
                     Instantiate(Player, new Vector3(-k * 4, 1.6f, -0.625f *2* (j)), Quaternion.identity);
                }
            }
            else
            {
                k++;
                j = 0;
                if (j == 0)
                {
                    Instantiate(Player, new Vector3(-k * 4, 1.6f, 0), Quaternion.identity);
                }
                else if (i % 2 == 0)
                {
                    Instantiate(Player, new Vector3(-k * 4, 1.6f, 0.625f * 2 * (j)), Quaternion.identity);
                }
                else
                {
                    j++;
                    Instantiate(Player, new Vector3(-k * 4, 1.6f, -0.625f * 2 * (j)), Quaternion.identity);
                }
            }

        }
    }
    void Update()
    {
        
    }
}
