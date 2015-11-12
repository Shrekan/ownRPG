using UnityEngine;
using UnityEditor;
using System.Collections;

namespace testRPG.ItemSystem
{
[System.Serializable]
	public class ISObject : IISObject
	{
		[SerializeField]string _name;
		[SerializeField]int _value;
		[SerializeField]Sprite _icon;
		[SerializeField]ISQuality _quality;

		public string Name {
			get { return _name; }
			set { _name = value; }
		}

		public int Value {
			get { return _value; }
			set { _value = value; }
		}

		public Sprite Icon {
			get { return _icon; }
			set { _icon = value; }
		}

		public ISQuality Quality {
			get { return _quality; }
			set { _quality = value; }
		}



// 	This Code is going to be placed in a new class later on		
		ISQualityDatabase qdb;
		int qualitySelectedIndex = 0;
		string[] option;

		public virtual void OnGUI()
		{
			GUILayout.BeginVertical();
			_name = EditorGUILayout.TextField("Name", _name);
			_value = System.Convert.ToInt32 (EditorGUILayout.TextField("Value", _value.ToString()) );
			DisplayIcon();
			DisplayQuality();
			GUILayout.EndVertical();
		}

		public void DisplayIcon()
		{
				_icon = EditorGUILayout.ObjectField("Icon", _icon, typeof(Sprite), false) as Sprite;
		}


		public int SelectedQualityID
		{
			get { return qualitySelectedIndex; }
		}


		public ISObject()
		{
			string Database_Name = @"ShrekanQualityDatabase.asset";
			string Database_Path = @"Database";
			qdb = ISQualityDatabase.GetDatabase<ISQualityDatabase>(Database_Path, Database_Name);

			option = new string[qdb.Count];
			for(int cnt = 0; cnt < qdb.Count; cnt++)
				option[cnt] = qdb.Get(cnt).Name;

		}

		public void DisplayQuality()
		{
			qualitySelectedIndex = EditorGUILayout.Popup("Quality", qualitySelectedIndex, option);
			_quality = qdb.Get(SelectedQualityID);
		}
	}
}