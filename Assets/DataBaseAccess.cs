using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using MongoDB.Driver;
using MongoDB.Bson;

public class DataBaseAccess : MonoBehaviour
{
    private const string MONGO_URI = "mongodb+srv://LuisFeGomez:Simulador2022@cluster0.2jlef.mongodb.net/?retryWrites=true&w=majority";
    private const string DATABASE_NAME = "Simulador";
    private MongoClient client = new MongoClient(MONGO_URI);
    private IMongoDatabase db;
    private IMongoCollection<BsonDocument> collection;
    // Start is called before the first frame update
    void Start()
    {
        db = client.GetDatabase(DATABASE_NAME);
        collection = db.GetCollection<BsonDocument>("intentos"); 
        var document = new BsonDocument { { "username", "Prueba"},{"Puntuacion Nivel1", 0},{"FallosNivel1", 0},{"Puntuacion Nivel2", 0},{"FallosNivel2", 0},{"Puntuacion Nivel3", 0},{"FallosNivel3", 0},{"Puntuacion Nivel4", 0},{"FallosNivel4", 0},{"Puntuacion Nivel5", 0},{"FallosNivel5", 0}};
        collection.InsertOne(document);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
