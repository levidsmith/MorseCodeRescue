﻿using System.Collections.Generic;
using UnityEditor;

public class EditorScript {
    [MenuItem("Build/WebGL build")]
    public static void PerformBuild() {
        List<string> scenes = new List<string>();
        foreach(EditorBuildSettingsScene scene in EditorBuildSettings.scenes) {
            if (scene.enabled) {
                scenes.Add(scene.path);
            }
        }

        BuildPipeline.BuildPlayer(scenes.ToArray(), "build/DigmaniaWebGL", BuildTarget.WebGL, BuildOptions.None);
    }
}