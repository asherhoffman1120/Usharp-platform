using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine
{
    // Assumes UEngine isn't being generated by the code generator as we are providing the UClass attribute here
    [UClass(Flags=(ClassFlags)0x305008AF, Config = "Engine"), UMetaPath("/Script/Engine.Engine", "Engine", UnrealModuleType.Engine)]
    public partial class UEngine : UObject
    {
        private static CachedUObject<UEngine> engineCached;
        public static UEngine GEngine
        {
            get { return engineCached.Update(FGlobals.GEngine); }
        }

        private static CachedUObject<UEngine> editorCached;
        public static UEngine GEditor
        {
            get { return editorCached.Update(FGlobals.GEditor); }
        }

        public UWorld GetWorldFromContextObject(UObject obj)
        {
            return GCHelper.Find<UWorld>(Native_UEngine.GetWorldFromContextObject(obj.Address, EGetWorldErrorMode.ReturnNull));
        }
    }
}