using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public abstract class ViewBase : MonoBehaviour
{

    private static Dictionary<string, ViewBase> _views = new Dictionary<string, ViewBase>();

    public static Dictionary<string, ViewBase> views
    {
        get { return _views; }
    }

    public delegate void ViewClick(BaseEventData eventData);

    public static T AddView<T>(string name, GameObject parent, string resourcePath, Vector2 pos, Vector2 size, Vector3 scale) where T : ViewBase
    {
        if (_views.ContainsKey(name))
        {
            Debug.LogWarning("this name has already exited.");
            return null;
        }
        T view = GameObject.Instantiate(Resources.Load(resourcePath, typeof(T))) as T;
        view.name = name;
        RectTransform rectTrans = view.GetComponent<RectTransform>();
        rectTrans.SetParent(parent.transform);
        rectTrans.anchoredPosition = pos;
        rectTrans.sizeDelta = size;
        rectTrans.localScale = scale;
        _views.Add(name, view);
        return view;
    }

    public static ViewBase GetControllerBase(string name)
    {
        if (!_views.ContainsKey(name)) return null;
        return _views[name];
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
