using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectOnList : MonoBehaviour
{
    public GameObject master;
    public GameObject rm;

    void Awake()
    {
        master = GameObject.Find("Master");
        rm = GameObject.Find("ButtonRm");
    }

    public void Select()
    {
        master.GetComponent<StateGetter>().FocusOutline(GetComponent<Manager>().planObj);
        rm.GetComponent<Destroyer>().target = this.gameObject;
    }
}
