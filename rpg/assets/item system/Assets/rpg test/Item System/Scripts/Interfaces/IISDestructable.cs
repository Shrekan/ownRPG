using UnityEngine;
using System.Collections;

namespace testRPG.ItemSystem
{
	public interface IISDestructable
	{
		//durabillity
		int Durability { get; }
		int MaxDurability { get; }

		//takedamage
		void TakeDamage(int amount);
		void Repair();
		void Break();


	}
}
