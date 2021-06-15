using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Update called 1000 per sec (i think)
    void FixedUpdate() {
        movementInput();
        lookAtMouse();
    }

    // Rotate the player based on the mouse location on the screen
    // Referenced Dusk on the Unity Forums:
    // https://answers.unity.com/questions/10615/rotate-objectweapon-towards-mouse-cursor-2d.html
    private void lookAtMouse() {
        Vector3 mouse_pos = Input.mousePosition;
        Vector3 player_pos = Camera.main.WorldToScreenPoint(GetComponent<Transform>().position);
        float angle = Mathf.Atan2(mouse_pos.x - player_pos.x, mouse_pos.y - player_pos.y) * Mathf.Rad2Deg;
        GetComponent<Transform>().rotation = Quaternion.Euler(0,angle,0);
    }


    // Checks for user input - standard wasd setup for movement across the plane
    private void movementInput() {
        if (Input.GetKey("w")) {
            GetComponent<Rigidbody>().AddForce(Vector3.forward, ForceMode.Impulse);
        }

        if (Input.GetKey("s")) {
            GetComponent<Rigidbody>().AddForce(Vector3.back, ForceMode.Impulse);
        }

        if (Input.GetKey("a")) {
            GetComponent<Rigidbody>().AddForce(Vector3.left, ForceMode.Impulse);
        }

        if (Input.GetKey("d")) {
            GetComponent<Rigidbody>().AddForce(Vector3.right, ForceMode.Impulse);
        }

    }
}
