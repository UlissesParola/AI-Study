using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miner : MonoBehaviour, IEntity {
	private float _thirstlevel;
	private float _fatigueLevel;


	public string Name;
	public int GoldCarried;
	public int MoneyInBank;
	public bool Thirst;
	public float ThirstLimit;
	public bool Fatigued;
	public float FatigueLimit;
	public Location Location;
	public StateMachine<Miner> StateMachine;


	// Use this for initialization
	void Start () {
		if (StateMachine == null)
		{
			StateMachine = gameObject.AddComponent<StateMachine<Miner>>();
		}
		
		StateMachine.Entity = this;
		StateMachine.CurrentState = EnterMineAndDigForNugget<Miner>.Instance;

	}
	
	// Update is called once per frame
	void Update () {
		_thirstlevel += 0.1f;
		if (_thirstlevel >= ThirstLimit)
		{
			Thirst = true;
		}

		_fatigueLevel += 0.2f;
		if (_fatigueLevel >= FatigueLimit)
		{
			Fatigued = true;
		}
	}
}
