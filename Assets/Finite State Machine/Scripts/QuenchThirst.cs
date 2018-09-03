using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuenchThirst<T> : IState<Miner> {

	private static QuenchThirst<Miner> _instance;
	public static QuenchThirst<Miner> Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = new QuenchThirst<Miner>();
			}

			return _instance;
		}
	}

	public void Enter(Miner entity)
	{
		throw new System.NotImplementedException();
	}

	public void Execute(Miner entity)
	{
		throw new System.NotImplementedException();
	}

	public void Exit(Miner entity)
	{
		throw new System.NotImplementedException();
	}

	public bool OnMessage()
	{
		throw new System.NotImplementedException();
	}

	


}
