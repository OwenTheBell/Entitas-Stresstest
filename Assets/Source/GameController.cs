using Entitas;
using UnityEngine;

public class GameController : MonoBehaviour {
	
	Systems _systems;

	void Start() {
		var contexts = Contexts.sharedInstance;
		_systems = new Feature("Systems");
		_systems.Add(new TickSystem(contexts));
		_systems.Add(new SpawnSystem(contexts));
		_systems.Add(new TrackerSystem(contexts));
		_systems.Add(new CleanupSystem(contexts));
		_systems.Initialize();
	}

	void Update() {
		SideFunction();
	}

	void SideFunction() {
		_systems.Execute();
		_systems.Cleanup();
	}
}