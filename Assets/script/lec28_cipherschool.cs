using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lec28_cipherschool : MonoBehaviour
{
    public GameObject InstructionPanel;

    public void ToggleInstructionPanel(string toggle) {
        if (toggle == "false")
        {
            InstructionPanel.SetActive(false);

        }
        else if(toggle == "true") {
            InstructionPanel.SetActive(true);
        }
    }

    public void ChangeCurrentScene()
    {
        //how to get current active scene and index of it(index you can see in build and setting option it is next to scenes)
        //datatype is scene
        Scene Currentscene = SceneManager.GetActiveScene();
        //index
       int  nextIndex = Currentscene.buildIndex + 1;
        SceneManager.LoadScene(nextIndex); 

    }
}
