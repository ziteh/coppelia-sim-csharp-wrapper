#include "pch.h"
#include "CoppeliaSimCSharpAPI.h"

#define _USE_MATH_DEFINES // for C++ using <cmath>
#include <cmath>

#define TO_RAD(degree) (degree*(M_PI/180))
#define TO_DEGREE(rad) (rad*(180/M_PI))

COPPELIASIMREMOTEAPI_API int Connect(char* address, int port) {
    int id = simxStart((char*)"127.0.0.1", port, true, true, 2000, 5);
    extApi_sleepMs(300);
    if (IsConnected(id)) {
        SendInfo(id, "[Remote API] Connected", false);
    }
    return id;
}

COPPELIASIMREMOTEAPI_API int Disconnect(int id) {
    extApi_sleepMs(300);
    if (IsConnected(id)) {
        SendInfo(id, "[Remote API] Disconnect...", true);
        simxFinish(id);
    }
    return 0;
}

COPPELIASIMREMOTEAPI_API bool IsConnected(int id) {
    bool isConnected = false;
    if (id != -1) {
        if (simxGetConnectionId(id) != -1) {
            isConnected = true;
        }
    }
    return isConnected;
}

COPPELIASIMREMOTEAPI_API int MoveJoint(int id, float position[6], int jointHandle[6], bool inTorqueForceMode) {
    simxPauseCommunication(id, 1);
    if (inTorqueForceMode) {
        for (int i = 0; i < 6; i++) {
            simxSetJointTargetPosition(id, jointHandle[i], TO_RAD(position[i]), simx_opmode_oneshot);
        }
    }
    else {
        for (int i = 0; i < 6; i++) {
            simxSetJointPosition(id, jointHandle[i], TO_RAD(position[i]), simx_opmode_oneshot);
        }
    }
    return simxPauseCommunication(id, 0);
}

COPPELIASIMREMOTEAPI_API int MoveCartesian(int id, float position[6], int jointHandle[6], bool inTorqueForceMode) {
    return -99;
}

COPPELIASIMREMOTEAPI_API int GetJointPosition(int id, int jointHandle[6], float position[6]) {
    for (int i = 0; i < 6; i++) {
        float pos;
        simxGetJointPosition(id, jointHandle[i], &pos, simx_opmode_blocking);
        position[i] = TO_DEGREE(pos);
    }
    return 0;
}

COPPELIASIMREMOTEAPI_API int GetCartesianPosition(int id, int jointHandle[6], float position[6]) {
    return -99;
}

COPPELIASIMREMOTEAPI_API int GetObjectHandle(int id, const char* objectName) {
    int objectHandle;
    simxGetObjectHandle(id, objectName, &objectHandle, simx_opmode_blocking);
    return objectHandle;
}

COPPELIASIMREMOTEAPI_API int SendInfo(int id, const char* message, bool blocking) {
    int opMode = blocking ? simx_opmode_blocking : simx_opmode_oneshot;
    return simxAddStatusbarMessage(id, message, opMode);
}