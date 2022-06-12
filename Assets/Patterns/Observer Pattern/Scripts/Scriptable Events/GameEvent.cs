using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
    private readonly List<GameEventListener> _gameEventListeners = new List<GameEventListener>();

    public void Raise()
    {
        for (int i = _gameEventListeners.Count - 1; i >= 0; i--)
        {
            _gameEventListeners[i].OnEventRaised();
        }
    }
    
    public void RegisterListener(GameEventListener listener)
    {
        if(!_gameEventListeners.Contains(listener))
            _gameEventListeners.Add(listener);
    }

    public void UnregisterListener(GameEventListener listener)
    {
        if (_gameEventListeners.Contains(listener))
        {
            _gameEventListeners.Remove(listener);
        }
    }
}
