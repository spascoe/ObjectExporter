﻿namespace ObjectExporter.VsPackage.Settings
{
    public static class GlobalPackageSettings
    {
        public static uint DepthSolverTimeOut = Defaults.DepthSolverTimeOut;
        public static uint DepthSolverCutOff = Defaults.DepthSolverCutOff;
        public static bool IgnoreDynamicallyAddedProperties = Defaults.IgnoreDynamicallyAddedProperties;
        public static bool ErrorReportingEnabled = Defaults.ErrorReportingEnabled;

        public static void Initialize(PackageSettings settings)
        {
            DepthSolverTimeOut = settings.DepthSolverTimeOut;
            DepthSolverCutOff = settings.DepthSolverCutoff;
            IgnoreDynamicallyAddedProperties = settings.IgnoreDynamicallyAddedProperties;
            ErrorReportingEnabled = settings.ErrorReportingEnabled;
        }
    }
}
