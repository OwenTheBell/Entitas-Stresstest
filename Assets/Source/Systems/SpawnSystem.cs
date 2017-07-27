using Entitas;
using Entitas.Unity;
using UnityEngine;

public class SpawnSystem : IInitializeSystem, IExecuteSystem {

    readonly GameContext _gameContext;
    GameEntity _intensity;

    public SpawnSystem(Contexts contexts) {
        _gameContext = contexts.game;
	}

    public void Initialize() {
        var go = new GameObject("Intensity");
        _intensity = _gameContext.CreateEntity();
        _intensity.AddIntensity(100);
        go.Link(_intensity, _gameContext);
    }

    public void Execute() {
        for (var i = 0; i < _intensity.intensity.value; i++) {
            var e = _gameContext.CreateEntity();
            e.AddRemainingTime(Random.Range(2f, 5f));
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
