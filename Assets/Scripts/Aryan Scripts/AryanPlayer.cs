using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AryanPlayer : MonoBehaviour{


    private void Update() { // everything under this function will run for all frames
        if (Input.GetKey(KeyCode.W)) {
            Debug.Log("Pressing");
        } else {
            Debug.Log("-");
        }
    }
}
