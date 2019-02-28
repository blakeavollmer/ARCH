using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    
    Button myButton;
    Sprite yellow;
    Sprite purple;

    public void ChangeSprite()
    {
        myButton.GetComponent<Image>().sprite = purple;
    }

        public void ChangeScene(int changeTheScene)
    {
        SceneManager.LoadScene(changeTheScene);
    }
}

