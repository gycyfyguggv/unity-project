using UnityEditor;

public class BuildScript
{
    public static void BuildiOS()
    {
        string[] scenes = {
            "Assets/Scenes/Tutorial.unity"
        };

        BuildPipeline.BuildPlayer(
            scenes,
            "build/ios",
            BuildTarget.iOS,
            BuildOptions.None
        );
    }
}