using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")] // allows a menu to appear in Unity under "create"
public class State : ScriptableObject
{
    // Start is called before the first frame update
    [TextArea(10,14)] [SerializeField] string storyText; //TextArea allows you to have more space in unity inspector when writing. First number is min size, sec number is amount of lines before scroll

    public string GetStateStory()
    {
        return storyText;
    }
}
