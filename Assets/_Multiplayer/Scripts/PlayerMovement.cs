using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public string id = "Player";
    public int indexId = 0;

    public float speed = 5;
    private Vector3 newPos = Vector3.zero;

    private void Start()
    {
        StringReciever.Instance.AddObject(id, gameObject);
    }

    private void Update()
    {
        MoveToPos();
    }

    public void UpdatePosition(Vector3 loc)
    {
        newPos = loc;
    }

    private void MoveToPos()
    {
        float step = (speed * Time.deltaTime) * (Vector3.Distance(transform.position,newPos));
        transform.position = Vector3.MoveTowards(transform.position, newPos, step);
    }
}
