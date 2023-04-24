using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json;

public class ApiTest : MonoBehaviour
{
    public CardModel[] cardModels;

    private void Start()
    {
        
        UnityWebRequest request = UnityWebRequest.Get("http://172.18.12.16:6000/game?user=ecogamer"); //Creates a get request object with appropriate data
        IEnumerator requestExecution = APIHelper.ExecuteRequest(request, OnSuccess); //Bundles the request into a task 
        StartCoroutine(requestExecution); //executes the request

    }

    //This function executes if the get request is successful
    void OnSuccess(UnityWebRequest request)
    {
        Debug.Log("hi");
        string jsonString = request.downloadHandler.text; //convert the response[in bytes] to a readable string
        cardModels = JsonConvert.DeserializeObject<CardModel[]>(jsonString); //Creates card model objects and populates there fields with the appropriate data 
    }

}

[System.Serializable]
public class CardModel
{
      //[JsonProperty("user")] //Safer method to specifiy which fields in the json go to which fields in the class
      //public string user;
     [JsonProperty("id")]
       public int id;
    [JsonProperty("cardset")]
    public string cardset;
    [JsonProperty("faction")]
    public int faction;

}
