using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    public string colorSelected;

    public void Awake()
    {
        instance = this;
    }
}
