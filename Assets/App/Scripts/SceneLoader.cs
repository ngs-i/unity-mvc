using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SceneLoader : Singleton<SceneLoader>
{
    public enum Scene
    {
        Menu,
    }
    [SerializeField]
    public GameObject canvas;
    [SerializeField]
    public Scene firstScene;

    //private Dictionary<Scene, GameObject> _sceneObjects = new Dictionary<Scene,GameObject>();

	// Use this for initialization
    void Start()
    {
        Debug.Log("SceneLoader.Start()");
        string sceneName = firstScene.ToString();
        ControllerBase.AddController<MenuController>(sceneName, this.gameObject, "Controllers/" + sceneName);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
