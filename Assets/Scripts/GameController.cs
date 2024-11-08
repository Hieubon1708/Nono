using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public Box[][] boxes;

    public void Awake()
    {
        instance = this;
    }

    public void CheckBox(Box box)
    {
        if(box.mainColor == PlayerController.instance.colorSelected)
        {
            Color color;
            if (ColorUtility.TryParseHtmlString(box.mainColor, out color)) box.image.color = color;
            else Debug.LogError("Invalid hex color format!");
        }
    }

    public Box GetBox(GameObject box)
    {
        for (int i = 0; i < boxes.Length; i++)
        {
            for(int j = 0; j < boxes[i].Length; j++)
            {
                if (boxes[i][j] == box)
                {
                    return boxes[i][j];
                }
            }
        }
        return null;
    }
}
