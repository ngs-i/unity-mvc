using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using ApplicationConfig;

public class TabElement : ViewBase {

    [SerializeField]
    private TabElementType _elementType;
    [SerializeField]
    private EventTrigger _eventTrigger;

    public TabElementType elementType
    {
        get { return _elementType; }
        set { _elementType = value; }
    }

    public EventTrigger eventTrigger
    {
        get { return _eventTrigger; }
        set { _eventTrigger = value; }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
