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
    ///     In electric power transmission and distribution, volt-ampere reactive (var) is a unit of measurement of reactive power. Reactive power exists in an AC circuit when the current and voltage are not in phase.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/AC_power#Active,_reactive,_apparent,_and_complex_power_in_sinusoidal_steady-state
    /// </remarks>
    public struct  ElectricReactivePower
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricReactivePowerUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ElectricReactivePowerUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public ElectricReactivePower(double value, ElectricReactivePowerUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of ElectricReactivePower, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricReactivePowerUnit BaseUnit { get; } = ElectricReactivePowerUnit.VoltampereReactive;

        /// <summary>
        /// Represents the largest possible value of ElectricReactivePower.
        /// </summary>
        public static ElectricReactivePower MaxValue { get; } = new ElectricReactivePower(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of ElectricReactivePower.
        /// </summary>
        public static ElectricReactivePower MinValue { get; } = new ElectricReactivePower(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricReactivePower Zero { get; } = new ElectricReactivePower(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricReactivePowerUnit.GigavoltampereReactive"/>
        /// </summary>
        public double GigavoltamperesReactive => As(ElectricReactivePowerUnit.GigavoltampereReactive);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricReactivePowerUnit.KilovoltampereReactive"/>
        /// </summary>
        public double KilovoltamperesReactive => As(ElectricReactivePowerUnit.KilovoltampereReactive);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricReactivePowerUnit.MegavoltampereReactive"/>
        /// </summary>
        public double MegavoltamperesReactive => As(ElectricReactivePowerUnit.MegavoltampereReactive);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricReactivePowerUnit.VoltampereReactive"/>
        /// </summary>
        public double VoltamperesReactive => As(ElectricReactivePowerUnit.VoltampereReactive);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ElectricReactivePower"/> from <see cref="ElectricReactivePowerUnit.GigavoltampereReactive"/>.
        /// </summary>
        public static ElectricReactivePower FromGigavoltamperesReactive(double gigavoltamperesreactive) => new ElectricReactivePower(gigavoltamperesreactive, ElectricReactivePowerUnit.GigavoltampereReactive);

        /// <summary>
        ///     Creates a <see cref="ElectricReactivePower"/> from <see cref="ElectricReactivePowerUnit.KilovoltampereReactive"/>.
        /// </summary>
        public static ElectricReactivePower FromKilovoltamperesReactive(double kilovoltamperesreactive) => new ElectricReactivePower(kilovoltamperesreactive, ElectricReactivePowerUnit.KilovoltampereReactive);

        /// <summary>
        ///     Creates a <see cref="ElectricReactivePower"/> from <see cref="ElectricReactivePowerUnit.MegavoltampereReactive"/>.
        /// </summary>
        public static ElectricReactivePower FromMegavoltamperesReactive(double megavoltamperesreactive) => new ElectricReactivePower(megavoltamperesreactive, ElectricReactivePowerUnit.MegavoltampereReactive);

        /// <summary>
        ///     Creates a <see cref="ElectricReactivePower"/> from <see cref="ElectricReactivePowerUnit.VoltampereReactive"/>.
        /// </summary>
        public static ElectricReactivePower FromVoltamperesReactive(double voltamperesreactive) => new ElectricReactivePower(voltamperesreactive, ElectricReactivePowerUnit.VoltampereReactive);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricReactivePowerUnit" /> to <see cref="ElectricReactivePower" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricReactivePower unit value.</returns>
        public static ElectricReactivePower From(double value, ElectricReactivePowerUnit fromUnit)
        {
            return new ElectricReactivePower(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(ElectricReactivePowerUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this ElectricReactivePower to another ElectricReactivePower with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A ElectricReactivePower with the specified unit.</returns>
                public ElectricReactivePower ToUnit(ElectricReactivePowerUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new ElectricReactivePower(convertedValue, unit);
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
                        ElectricReactivePowerUnit.GigavoltampereReactive => (_value) * 1e9d,
                        ElectricReactivePowerUnit.KilovoltampereReactive => (_value) * 1e3d,
                        ElectricReactivePowerUnit.MegavoltampereReactive => (_value) * 1e6d,
                        ElectricReactivePowerUnit.VoltampereReactive => _value,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(ElectricReactivePowerUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        ElectricReactivePowerUnit.GigavoltampereReactive => (baseUnitValue) / 1e9d,
                        ElectricReactivePowerUnit.KilovoltampereReactive => (baseUnitValue) / 1e3d,
                        ElectricReactivePowerUnit.MegavoltampereReactive => (baseUnitValue) / 1e6d,
                        ElectricReactivePowerUnit.VoltampereReactive => baseUnitValue,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

