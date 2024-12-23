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
    ///     A unit for expressing the integral of apparent power over time, equal to the product of 1 volt-ampere and 1 hour, or to 3600 joules.
    /// </summary>
    /// <remarks>
    ///     <see cref="ApparentEnergy" /> has been renamed to <see cref="ElectricApparentEnergy" />, and will be removed in a later major version.
    /// </remarks>
    [Obsolete("ApparentEnergy has been renamed to ElectricApparentEnergy, and will be removed in a later major version.")]
    public struct  ApparentEnergy
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ApparentEnergyUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ApparentEnergyUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public ApparentEnergy(double value, ApparentEnergyUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of ApparentEnergy, which is Second. All conversions go via this value.
        /// </summary>
        public static ApparentEnergyUnit BaseUnit { get; } = ApparentEnergyUnit.VoltampereHour;

        /// <summary>
        /// Represents the largest possible value of ApparentEnergy.
        /// </summary>
        public static ApparentEnergy MaxValue { get; } = new ApparentEnergy(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of ApparentEnergy.
        /// </summary>
        public static ApparentEnergy MinValue { get; } = new ApparentEnergy(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ApparentEnergy Zero { get; } = new ApparentEnergy(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ApparentEnergyUnit.KilovoltampereHour"/>
        /// </summary>
        public double KilovoltampereHours => As(ApparentEnergyUnit.KilovoltampereHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ApparentEnergyUnit.MegavoltampereHour"/>
        /// </summary>
        public double MegavoltampereHours => As(ApparentEnergyUnit.MegavoltampereHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ApparentEnergyUnit.VoltampereHour"/>
        /// </summary>
        public double VoltampereHours => As(ApparentEnergyUnit.VoltampereHour);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ApparentEnergy"/> from <see cref="ApparentEnergyUnit.KilovoltampereHour"/>.
        /// </summary>
        public static ApparentEnergy FromKilovoltampereHours(double kilovoltamperehours) => new ApparentEnergy(kilovoltamperehours, ApparentEnergyUnit.KilovoltampereHour);

        /// <summary>
        ///     Creates a <see cref="ApparentEnergy"/> from <see cref="ApparentEnergyUnit.MegavoltampereHour"/>.
        /// </summary>
        public static ApparentEnergy FromMegavoltampereHours(double megavoltamperehours) => new ApparentEnergy(megavoltamperehours, ApparentEnergyUnit.MegavoltampereHour);

        /// <summary>
        ///     Creates a <see cref="ApparentEnergy"/> from <see cref="ApparentEnergyUnit.VoltampereHour"/>.
        /// </summary>
        public static ApparentEnergy FromVoltampereHours(double voltamperehours) => new ApparentEnergy(voltamperehours, ApparentEnergyUnit.VoltampereHour);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ApparentEnergyUnit" /> to <see cref="ApparentEnergy" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ApparentEnergy unit value.</returns>
        public static ApparentEnergy From(double value, ApparentEnergyUnit fromUnit)
        {
            return new ApparentEnergy(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(ApparentEnergyUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this ApparentEnergy to another ApparentEnergy with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A ApparentEnergy with the specified unit.</returns>
                public ApparentEnergy ToUnit(ApparentEnergyUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new ApparentEnergy(convertedValue, unit);
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
                        ApparentEnergyUnit.KilovoltampereHour => (_value) * 1e3d,
                        ApparentEnergyUnit.MegavoltampereHour => (_value) * 1e6d,
                        ApparentEnergyUnit.VoltampereHour => _value,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(ApparentEnergyUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        ApparentEnergyUnit.KilovoltampereHour => (baseUnitValue) / 1e3d,
                        ApparentEnergyUnit.MegavoltampereHour => (baseUnitValue) / 1e6d,
                        ApparentEnergyUnit.VoltampereHour => baseUnitValue,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

