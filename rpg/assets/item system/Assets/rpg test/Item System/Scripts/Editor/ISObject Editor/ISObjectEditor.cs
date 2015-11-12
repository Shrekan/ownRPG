using UnityEditor;
using UnityEngine;
using System.Collections;

namespace testRPG.ItemSystem.Editor
{
	public partial class ISObjectEditor : EditorWindow  
	{

		ISWeaponDatabase database;
		
		const string Database_Name = @"ShrekanWeaponDatabase.asset";
		const string Database_Path = @"Database";
		const string DATABASE_FULL_PATH = @"Assets/"+ Database_Path + "/" + Database_Name;



		[MenuItem("Shrekan/Database/Item System Editor %#i")]
		public static void Init()
		{
			ISObjectEditor  window = EditorWindow.GetWindow<ISObjectEditor>();
			window.minSize = new Vector2(800, 600);
			GUIContent titleContent = new GUIContent ("Item System"); //google
			window.titleContent = titleContent;
			window.Show ();
		}

		void OnEnable()
		{
			if( database == null)
				database = ISWeaponDatabase.GetDatabase<ISWeaponDatabase>(Database_Path, Database_Name);
		}



		void OnGUI()
		{
			TopTabBar(); 
			GUILayout.BeginHorizontal();
			ListView();
			ItemDetails();
			GUILayout.EndHorizontal();
			BottomStatusBar();
		}
	}
}
