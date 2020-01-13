﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Provides access to configuration data
// This class doesn't inherit from MonoBehaviour because we don't want to attach the class
// to game objects of instantiate it, we just want consumers to access the class directly.
public class ConfigUtils {
    // ======================================================================
    // Field Variables
    // ======================================================================

    private static ConfigData _configData;

    // ======================================================================
    // Public Static Properties
    // ======================================================================

    // using expression-body style
    public static float VertSpeed                      => _configData.VertSpeed;
    public static float HoriSpeed                      => _configData.HoriSpeed;
    public static float HoriSpeedBuffed                => _configData.HoriSpeedBuffed;
    public static float MinSpawnIntervalBuff           => _configData.MinSpawnIntervalBuff;
    public static float MaxSpawnIntervalBuff           => _configData.MaxSpawnIntervalBuff;
    public static float MinSpawnIntervalObstacleNormal => _configData.MinSpawnIntervalObstacleNormal;
    public static float MaxSpawnIntervalObstacleNormal => _configData.MaxSpawnIntervalObstacleNormal;
    public static float MinSpawnIntervalObstacleBuffed => _configData.MinSpawnIntervalObstacleBuffed;
    public static float MaxSpawnIntervalObstacleBuffed => _configData.MaxSpawnIntervalObstacleBuffed;

    // Initialise the config utils, run the initialisation in GameInitializer.cs
    public static void Initialize() {
        _configData = new ConfigData();
    }
}