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
		if (entity.Location != Location.Bank )
		{
			entity.Location = Location.Bank;
		};
	}

	public void Execute(Miner entity)
	{
		entity.MoneyInBank += entity.GoldCarried;
		Debug.Log($"{entity.Name}: Depositing {entity.GoldCarried} gold in my account. Now I have {entity.MoneyInBank} in total");
		entity.GoldCarried = 0;

		if (entity.Fatigued)
		{
			Debug.Log($"{entity.Name}: I'm feeling tired. I'm going home for a nap.");
			entity.StateMachine.ChangeState(GoHomeAndSleepUntilRested<Miner>.Instance);
		}
		else
		{
			Debug.Log($"{entity.Name}: My bag is empty. I'm going back to the Mine find more gold!");
			entity.StateMachine.ChangeState(EnterMineAndDigForNugget<Miner>.Instance);
		}
	}

	public void Exit(Miner entity)
	{
		Debug.Log($"{entity.Name}: Leaving the bank");
	}

	public bool OnMessage()
	{
		throw new System.NotImplementedException();
	}
}
