using System;
using Test_Taste_Console_Application.Domain.DataTransferObjects;

namespace Test_Taste_Console_Application.Domain.Objects
{
    public class Moon
    {
        public string Id { get; set; }
        public float MassValue { get; set; }
        public float MassExponent { get; set; }
        public float Gravity
        {
            get
            {
                try
                {
                    // Calculate gravity based on MassValue and MassExponent
                    return MassValue * (float)Math.Pow(10, MassExponent);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error calculating gravity for moon: {ex.Message}");
                    return 0.0f;
                }
            }
        }

        public Moon(MoonDto moonDto)
        {
            Id = moonDto.Id;
            MassValue = moonDto.MassValue;
            MassExponent = moonDto.MassExponent;
        }
    }
}
