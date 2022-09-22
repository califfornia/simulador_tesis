using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TestSave : MonoBehaviour
{
    /*public TextMeshProUGUI levelText;
    public TextMeshProUGUI expText;
    public Image imageColor;*/
	public Button repetir;
	public InputField inpute;
	private string input;

    public ExampleData data;

    public const string pathData = "Data/test";
    public const string nameFileData = "ExampleData";

    private void Start()
    {
        var dataFound = SaveLoadSystemData.LoadData<ExampleData>(pathData, nameFileData);
        if (dataFound != null)
        {
            data = dataFound;
            //ChangeValues();
        }
        else
        {
            data = new ExampleData();
            SaveData();
        }
    }
	
	public void SaveUserName(string s)
	{
		input = s;
		Debug.Log (input);
		data.username = input;
		SaveData();
	}
	
	public void LevelFail()
	{
		data.levelfail++;
		Debug.Log("guardo");
		SaveData();
	}
	
	public void LevelFail2()
	{
		data.levelfail2++;
		Debug.Log("guardo");
		SaveData();
	}
	
	public void LevelFail3()
	{
		data.levelfail3++;
		Debug.Log("guardo");
		SaveData();
	}
	
	public void LevelFail4()
	{
		data.levelfail4++;
		Debug.Log("guardo");
		SaveData();
	}
	
	public void LevelFail5()
	{
		data.levelfail5++;
		Debug.Log("guardo");
		SaveData();
	}

    /*public void OnButtonChangeColor(string newColor)
    {
        data.color = newColor;
        ChangeValues();
        SaveData();
    }
    public void OnButtonGiveExp()
    {
        data.exp += 20;
        if (data.exp >= 100)
        {
            data.exp = 0;
            data.level++;
        }
        ChangeValues();
        SaveData();
    }

    private void ChangeValues()
    {
        levelText.text = "Level : " + data.level;
        expText.text = "Experience : " + data.exp;
        if (data.color == "red")
        {
            imageColor.color = Color.red;
        }
        else if (data.color == "blue")
        {
            imageColor.color = Color.blue;
        }
        else if (data.color == "green")
        {
            imageColor.color = Color.green;
        }
    }*/

    private void SaveData()
    {
        SaveLoadSystemData.SaveData(data, pathData, nameFileData);
    }

//prueba
}
