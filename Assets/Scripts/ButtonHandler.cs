using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;



public class ButtonHandler : MonoBehaviour
{

    //These bools are just so you can easily choose which level you would like to load
    //Enable only the level you want in the editor

    public bool floor1;
    public bool floor2;
    public bool floor3;


    void OnTriggerEnter(Collider Other) //Senses when an controller touches the object
    {
        if (Other.tag == "VrController")
        {
            if (floor1 == true)
            {
                SceneManager.LoadScene("Scene1"); //This will load the scene that is named "Floor One" change the scene name in the script
            }
            else if (floor2 == true)
            {
                SceneManager.LoadScene("Scene2"); // loads a scene called "Floor Two"
            }
            else if (floor3 == true)
            {
                SceneManager.LoadScene("Scene3");
            }
            else
            {
                Debug.Log("Multiple bools were enabled on one object");
            }
        }
    }

}
