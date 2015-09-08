using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

using ApplicationConfig;

public class MenuController : ControllerBase {

    private TabBar _tabBar;
    private MenuContents _menuContents;

	// Use this for initialization
	void Start () {
        Debug.Log("HomeController.Start()");
        // TabViewの生成
        _tabBar = CreateTabView();
        // MenuContentsの生成
        _menuContents = CreateMenuContents();
	}

    private TabBar CreateTabView()
    {
        Vector2 pos = new Vector2(0, 56);
        Vector2 size = new Vector2(0, 112);
        Vector3 scale = Vector3.one;
        TabBar tabBar = ViewBase.AddView<TabBar>("TabBar", SceneLoader.Instance.canvas, "Views/TabBar", pos, size, scale);
        tabBar.AddTabListener(TabElementType.Home, new ViewBase.ViewClick(OnClickHome));
        tabBar.AddTabListener(TabElementType.Levels, new ViewBase.ViewClick(OnClickLevels));
        tabBar.AddTabListener(TabElementType.Equipments, new ViewBase.ViewClick(OnClickEquipments));
        tabBar.AddTabListener(TabElementType.Shop, new ViewBase.ViewClick(OnClickShop));
        tabBar.AddTabListener(TabElementType.Options, new ViewBase.ViewClick(OnClickOptions));
        return tabBar;
    }

    private MenuContents CreateMenuContents()
    {
        Vector2 pos = Vector2.zero;
        Vector2 size = new Vector2(0, 0);
        Vector3 scale = Vector3.one;
        MenuContents menuContents = ViewBase.AddView<MenuContents>("MenuContents", SceneLoader.Instance.canvas, "Views/MenuContents", pos, size, scale);
        return menuContents;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnClickHome(BaseEventData eventData)
    {
        Debug.Log("OnClickHome");
        _menuContents.animator.SetTrigger("Home");
    }

    private void OnClickLevels(BaseEventData eventData)
    {
        Debug.Log("OnClickLevels");
        _menuContents.animator.SetTrigger("Levels");
    }

    private void OnClickEquipments(BaseEventData eventData)
    {
        Debug.Log("OnClickEquipments");
        _menuContents.animator.SetTrigger("Equipments");
    }

    private void OnClickShop(BaseEventData eventData)
    {
        Debug.Log("OnClickShop");
        _menuContents.animator.SetTrigger("Shop");
    }

    private void OnClickOptions(BaseEventData eventData)
    {
        Debug.Log("OnClickOptions");
        _menuContents.animator.SetTrigger("Options");
    }
}
