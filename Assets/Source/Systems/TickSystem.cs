using Entitas;
using UnityEngine;

public class TickSystem : IExecuteSystem {

    readonly GameContext _gameContext;

    public TickSystem(Contexts contexts) {
        _gameContext = contexts.game;
        var e = _gameContext.CreateEntity();
        e.AddTickTracker(Time.time, 0f, 1f);
    }

    public void Execute() {
		_gameContext.tickTracker.tick = Time.deltaTime * _gameContext.tickTracker.scale;
        _gameContext.tickTracker.time += _gameContext.tickTracker.tick;
    }
}