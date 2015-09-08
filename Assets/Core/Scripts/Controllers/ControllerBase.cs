using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public abstract class ControllerBase : MonoBehaviour
{

    private static Dictionary<string, ControllerBase> _controllers = new Dictionary<string, ControllerBase>();

    public static Dictionary<string, ControllerBase> controllers
    {
        get { return _controllers; }
    }

    public static T AddController<T>(string name, GameObject parent, string resourcePath) where T : ControllerBase
    {
        if (_controllers.ContainsKey(name))
        {
            Debug.LogWarning("this name has already exited.");
            return null;
        }
        T controller = GameObject.Instantiate(Resources.Load(resourcePath, typeof(T))) as T;
        controller.name = name;
        Transform controllerTrans = controller.GetComponent<Transform>();
        controllerTrans.SetParent(parent.transform);
        controllerTrans.localPosition = Vector3.zero;
        controllerTrans.localScale = Vector3.one;
        _controllers.Add(name, controller);
        return controller;
    }

    public static ControllerBase GetControllerBase(string name)
    {
        if (!_controllers.ContainsKey(name)) return null;
        return _controllers[name];
    }

    // Use this for initialization
    void Start()
    {
        Debug.Log("ControllerBase.Start()");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
