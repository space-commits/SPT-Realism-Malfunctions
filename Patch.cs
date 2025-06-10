using System;
using System.Reflection;
using SPT.Reflection.Patching;
using HarmonyLib;
using static EFT.InventoryLogic.Weapon;

namespace InspectionlessMalfs
{
	public class KnowMalf : ModulePatch
	{
		protected override MethodBase GetTargetMethod()
		{
			return AccessTools.Method(typeof(WeaponMalfunctionStateClass), nameof(WeaponMalfunctionStateClass.IsKnownMalfType));
		}

		[PatchPostfix]
		private static void PatchPostfix(ref bool __result)
		{
			__result = true;
		}
	}
}