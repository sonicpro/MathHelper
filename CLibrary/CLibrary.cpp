#include "math.h"

extern "C"
{
	__declspec(dllexport) float Sqrtf(float number)
	{
		return sqrtf(number);
	}
}
