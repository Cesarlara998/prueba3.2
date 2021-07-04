using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChanEscene : MonoBehaviour
{
    private Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        this.scene = gameObject.scene;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.name ==  "door1") {
            if (this.scene.name == "Main") {
                SceneManager.LoadScene("Bosque");
            }
            if (this.scene.name == "Bosque") {
                SceneManager.LoadScene("Main");
            }
        }
        if (col.gameObject.name ==  "door2") {
            if (this.scene.name == "Main") {
                SceneManager.LoadScene("Playa");
            }
            if (this.scene.name == "Playa") {
                SceneManager.LoadScene("Main");
            }
        }
        if (col.gameObject.name ==  "door3") {
            if (this.scene.name == "Main") {
                SceneManager.LoadScene("Medieval");
            }
            if (this.scene.name == "Medieval") {
                SceneManager.LoadScene("Main");
            }
        }
    }
}
