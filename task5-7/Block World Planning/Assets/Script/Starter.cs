using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    public GameObject master;
    public GameObject[] hiddenObj;

    void Begin()
    {
        foreach(GameObject obj in hiddenObj)
        {
            obj.SetActive(false);
        }
    }
}
