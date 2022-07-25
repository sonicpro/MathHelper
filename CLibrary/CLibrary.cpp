#include "math.h"

extern "C"
{
	__declspec(dllexport) float Sqrtf(float number)
	{
		return sqrtf(number);
	}

	__declspec(dllexport) double Sqrt(double number)
	{
		return sqrt(number);
	}
}
