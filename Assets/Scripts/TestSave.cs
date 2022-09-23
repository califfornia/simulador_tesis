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
        }
        else
        {
            data = new ExampleData();

            SaveData();
        }
    }

	
	public void SaveUserName(string s)
	{
		input = inpute.text;
        if(!string.Equals(data.username,input)){
            data = new ExampleData();
            SaveData();
        }
		Debug.Log (input);
		data.username = input;
        var document = new BsonDocument { { "username",input},{"FallosNivel1", 0},{"FallosNivel2", 0},{"FallosNivel3", 0},{"FallosNivel4", 0},{"FallosNivel5", 0}};
        collection.InsertOne(document);
        //var filter = Builders<BsonDocument>.Filter.Eq("username", " ");
        //var update = Builders<BsonDocument>.Update.Set("username", data.username);
        //collection.UpdateOne(filter, update);

        //
		
        SaveData();
	}
	
	public void LevelFail()
	{   

		data.levelfail++;
        var filter = Builders<BsonDocument>.Filter.Eq("username", data.username);
        var update = Builders<BsonDocument>.Update.Set("FallosNivel1", data.levelfail);
        collection.UpdateOne(filter, update);
		Debug.Log("guardo");

		SaveData();
	}
	
	public void LevelFail2()
	{
		data.levelfail2++;
        var filter = Builders<BsonDocument>.Filter.Eq("username", data.username);
        var update = Builders<BsonDocument>.Update.Set("FallosNivel2", data.levelfail2);
        collection.UpdateOne(filter, update);
		Debug.Log("guardo");
		SaveData();
	}
	
	public void LevelFail3()
	{
		data.levelfail3++;
        var filter = Builders<BsonDocument>.Filter.Eq("username", data.username);
        var update = Builders<BsonDocument>.Update.Set("FallosNivel3", data.levelfail3);
        collection.UpdateOne(filter, update);
		Debug.Log("guardo");
		SaveData();
	}
	
	public void LevelFail4()
	{
		data.levelfail4++;
        var filter = Builders<BsonDocument>.Filter.Eq("username", data.username);
        var update = Builders<BsonDocument>.Update.Set("FallosNivel4", data.levelfail4);
        collection.UpdateOne(filter, update);
		Debug.Log("guardo");
		SaveData();
	}
	
	public void LevelFail5()
	{
		data.levelfail5++;
        var filter = Builders<BsonDocument>.Filter.Eq("username", data.username);
        var update = Builders<BsonDocument>.Update.Set("FallosNivel5", data.levelfail5);
        collection.UpdateOne(filter, update);
		Debug.Log("guardo");
		SaveData();
	}
    private void SaveData()
    {
        SaveLoadSystemData.SaveData(data, pathData, nameFileData);
        
    }


}
