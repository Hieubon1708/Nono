using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Box : MonoBehaviour, IPointerClickHandler
{
    public bool isVisible;
    public string mainColor;
    public Image image;

    public void OnPointerClick(PointerEventData eventData)
    {
        if(isVisible) return;
        GameController.instance.CheckBox(this);
    }
}
