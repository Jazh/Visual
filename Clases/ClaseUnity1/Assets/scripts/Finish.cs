using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col) {
        if(col.tag.Equals("Player")) {
            SceneManager.LoadScene(1);
        }

        Debug.Log(col.name);
    }

}
