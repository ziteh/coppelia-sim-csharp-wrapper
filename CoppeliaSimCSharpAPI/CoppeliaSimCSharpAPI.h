#pragma once

#ifdef COPPELIASIMREMOTEAPI_EXPORTS
#define COPPELIASIMREMOTEAPI_API __declspec(dllexport)
#else
#define COPPELIASIMREMOTEAPI_API __declspec(dllimport)
#endif

extern "C" {
#include "extApi.h" // remote api
}

extern "C" COPPELIASIMREMOTEAPI_API int Connect(char* address, int port);
extern "C" COPPELIASIMREMOTEAPI_API int Disconnect(int id);
extern "C" COPPELIASIMREMOTEAPI_API bool IsConnected(int id);

extern "C" COPPELIASIMREMOTEAPI_API int MoveJoint(int id, float position[6], int jointHandle[6], bool inTorqueForceMode);
extern "C" COPPELIASIMREMOTEAPI_API int MoveCartesian(int id, float position[6], int jointHandle[6], bool inTorqueForceMode);

extern "C" COPPELIASIMREMOTEAPI_API int GetJointPosition(int id, int jointHandle[6], float position[6]);
extern "C" COPPELIASIMREMOTEAPI_API int GetCartesianPosition(int id, int jointHandle[6], float position[6]);

extern "C" COPPELIASIMREMOTEAPI_API int GetObjectHandle(int id, const char* objectName);
extern "C" COPPELIASIMREMOTEAPI_API int SendInfo(int id, const char* message, bool blocking);
