using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapMovement : CommandModelObj
{
    private Stack<Vector3> vector3s = new();
    void Start()
    {
        vector3s.Push(transform.position);
    }
    public override void Execute()
    {
        transform.position += Vector3.up * Time.deltaTime;
        ObserverModel.inst.Invoke(EventEnum.test);
    }
    public override void Undo()
    {
        if (vector3s.Count > 0)
        {
            transform.position = vector3s.Pop();
        }
        else
        {
            vector3s.Push(Vector3.zero);
            transform.position = vector3s.Peek();
        }
    }
}