using Entitas;
using Entitas.Unity;
using UnityEngine;

public class TrackerSystem : IInitializeSystem, IExecuteSystem {

	readonly GameContext _gameContext;
	readonly IGroup<GameEntity> _tracked;

	public TrackerSystem(Contexts contexts) {
		_gameContext = contexts.game;
		_tracked = _gameContext.GetGroup(GameMatcher.RemainingTime);
	}

	public void Initialize() {
		var go = new GameObject("Entity Tracker");
		var e = _gameContext.CreateEntity();
		e.AddEntityTracker(0);
		go.Link(e, _gameContext);
	}

	public void Execute() {
		_gameContext.entityTracker.value = _tracked.count;
	}
}