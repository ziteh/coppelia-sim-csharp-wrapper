#include "pch.h"
#include "CoppeliaSimCSharpAPI.h"

COPPELIASIMCSHARPAPI_API int Connect(const char* address, int port) {
    int id = simxStart(address, port, true, true, 2000, 5);
    extApi_sleepMs(300);
    if (IsConnected(id)) {
        SendInfo(id, "[Remote API] Connected", false);
    }
    return id;
}

COPPELIASIMCSHARPAPI_API int Disconnect(int id) {
    extApi_sleepMs(300);
    if (IsConnected(id)) {
        SendInfo(id, "[Remote API] Disconnect...", true);
        simxFinish(id);
    }
    return 0;
}

COPPELIASIMCSHARPAPI_API bool IsConnected(int id) {
    bool isConnected = false;
    if (id != -1) {
        if (simxGetConnectionId(id) != -1) {
            isConnected = true;
        }
    }
    return isConnected;
}

COPPELIASIMCSHARPAPI_API int MoveJoint(int id, int jointHandle[], float position[], bool inTorqueForceMode, int jointCount) {
    simxPauseCommunication(id, 1);
    if (inTorqueForceMode) {
        for (int i = 0; i < jointCount; i++) {
            simxSetJointTargetPosition(id, jointHandle[i], TO_RAD(position[i]), simx_opmode_oneshot);
        }
    }
    else {
        for (int i = 0; i < jointCount; i++) {
            simxSetJointPosition(id, jointHandle[i], TO_RAD(position[i]), simx_opmode_oneshot);
        }
    }
    return simxPauseCommunication(id, 0);
}

COPPELIASIMCSHARPAPI_API int GetJointPosition(int id, int jointHandle[], float position[], int jointCount) {
    for (int i = 0; i < jointCount; i++) {
        float pos;
        simxGetJointPosition(id, jointHandle[i], &pos, simx_opmode_blocking);
        position[i] = TO_DEGREE(pos);
    }
    return 0;
}

COPPELIASIMCSHARPAPI_API int GetObjectHandle(int id, const char* objectName) {
    int objectHandle;
    simxGetObjectHandle(id, objectName, &objectHandle, simx_opmode_blocking);
    return objectHandle;
}

COPPELIASIMCSHARPAPI_API int SendInfo(int id, const char* message, bool blocking) {
    return simxAddStatusbarMessage(id, message, blocking ? (simxInt)simx_opmode_blocking : (simxInt)simx_opmode_oneshot);
}