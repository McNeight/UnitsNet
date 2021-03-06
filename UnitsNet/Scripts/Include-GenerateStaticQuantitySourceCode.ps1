﻿using module ".\Types.psm1"

function GenerateStaticQuantitySourceCode([Quantity[]]$quantities, [string]$target)
{
@"
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
using System.Globalization;
using JetBrains.Annotations;
using UnitsNet.InternalHelpers;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <summary>
    ///     Dynamically parse or construct quantities when types are only known at runtime.
    /// </summary>
    public static partial class Quantity
    {
        /// <summary>
        /// Dynamically constructs a quantity of the given <see cref="QuantityType"/> with the value in the quantity's base units.
        /// </summary>
        /// <param name="quantityType">The <see cref="QuantityType"/> of the quantity to create.</param>
        /// <param name="value">The value to construct the quantity with.</param>
        /// <returns>The created quantity.</returns>
        public static IQuantity FromQuantityType(QuantityType quantityType, QuantityValue value)
        {
            switch(quantityType)
            {
"@; foreach ($quantity in $quantities) {
        $quantityName = $quantity.Name;@"
                case QuantityType.$quantityName`:
                    return $quantityName.From(value, $quantityName.BaseUnit);
"@; }@"
                default:
                    throw new ArgumentException($"{quantityType} is not a supported quantity type.");
            }
        }

        /// <summary>
        ///     Try to dynamically construct a quantity.
        /// </summary>
        /// <param name="value">Numeric value.</param>
        /// <param name="unit">Unit enum value.</param>
        /// <param name="quantity">The resulting quantity if successful, otherwise <c>default</c>.</param>
        /// <returns><c>True</c> if successful with <paramref name="quantity"/> assigned the value, otherwise <c>false</c>.</returns>
        public static bool TryFrom(QuantityValue value, Enum unit, out IQuantity quantity)
        {
            switch (unit)
            {
"@; foreach ($quantity in $quantities) {
        $quantityName = $quantity.Name
        $unitTypeName = $quantityName + "Unit"
        $unitValue = toCamelCase($unitTypeName);@"
                case $unitTypeName $($unitValue):
                    quantity = $quantityName.From(value, $unitValue);
                    return true;
"@; }@"
                default:
                {
                    quantity = default(IQuantity);
                    return false;
                }
            }
        }

        /// <summary>
        ///     Try to dynamically parse a quantity string representation.
        /// </summary>
        /// <param name="formatProvider">The format provider to use for lookup. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        /// <param name="quantityType">Type of quantity, such as <see cref="Length"/>.</param>
        /// <param name="quantityString">Quantity string representation, such as "1.5 kg". Must be compatible with given quantity type.</param>
        /// <param name="quantity">The resulting quantity if successful, otherwise <c>default</c>.</param>
        /// <returns>The parsed quantity.</returns>
        public static bool TryParse([CanBeNull] IFormatProvider formatProvider, Type quantityType, string quantityString, out IQuantity quantity)
        {
            quantity = default(IQuantity);

            if (!typeof(IQuantity).Wrap().IsAssignableFrom(quantityType))
                return false;

            var parser = QuantityParser.Default;

            switch(quantityType)
            {
"@; foreach ($quantity in $quantities) {
  $quantityName = $quantity.Name;@"
                case Type _ when quantityType == typeof($quantityName):
                    return parser.TryParse<$quantityName, $($quantityName)Unit>(quantityString, formatProvider, $quantityName.From, out quantity);
"@; }@"
                default:
                    return false;
            }
        }
    }
}
"@;
}

function toCamelCase([string] $str) {
    return [char]::ToLower($str[0]) + $str.Substring(1)
}
