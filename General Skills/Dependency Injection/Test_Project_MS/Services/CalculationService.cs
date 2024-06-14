﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_Test.Services
{
	internal class CalculationService : ICalculationService
	{
		public int Add(int number1, int number2)
		{
			return number1 + number2;
		}
	}
}
