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
        ObserverModel.inst.AddObserver(EventEnum.test, test5Height);
        ObserverModel.inst.AddObserver(EventEnum.test, test10Height);
    }
    public override void Execute()
    {
        transform.position += Vector3.up * Time.deltaTime;
        if (transform.position.y > 5)
        {
            ObserverModel.inst.Invoke(EventEnum.test);
            if (transform.position.y > 10)
            {
                ObserverModel.inst.RemoveObserver(EventEnum.test, test5Height);
                ObserverModel.inst.Invoke(EventEnum.test);
            }
        }
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
    private void test5Height()
    {
        Debug.Log($"已到达既定位置5 {transform.position}");
    }
    private void test10Height()
    {
        Debug.Log($"已到达既定位置10 {transform.position}");
    }
}