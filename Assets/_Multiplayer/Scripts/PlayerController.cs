using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3;
    public GameObject player;

    public string msg;

    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            msg = "UpdatePosition%Player1%UpdatePosition%" + (player.transform.position.x + (speed * Time.deltaTime)).ToString() + "%" + player.transform.position.y.ToString() + "%" + player.transform.position.z.ToString();
            StringReciever.Instance.ReadString(msg);
        }
        if (Input.GetKey(KeyCode.S))
        {
            msg = "UpdatePosition%Player1%UpdatePosition%" + (player.transform.position.x + (-speed * Time.deltaTime)).ToString() + "%" + player.transform.position.y.ToString() + "%" + player.transform.position.z.ToString();
            StringReciever.Instance.ReadString(msg);
        }
        if (Input.GetKey(KeyCode.A))
        {
            msg = "UpdatePosition%Player1%UpdatePosition%" + (player.transform.position.x.ToString() + "%" + player.transform.position.y.ToString() + "%" + (player.transform.position.z + (speed * Time.deltaTime))).ToString();
            StringReciever.Instance.ReadString(msg);
        }
        if (Input.GetKey(KeyCode.D))
        {
            msg = "UpdatePosition%Player1%UpdatePosition%" + (player.transform.position.x.ToString() + "%" + player.transform.position.y.ToString() + "%" + (player.transform.position.z + (-speed * Time.deltaTime))).ToString();
            StringReciever.Instance.ReadString(msg);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            msg = "UpdatePosition%Player1%UpdatePosition%" + player.transform.position.x.ToString() + "%" + (player.transform.position.y + (speed * Time.deltaTime)).ToString() + "%" + player.transform.position.z.ToString();
            StringReciever.Instance.ReadString(msg);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            msg = "UpdatePosition%Player1%UpdatePosition%" + player.transform.position.x.ToString() + "%" + (player.transform.position.y + (-speed * Time.deltaTime)).ToString() + "%" + player.transform.position.z.ToString();
            StringReciever.Instance.ReadString(msg);
        }
    }
}
