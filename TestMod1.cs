using MelonLoader;
using BTD_Mod_Helper;
using TestMod1;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using BTD_Mod_Helper.Extensions;

[assembly: MelonInfo(typeof(TestMod1.TestMod1), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace TestMod1;

public class TestMod1 : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<TestMod1>("TestMod1 loaded!");
    }

    public override void OnNewGameModel(GameModel result)
    {
        foreach(var weapon in result.GetDescendants<WeaponModel>().ToList())
        {
            weapon.rate = 0;
        }
    }
}

