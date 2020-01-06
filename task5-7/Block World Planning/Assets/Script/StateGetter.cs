using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateGetter : MonoBehaviour {

    public GameObject target;

    public void FocusOutline (GameObject newObj) {
        if (target != null) {
            target.GetComponent<Outline> ().enabled = false;
        }
        if (newObj != null) {
            newObj.GetComponent<Outline> ().enabled = true;
        }
        target = newObj;
    }

    public Text status;

    void Update () {
        if (target != null) {
            status.text = "[" + target.name + "]";

            foreach (GameObject obj in target.GetComponent<CollisionGetter> ().colList) {
                if (obj != null) {  // Removeした物体を除外
                    status.text += "\n" + obj.name;
                }
            }
        }
    }
}