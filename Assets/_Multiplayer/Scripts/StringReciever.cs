using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringReciever : MonoBehaviour
{
    public static StringReciever Instance;

    public string recievedMsg;
    public string recievedMsg2;
    public List<string> lastMessage;

    public Dictionary<string, GameObject> entities = new Dictionary<string, GameObject>();
    public Dictionary<string, System.Action> functions = new Dictionary<string, System.Action>();

    void Awake()
    {
        if (StringReciever.Instance == null)
            StringReciever.Instance = this;
        else
            Destroy(this.gameObject);
    }

    void Start()
    {             

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
            entities[lastMessage[1]].SendMessage(lastMessage[0],new Vector3(float.Parse(lastMessage[3]), float.Parse(lastMessage[4]), float.Parse(lastMessage[5])));//calls function from dictionary, based on msg[0]
        }
        catch (System.Exception)
        {

            throw;
        }

        lastMessage.Clear();        
    }    

    public void AddObject(string id, GameObject g)//adds gameobject to dictionary with id
    {
        entities.Add(id,g);
    }

    public void AddFunction(string id, System.Action a)//function gameobject to dictionary with id
    {
        functions.Add(id,a);
    }

    private void UpdatePosition()//updates position of called player
    {
        entities[lastMessage[1]].transform.position = new Vector3(int.Parse(lastMessage[3]), int.Parse(lastMessage[4]), int.Parse(lastMessage[5]));
    }

}
