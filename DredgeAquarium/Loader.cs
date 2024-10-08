﻿using UnityEngine;

namespace WinchModTemplate
{
	public class Loader
	{
		/// <summary>
		/// This method is run by Winch to initialize your mod
		/// </summary>
		public static void Initialize()
		{
			var gameObject = new GameObject(nameof(DredgeAquarium));
			gameObject.AddComponent<DredgeAquarium>();
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
}