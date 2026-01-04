using UnityEngine;

public class TestSingleton : PersistentMonoSingleton<TestSingleton>
{
    public int testNum = 3;
}