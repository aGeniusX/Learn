using UnityEngine;

/// <summary>
/// 接受指令的obj
/// </summary>
public class RevisitCommandObj : MonoBehaviour, RevisitCommand
{
    public virtual void Execute() { }

    public virtual void Execute(object obj) { }

    public virtual void Undo() { }
}