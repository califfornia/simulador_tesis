using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using MongoDB.Driver;
using MongoDB.Bson;



public class TestSave : MonoBehaviour
{
    /*public TextMeshProUGUI levelText;
    public TextMeshProUGUI expText;
    public Image imageColor;*/
    //mongodb
    private const string MONGO_URI = "mongodb+srv://LuisFeGomez:Simulador2022@cluster0.2jlef.mongodb.net/?retryWrites=true&w=majority";
    private const string DATABASE_NAME = "Simulador";
    private MongoClient client = new MongoClient(MONGO_URI);
    private IMongoDatabase db;
    private IMongoCollection<BsonDocument> collection;
    //-------------


	public Button repetir;
	public InputField inpute;
	private string input;

    public ExampleData data;

    public const string pathData = "Data/test";
    public const string nameFileData = "ExampleData";

    private void Start()
    {
        //-------------------
        db = client.GetDatabase(DATABASE_NAME);
        collection = db.GetCollection<BsonDocument>("intentos");

        
        //--------------

        var dataFound = SaveLoadSystemData.LoadData<ExampleData>(pathData, nameFileData);
        if (dataFound != null)
        {
            data = dataFound;
            //ChangeValues();
        }
        else
        {
            data = new ExampleData();
            //SaveData();
        }
    }
	
	public void SaveUserName(string s)
	{
		input = s;
		Debug.Log (input);
		data.username = input;
        create();
		//SaveData();
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

    private void create(){
        var document = new BsonDocument { { "username", data.username},{"FallosNivel1", 0},{"FallosNivel2", 0},{"FallosNivel3", 0},{"FallosNivel4", 0},{"FallosNivel5", 0}};
        collection.InsertOne(document);
    }
    private void SaveData()
    {
        //var document = new BsonDocument { { "username", data.username ["username2", data.username]}};
        SaveLoadSystemData.SaveData(data, pathData, nameFileData);
        //var json = new JavaScriptSerializer().Serialize(data);
        //BsonDocument document = BsonDocument.Parse(datos);
        var update = new BsonDocument { { "username", data.username},{"FallosNivel1", data.levelfail},{"FallosNivel2", data.levelfail2},{"FallosNivel3", data.levelfail3},{"FallosNivel4", data.levelfail4},{"FallosNivel5", data.levelfail5}};
        var filU = "{username:{$eq:'" + data.username+"'}}";
        collection.ReplaceOne(filU , update);
        //db.collection.updateOne({username: data.username}, update);
    }


}
