using UnityEngine;
using Winch.Core;

namespace WinchModTemplate
{
	public class DredgeAquarium : MonoBehaviour
	{
		public void Awake()
		{
			WinchCore.Log.Debug($"{nameof(DredgeAquarium)} has loaded!");
		}
	}
}
