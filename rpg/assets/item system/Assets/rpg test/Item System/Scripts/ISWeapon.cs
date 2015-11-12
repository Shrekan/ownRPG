using UnityEngine;
using UnityEditor;
using System.Collections;

namespace testRPG.ItemSystem
{
	[System.Serializable]
	public class ISWeapon : ISObject, IISWeapon, IISDestructable, IISGameObject
	{
		[SerializeField] int _minDamage;
		[SerializeField] int _durability;
		[SerializeField] int _maxDurability;
		[SerializeField] ISEquipmentSlot _equipmentSlot;
		[SerializeField] GameObject _prefab;

		public EquipmentSlot equipmentSlot;



		public ISWeapon()
		{
			_equipmentSlot = new ISEquipmentSlot ();
		}
	


		public ISWeapon( int durabitly, int maxDurability, ISEquipmentSlot equipmentSlot, GameObject prefab )
		{
			_durability = durabitly;
			_maxDurability = maxDurability;
			_equipmentSlot = equipmentSlot; 
			_prefab = prefab;
		}

		#region IISGameObject implementation

		public GameObject Prefab 
		{
			get { return _prefab; }
		}

		#endregion

		#region IISEquipable implementation

		public IISEquipmentSlot EquipmentSlot 
		{
			get { return _equipmentSlot; }
		}

		#endregion

		#region IISDestructable implementation

		public void TakeDamage (int amount)
		{
			_durability -= amount;

			if( _durability < 0)
				_durability = 0;

		}

		public void Repair ()
		{
			if(_maxDurability > 0)
				_durability = _maxDurability;
		}


		// reduce the durability to 0;
		public void Break ()
		{
			_durability = 0;
		}



		public int Durability 
		{
			get { return _durability; }
		}



		public int MaxDurability {
			get { return _maxDurability; }
		}

		#endregion

		#region IISWeapon implementation
		public int Attack ()
		{
			throw new System.NotImplementedException ();
		}
		public int MinDamage 
		{
			get { return _minDamage; }
			set { _minDamage = value; }
		}
		#endregion
			
// 	This Code is going to be placed in a new class later on
		public override void OnGUI()
		{
			base.OnGUI ();

			_minDamage = System.Convert.ToInt32 (EditorGUILayout.TextField("Damage", _minDamage.ToString()) );
			_durability = System.Convert.ToInt32 (EditorGUILayout.TextField("Durability", _durability.ToString ()) );
			_maxDurability = System.Convert.ToInt32 (EditorGUILayout.TextField("MaxDurability", _maxDurability.ToString ()) );


			DisplayEquipmentSlot();
			DisplayPrefab();
		}

		public void DisplayEquipmentSlot()
		{
			equipmentSlot = (EquipmentSlot)EditorGUILayout.EnumPopup("Equipment Slot", equipmentSlot);	
		}


		public void DisplayPrefab()
		{
			_prefab = EditorGUILayout.ObjectField("Icon", _prefab, typeof(GameObject), false) as GameObject;
		}

	}
}
