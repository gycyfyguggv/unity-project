using UnityEditor;

public class BuildScript
{
    public static void BuildIOS()
    {
    BuildPipeline.BuildPlayer(
        new[] { "Assets/Scenes/Tutorial.unity" }, // غيّر للمشهد الأساسي
        "build/ios",
        BuildTarget.iOS,
        BuildOptions.None
    );
    }
}