using System;
using System.Collections.Generic;
using UnityEngine;

public class ObserverModel
{
    public static readonly ObserverModel inst = new();
    private ObserverComponent observer = new();
    public void Invoke(EventEnum id)
    {
        observer.InvokeEvent(id);
    }
    public void AddObserver(EventEnum id, Action action)
    {
        observer.AddEvent(id, action);
    }
    public void RemoveObserver(EventEnum id, Action action)
    {
        observer.RemoveEvent(id, action);
    }
}

public class ObserverComponent
{
    private readonly Dictionary<EventEnum, LinkedList<Action>> events = new();
    public void AddEvent(EventEnum Id, Action action)
    {
        if (!events.ContainsKey(Id))
        {
            events[Id] = new();
        }
        events[Id].AddLast(action);
    }
    public void RemoveEvent(EventEnum Id, Action action)
    {
        if (events.ContainsKey(Id))
        {
            events[Id].Remove(action);
        }
    }       
    public void InvokeEvent(EventEnum Id)
    {
        if (events.ContainsKey(Id))
        {
            foreach (var item in events[Id])
            {
                item.Invoke();
            }
        }
    }
}
