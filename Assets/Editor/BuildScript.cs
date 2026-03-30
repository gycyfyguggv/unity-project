using UnityEditor;

public class BuildScript
{
    public static void BuildIOS()
    {
        BuildPipeline.BuildPlayer(
            new[] { "Assets/Scenes/Tutorial.unity" },
            "build/ios",
            BuildTarget.iOS,
            BuildOptions.None
        );
    }
}