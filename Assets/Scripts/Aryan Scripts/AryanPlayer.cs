using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AryanPlayer : MonoBehaviour{
    
    [SerializeField] private float moveSpeed = 7f;

    private void Update() { 
        /* 
        everything under this function will run for all frames
        */

        Vector2 inputVector = new Vector2(0,0);

        if (Input.GetKey(KeyCode.W)) {
            // Debug.Log("Pressing");  // This debug log will print this message in the console of unity
            inputVector.y = +1;
        } 
        if (Input.GetKey(KeyCode.S)) {
            inputVector.y = -1;
        } 
        if (Input.GetKey(KeyCode.A)) {
            inputVector.x = -1;
        } 
        if (Input.GetKey(KeyCode.D)) {
            inputVector.x = +1;
        } 

        inputVector = inputVector.normalized;

        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.position += moveDir * moveSpeed * Time.deltaTime; // transform in attribute of my game object ego car. Time.deltaTime returns how much time it takes per frame update
    
        
    }
}
