using Entitas;
using Entitas.Unity;
using UnityEngine;

public class SpawnSystem : IInitializeSystem, IExecuteSystem {

    readonly GameContext _gameContext;

    public SpawnSystem(Contexts contexts) {
        _gameContext = contexts.game;
	}

    public void Initialize() {
        var go = new GameObject("Intensity");
        var e = _gameContext.CreateEntity();
        e.AddIntensity(100, new Vector2(2f, 5f));
        go.Link(e, _gameContext);
    }

    public void Execute() {
        for (var i = 0; i < _gameContext.intensity.value; i++) {
            var e = _gameContext.CreateEntity();
            e.AddRemainingTime(Random.Range(_gameContext.intensity.range.x, _gameContext.intensity.range.y));
            if (Random.value > 0.5f) {
                e.isX = true;
            }
            if (Random.value > 0.5f) {
                e.isY = true;
            }
            if (Random.value > 0.5f) {
                e.isZ = true;
            }
        }
    }
}
