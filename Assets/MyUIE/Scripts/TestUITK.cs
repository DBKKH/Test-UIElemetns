using System;
using UnityEngine;
using UnityEngine.UIElements;

public class TestUITK : MonoBehaviour
{
    [SerializeField] UIDocument uiDocument;
    [SerializeField] string buttonName, labelName;
    
    // Start is called before the first frame update
    void Start()
    {
        var visualElement = uiDocument.rootVisualElement;
        var button = visualElement.Q<Button>(buttonName);
        button.clickable.clicked += () => Debug.Log("button is clicked.");

        var text = visualElement.Q<Label>(labelName);
        text.text = "This is UIE text label.";
    }
}


