using UnityEngine;
using System.Collections;

namespace testRPG.ItemSystem
{
	public interface IISEquipable
	{
		IISEquipmentSlot equipmentSlot { get; }
		bool Equip();
	}
}
