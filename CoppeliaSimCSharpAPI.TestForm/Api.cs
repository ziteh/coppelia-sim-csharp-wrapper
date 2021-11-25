using System;
using System.Runtime.InteropServices;

namespace CoppeliaSimCSharpAPI.TestForm
{
    internal class Api
    {
        [DllImport("CoppeliaSimCSharpAPI.dll")]
        public static extern int Connect(string address, int port);

        [DllImport("CoppeliaSimCSharpAPI.dll")]
        public static extern int Disconnect(int id);

        [DllImport("CoppeliaSimCSharpAPI.dll")]
        public static extern int GetJointPosition(int id, int[] jointHandle, float[] position, int jointCount);

        [DllImport("CoppeliaSimCSharpAPI.dll")]
        public static extern int GetObjectHandle(int id, string objectName);

        [DllImport("CoppeliaSimCSharpAPI.dll")]
        public static extern int MoveJoint(int id, int[] jointHandle, float[] position, bool inTorqueForceMode, int jointCount);
    }
}
