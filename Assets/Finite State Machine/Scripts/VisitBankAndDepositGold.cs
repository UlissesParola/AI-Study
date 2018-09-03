using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitBankAndDepositGold<T> : IState<Miner> {
	private static VisitBankAndDepositGold<Miner> _instace;

	public static VisitBankAndDepositGold<Miner> Instace
	{
		get
		{
			if (_instace == null)
			{
				_instace = new VisitBankAndDepositGold<Miner>();
			}

			return _instace;
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
