using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ChangeButtonColor : MonoBehaviour
{
    public Button myButton;
    public Sprite yellow;
    public Sprite purple;
    
    
    void Start()
    {
        myButton = GetComponent<Button>();
    }
    
  
}