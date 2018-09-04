using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miner : MonoBehaviour, IEntity {
	private float _thirstlevel;
	private float _fatigueLevel;
	private float _timer;

	public float UpdateDelay;
	public string Name;
	public int GoldCarried;
	public int GoldCarriedLimit;
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
			StateMachine = new StateMachine<Miner>();
		}
		
		StateMachine.Entity = this;
		StateMachine.CurrentState = EnterMineAndDigForNugget<Miner>.Instance;
		_timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		_timer += Time.deltaTime;

		if (_timer >= UpdateDelay)
		{
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

			StateMachine.ExecuteState();

			_timer = 0;
		}

	}

	public void Rest()
	{
		_fatigueLevel -= 0.5f;

		if (_fatigueLevel <= 0)
		{
			_fatigueLevel = 0;
			Fatigued = false;
		}
	}

	public void Drink()
	{
		_thirstlevel = 0;
		Thirst = false;
	}
}
