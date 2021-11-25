#pragma once

#ifdef COPPELIASIMCSHARPAPI_EXPORTS
#define COPPELIASIMCSHARPAPI_API __declspec(dllexport)
#else
#define COPPELIASIMREMOTEAPI_API __declspec(dllimport)
#endif

/* For C++ using <cmath>. */
#define _USE_MATH_DEFINES
#include <cmath>

extern "C" {
#include "extApi.h"
}

#define TO_RAD(degree) (degree*(M_PI/180))
#define TO_DEGREE(rad) (rad*(180/M_PI))

extern "C" COPPELIASIMCSHARPAPI_API int Connect(const char* address, int port);
extern "C" COPPELIASIMCSHARPAPI_API int Disconnect(int id);
extern "C" COPPELIASIMCSHARPAPI_API bool IsConnected(int id);

extern "C" COPPELIASIMCSHARPAPI_API int MoveJoint(int id, float position[6], int jointHandle[6], bool inTorqueForceMode);
extern "C" COPPELIASIMCSHARPAPI_API int MoveCartesian(int id, float position[6], int jointHandle[6], bool inTorqueForceMode);

extern "C" COPPELIASIMCSHARPAPI_API int GetJointPosition(int id, int jointHandle[6], float position[6]);
extern "C" COPPELIASIMCSHARPAPI_API int GetCartesianPosition(int id, int jointHandle[6], float position[6]);

extern "C" COPPELIASIMCSHARPAPI_API int GetObjectHandle(int id, const char* objectName);
extern "C" COPPELIASIMCSHARPAPI_API int SendInfo(int id, const char* message, bool blocking);
