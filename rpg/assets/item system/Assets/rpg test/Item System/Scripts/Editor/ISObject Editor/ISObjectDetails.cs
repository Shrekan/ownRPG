using UnityEngine;
using System.Collections;

namespace testRPG.ItemSystem.Editor
{
	public partial class ISObjectEditor
	{
		ISWeapon tempWeapon = new ISWeapon();
		bool showNewWeaponDetails = false;

		void ItemDetails()
		{
			GUILayout.BeginVertical("Box", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
			GUILayout.BeginVertical(GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));

			if(showNewWeaponDetails)
				DisplayNewWeapon();



			GUILayout.EndVertical();
			GUILayout.Space(50);
			GUILayout.BeginHorizontal(GUILayout.ExpandWidth(true));
			DisplayButtons();
			GUILayout.EndHorizontal();
			GUILayout.EndVertical ();

		}


		void DisplayNewWeapon()
		{
			tempWeapon.OnGUI();


		}



		void DisplayButtons()
		{
			if(!showNewWeaponDetails)
			{
				if (GUILayout.Button("Create Weapon"))
				{
					tempWeapon = new ISWeapon();
					showNewWeaponDetails = true;
				}
			}
				else
				{

				if (GUILayout.Button("Save"))
				{
					showNewWeaponDetails = false;

//					string Database_Name = @"ShrekanQualityDatabase.asset";
//					string Database_Path = @"Database";
//					ISQualityDatabase qdb;
//					qdb = ISQualityDatabase.GetDatabase<ISQualityDatabase>(Database_Path, Database_Name);
//
//					tempWeapon.Quality = qdb.Get(tempWeapon.SelectedQualityID);

					database.Add( tempWeapon );
					tempWeapon = null;
				}
				if (GUILayout.Button("Cancel"))
				{
					showNewWeaponDetails = false;
					tempWeapon = null;
				}
			}
		}
	}
}