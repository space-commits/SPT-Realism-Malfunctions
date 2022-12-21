using System;
using System.Reflection;
using Aki.Reflection.Patching;
using EFT.InventoryLogic;

namespace InspectionlessMalfs
{
	public class KnowMalf : ModulePatch
	{
		protected override MethodBase GetTargetMethod()
		{
			return typeof(Weapon.GClass2208).GetMethod("IsKnownMalfType", BindingFlags.Instance | BindingFlags.Public);
		}
		[PatchPostfix]
		private static void PatchPostfix(ref bool __result)
		{
			__result = true;
		}
	}
}