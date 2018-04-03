#pragma once

#ifdef TESTFUNCDLL_EXPORT

#define TESTFUNCDLL_API __declspec(dllexport)
#else
#define TESTFUNCDLL_API __declspec(dllimport)
#endif // TESTFUNCDLL_EXPORT

extern "C"
{
	TESTFUNCDLL_API float TestMultiply(float a, float b);
	TESTFUNCDLL_API float TestDivide(float a, float b);
}

