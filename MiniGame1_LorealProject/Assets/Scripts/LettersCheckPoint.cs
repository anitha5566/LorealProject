using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LettersCheckPoint : MonoBehaviour
{
    public GameObject placeHolder;
    public GameObject word;
    public char[] letters;
    int count = 0;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.tag == "Word")
        {
            for (int i = 0; i < letters.Length; i++)
            {
                if (collision.gameObject.name == letters[i].ToString())
                {
                    count++;
                    Debug.Log("Count - " + count);
                }
            }
        }
    }
    private void Update()
    {
        Debug.Log("Update");
        if(count == letters.Length)
        {
            Debug.Log("Finish");
            placeHolder.SetActive(false);
            word.SetActive(false);
        }
    }
}
