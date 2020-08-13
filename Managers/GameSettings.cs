using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Manager/GameSettings")]
public class GameSettings : ScriptableObject
{
    [SerializeField]
    private string _gameVersion = "0.0.0";
    [SerializeField]
    public string GameVersion { get { return _gameVersion; } }
    [SerializeField]
    private string _nickname = "MainPlayer";
    public string NickName
    {
        get
        {
            int randomValue = Random.Range(0, 99999);
            return _nickname + randomValue.ToString();
        }
    }
}
