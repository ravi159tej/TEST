using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public float Speed;
    public float MinSpeed, MaxSpeed;

    public float Timer = 5f;
   public Rigidbody Rb;
    public float Mintime, Maxtime;
    public float Endpoint,startpoint;
    private void Awake()
    {
        Speed = Random.Range(MinSpeed, MaxSpeed);
        Timer = Random.Range(Mintime, Maxtime);
        //StartCoroutine(MOVE());
    }
    float randomvalu = 0;
    private void Update()
    {
        if (Timer <= 0)
        {
            Speed = Random.Range(MinSpeed, MaxSpeed);
            Timer = Random.Range(Mintime, Maxtime);
        }
        else
        {
            Timer -= Time.deltaTime;
            Rb.velocity = Vector3.right * Speed;
        }
        if (transform.position.x >= 21)
        {
            randomvalu = Random.Range(-4.9f, 4.9f);

            transform.position = new Vector3(-21, transform.position.y, randomvalu);
        }
    }
    IEnumerator MOVE()
    {
        yield return new WaitForSeconds(0f);
        while (Timer > 0)
        {
            Rb.velocity = Vector3.forward*Speed*Time.deltaTime;
            yield return null;
        }
    }
}

