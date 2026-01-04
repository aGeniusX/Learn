using UnityEngine;

public class PersistentMonoSingleton<T> : SingletonModel<T> where T : PersistentMonoSingleton<T>
{
    protected override void Awake()
    {
        base.Awake();
        if (_instance != null)
        {
            DontDestroyOnLoad(this);
        }
    }
}