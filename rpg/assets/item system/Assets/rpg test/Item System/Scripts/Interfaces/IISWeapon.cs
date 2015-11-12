using UnityEngine;
using System.Collections;

namespace testRPG.ItemSystem
{
	public interface IISWeapon
	{
		int MinDamage {get; set; }
		int Attack ();

	}
}
