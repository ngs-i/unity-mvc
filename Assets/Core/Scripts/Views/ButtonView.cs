using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonView : ViewBase
{

    [SerializeField]
    private Button _button;
    [SerializeField]
    private Text _text;

    public Button button
    {
        get { return _button; }
    }

    public Text text
    {
        get { return _text; }
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
