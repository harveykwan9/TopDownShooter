using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehavior : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        goRandom();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Player") {
            Debug.Log("hit detected");
            goRandom();
        }
    }


    // Called in start, gives the goal a random start.
    void goRandom()
    {
        int width = Screen.width;
        int height = Screen.height;

        Debug.Log(width);
        Debug.Log(height);
        
        float randomX = Random.Range(0 + 20,width - 20);
        float randomZ = Random.Range(0 + 20,height - 20);

        Debug.Log(randomX);
        Debug.Log(randomZ);

        Vector3 random = Camera.main.ScreenToWorldPoint(new Vector3(randomX,randomZ,15));

        GetComponent<Transform>().position = new Vector3(random.x, 0, random.z);
    }
}
