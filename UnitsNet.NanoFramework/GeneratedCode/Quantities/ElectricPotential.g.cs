//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     In classical electromagnetism, the electric potential (a scalar quantity denoted by Φ, ΦE or V and also called the electric field potential or the electrostatic potential) at a point is the amount of electric potential energy that a unitary point charge would have when located at that point.
    /// </summary>
    /// <remarks>
    ///     If you want to map more parameters into the <see cref="ElectricPotential" /> class (volts RMS, phase angle, etc.), create your own wrapper type such as a record or named tuple.
    /// </remarks>
    public struct  ElectricPotential
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricPotentialUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ElectricPotentialUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ElectricPotential(double value, ElectricPotentialUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of ElectricPotential, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricPotentialUnit BaseUnit { get; } = ElectricPotentialUnit.Volt;

        /// <summary>
        /// Represents the largest possible value of ElectricPotential.
        /// </summary>
        public static ElectricPotential MaxValue { get; } = new ElectricPotential(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of ElectricPotential.
        /// </summary>
        public static ElectricPotential MinValue { get; } = new ElectricPotential(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricPotential Zero { get; } = new ElectricPotential(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialUnit.Kilovolt"/>
        /// </summary>
        public double Kilovolts => As(ElectricPotentialUnit.Kilovolt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialUnit.Megavolt"/>
        /// </summary>
        public double Megavolts => As(ElectricPotentialUnit.Megavolt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialUnit.Microvolt"/>
        /// </summary>
        public double Microvolts => As(ElectricPotentialUnit.Microvolt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialUnit.Millivolt"/>
        /// </summary>
        public double Millivolts => As(ElectricPotentialUnit.Millivolt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialUnit.Nanovolt"/>
        /// </summary>
        public double Nanovolts => As(ElectricPotentialUnit.Nanovolt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricPotentialUnit.Volt"/>
        /// </summary>
        public double Volts => As(ElectricPotentialUnit.Volt);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ElectricPotential"/> from <see cref="ElectricPotentialUnit.Kilovolt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotential FromKilovolts(double kilovolts) => new ElectricPotential(kilovolts, ElectricPotentialUnit.Kilovolt);

        /// <summary>
        ///     Creates a <see cref="ElectricPotential"/> from <see cref="ElectricPotentialUnit.Megavolt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotential FromMegavolts(double megavolts) => new ElectricPotential(megavolts, ElectricPotentialUnit.Megavolt);

        /// <summary>
        ///     Creates a <see cref="ElectricPotential"/> from <see cref="ElectricPotentialUnit.Microvolt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotential FromMicrovolts(double microvolts) => new ElectricPotential(microvolts, ElectricPotentialUnit.Microvolt);

        /// <summary>
        ///     Creates a <see cref="ElectricPotential"/> from <see cref="ElectricPotentialUnit.Millivolt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotential FromMillivolts(double millivolts) => new ElectricPotential(millivolts, ElectricPotentialUnit.Millivolt);

        /// <summary>
        ///     Creates a <see cref="ElectricPotential"/> from <see cref="ElectricPotentialUnit.Nanovolt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotential FromNanovolts(double nanovolts) => new ElectricPotential(nanovolts, ElectricPotentialUnit.Nanovolt);

        /// <summary>
        ///     Creates a <see cref="ElectricPotential"/> from <see cref="ElectricPotentialUnit.Volt"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotential FromVolts(double volts) => new ElectricPotential(volts, ElectricPotentialUnit.Volt);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricPotentialUnit" /> to <see cref="ElectricPotential" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricPotential unit value.</returns>
        public static ElectricPotential From(double value, ElectricPotentialUnit fromUnit)
        {
            return new ElectricPotential(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(ElectricPotentialUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this ElectricPotential to another ElectricPotential with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A ElectricPotential with the specified unit.</returns>
                public ElectricPotential ToUnit(ElectricPotentialUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new ElectricPotential(convertedValue, unit);
                }

                /// <summary>
                ///     Converts the current value + unit to the base unit.
                ///     This is typically the first step in converting from one unit to another.
                /// </summary>
                /// <returns>The value in the base unit representation.</returns>
                private double GetValueInBaseUnit()
                {
                    return Unit switch
                    {
                        ElectricPotentialUnit.Kilovolt => (_value) * 1e3d,
                        ElectricPotentialUnit.Megavolt => (_value) * 1e6d,
                        ElectricPotentialUnit.Microvolt => (_value) * 1e-6d,
                        ElectricPotentialUnit.Millivolt => (_value) * 1e-3d,
                        ElectricPotentialUnit.Nanovolt => (_value) * 1e-9d,
                        ElectricPotentialUnit.Volt => _value,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(ElectricPotentialUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        ElectricPotentialUnit.Kilovolt => (baseUnitValue) / 1e3d,
                        ElectricPotentialUnit.Megavolt => (baseUnitValue) / 1e6d,
                        ElectricPotentialUnit.Microvolt => (baseUnitValue) / 1e-6d,
                        ElectricPotentialUnit.Millivolt => (baseUnitValue) / 1e-3d,
                        ElectricPotentialUnit.Nanovolt => (baseUnitValue) / 1e-9d,
                        ElectricPotentialUnit.Volt => baseUnitValue,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

