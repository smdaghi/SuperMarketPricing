using System;
using Domain.Entities;

namespace Domain.Services
{
	public static class UnitConversion
	{
		public static decimal WeightInPound(decimal weight, UnitEnum unit)
		{
            switch (unit)
            {
                case UnitEnum.Pounds:
                    return weight;
                case UnitEnum.Ounces:
                    return weight / DefaultConstants.OUNCE_TO_POUNDS;
                case UnitEnum.Grams:
                    return weight / DefaultConstants.GRAM_TO_POUNDS;
                default:
                    return 0;
            }
        }
	}
}

