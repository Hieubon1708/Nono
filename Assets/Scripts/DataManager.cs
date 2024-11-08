using Newtonsoft.Json;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public enum LevelType
    {
        Level5x5, Level10x10, Level15x15, Level20x20
    }

    public LevelConfig[] level5x5;
    public LevelConfig[] level10x10;
    public LevelConfig[] level15x15;
    public LevelConfig[] level20x20;

    public LevelOrderConfig levelOrder;
    public SizeConfig[] sizeConfig;   

    public void DataReader()
    {
        TextAsset level5x5Js = Resources.Load<TextAsset>("Datas/Level5x5");
        TextAsset level10x10Js = Resources.Load<TextAsset>("Datas/Level10x10");
        TextAsset level15x15Js = Resources.Load<TextAsset>("Datas/Level15x15");
        TextAsset level20x20Js = Resources.Load<TextAsset>("Datas/Level20x20");

        TextAsset levelOrderJs = Resources.Load<TextAsset>("Datas/LevelOrder");
        TextAsset sizeConfigJs = Resources.Load<TextAsset>("Datas/LevelOrder");

        level5x5 = JsonConvert.DeserializeObject<LevelConfig[]>(level5x5Js.text);
        level10x10 = JsonConvert.DeserializeObject<LevelConfig[]>(level10x10Js.text);
        level15x15 = JsonConvert.DeserializeObject<LevelConfig[]>(level15x15Js.text);
        level20x20 = JsonConvert.DeserializeObject<LevelConfig[]>(level20x20Js.text);

        levelOrder = JsonConvert.DeserializeObject<LevelOrderConfig>(levelOrderJs.text);
        sizeConfig = JsonConvert.DeserializeObject<SizeConfig[]>(sizeConfigJs.text);
    }

    public void SaveLevel()
    {

    }
}

[System.Serializable]
public class LevelOrderConfig
{
    public LevelTypeInOrderConfig[] levelTypeInOrderConfigs;
}

[System.Serializable]
public class SizeConfig
{
    public float cellSize;
    public float spacing;
    public int contrainCount;
    public float fontSize;
    public float spacingCluster;
    public float paddingLeftCluster;
    public float paddingRightCluster;
    public float paddingTopCluster;
    public float paddingBotCluster;
}

[System.Serializable]
public class LevelTypeInOrderConfig
{
    public DataManager.LevelType levelType;
    public int indexInList;
}

[System.Serializable]
public class LevelConfig
{
    public string backgroundColor;  
    public string[] mainColors;
    public BoxConfig[][] boxConfigs;
}

[System.Serializable]
public class BoxConfig
{
    public string mainColor;
    public string extraColor;

    public BoxIndexConfig[] rowClusters;
    public BoxIndexConfig[] colClusters;
}

[System.Serializable]
public class BoxIndexConfig
{
    public int rowIndex;
    public int colIndex;
}

