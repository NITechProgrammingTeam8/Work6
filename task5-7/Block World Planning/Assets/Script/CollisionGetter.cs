using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionGetter : MonoBehaviour {

    public List<GameObject> colList;

    void Awake () {
        colList = new List<GameObject> ();
    }

    void OnCollisionStay (Collision collision) {
        if (!colList.Contains(collision.gameObject)) {
            colList.Add (collision.gameObject);
        }
    }
    void OnCollisionExit (Collision collision) {
        colList.Remove (collision.gameObject);
    }
}