using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringReciever : MonoBehaviour
{
    public string recievedMsg;
    public List<string> lastMessage;

    public GameObject player1;

    public Dictionary<string, GameObject> players = new Dictionary<string, GameObject>();
    public Dictionary<string, System.Action> functions = new Dictionary<string, System.Action>();

    void Start()
    {
        AddFunction("UpdatePosition", UpdatePosition);
        AddObject("Player1", player1);
        ReadString(recievedMsg);
    }

    public void ReadString(string msg)//reads and splits message
    {
        string[] words = msg.Split('%');

        foreach (var word in words)
        {
            lastMessage.Add(word);
        }

        try
        {
            functions[lastMessage[0]]();//calls function from dictionary, based on msg[0]
        }
        catch (System.Exception)
        {

            throw;
        }
        
    }    

    public void AddObject(string id, GameObject g)//adds gameobject to dictionary with id
    {
        players.Add(id,g);
    }

    public void AddFunction(string id, System.Action a)//function gameobject to dictionary with id
    {
        functions.Add(id,a);
    }

    private void UpdatePosition()
    {
        players[lastMessage[1]].transform.position = new Vector3(int.Parse(lastMessage[3]), int.Parse(lastMessage[4]), int.Parse(lastMessage[5]));
    }

    private void PerformFunction()
    {
        if (lastMessage[1] == "Player1")
        {
            Invoke(lastMessage[2], 0f);
        }
    }
}
