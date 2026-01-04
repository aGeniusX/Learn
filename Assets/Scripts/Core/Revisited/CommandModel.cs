using System;

public interface CommandModel
{
    /// <summary>
    /// 执行
    /// </summary>
    public abstract void Execute();
    /// <summary>
    /// 执行，指定对象
    /// </summary>
    /// <param name="obj"></param>
    public abstract void Execute(Object obj);
    /// <summary>
    /// 重新执行
    /// </summary>
    public abstract void Undo();
}