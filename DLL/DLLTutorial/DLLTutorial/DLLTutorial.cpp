#pragma once
#define DLL_EXPORT
#include <iostream>
#include "DLLTutorial.h"


extern "C"
{
	DECLDIR int Add(int a, int b)
	{
		return(a + b);
	}

	DECLDIR void Function(void)
	{
		std::cout << "DLL Called!" << std::endl;
	}
}

//LIBRARY dll_tutorial
//DESCRIPTION "our simple DLL"
//EXPORTS
//Add @1
//Function @2