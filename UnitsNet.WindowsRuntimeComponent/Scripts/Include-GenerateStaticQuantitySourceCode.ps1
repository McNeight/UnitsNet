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
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.InternalHelpers;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <summary>
    ///     Dynamically parse or construct quantities when types are only known at runtime.
    /// </summary>
    internal static partial class Quantity
    {
        /// <summary>
        ///     Try to dynamically construct a quantity.
        /// </summary>
        /// <param name="value">Numeric value.</param>
        /// <param name="unit">Unit enum value.</param>
        /// <param name="quantity">The resulting quantity if successful, otherwise <c>default</c>.</param>
        /// <returns><c>True</c> if successful with <paramref name="quantity"/> assigned the value, otherwise <c>false</c>.</returns>
        internal static bool TryFrom(double value, Enum unit, out IQuantity quantity)
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

        /// <inheritdoc cref="Parse(IFormatProvider, System.Type,string)"/>
        internal static IQuantity Parse(Type quantityType, string quantityString) => Parse(null, quantityType, quantityString);

        /// <summary>
        ///     Dynamically parse a quantity string representation.
        /// </summary>
        /// <param name="formatProvider">The format provider to use for lookup. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        /// <param name="quantityType">Type of quantity, such as <see cref="Length"/>.</param>
        /// <param name="quantityString">Quantity string representation, such as "1.5 kg". Must be compatible with given quantity type.</param>
        /// <returns>The parsed quantity.</returns>
        /// <exception cref="ArgumentException">Type must be of type UnitsNet.IQuantity -or- Type is not a known quantity type.</exception>
        internal static IQuantity Parse([CanBeNull] IFormatProvider formatProvider, Type quantityType, string quantityString)
        {
            if (!typeof(IQuantity).Wrap().IsAssignableFrom(quantityType))
                throw new ArgumentException($"Type {quantityType} must be of type UnitsNet.IQuantity.");

            if (TryParse(formatProvider, quantityType, quantityString, out IQuantity quantity)) return quantity;

            throw new ArgumentException($"Quantity string could not be parsed to quantity {quantityType}.");
        }

        /// <inheritdoc cref="TryParse(IFormatProvider,System.Type,string,out UnitsNet.IQuantity)"/>
        internal static bool TryParse(Type quantityType, string quantityString, out IQuantity quantity) =>
            TryParse(null, quantityType, quantityString, out quantity);

        /// <summary>
        ///     Try to dynamically parse a quantity string representation.
        /// </summary>
        /// <param name="formatProvider">The format provider to use for lookup. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        /// <param name="quantityType">Type of quantity, such as <see cref="Length"/>.</param>
        /// <param name="quantityString">Quantity string representation, such as "1.5 kg". Must be compatible with given quantity type.</param>
        /// <param name="quantity">The resulting quantity if successful, otherwise <c>default</c>.</param>
        /// <returns>The parsed quantity.</returns>
        internal static bool TryParse([CanBeNull] IFormatProvider formatProvider, Type quantityType, string quantityString, out IQuantity quantity)
        {
            quantity = default(IQuantity);

            if (!typeof(IQuantity).Wrap().IsAssignableFrom(quantityType))
                return false;

            var parser = QuantityParser.Default;

"@; foreach ($quantity in $quantities) {
  $quantityName = $quantity.Name;@"
            if (quantityType == typeof($quantityName))
                return parser.TryParse<$quantityName, $($quantityName)Unit>(quantityString, formatProvider, $quantityName.From, out quantity);

"@; }@"
            throw new ArgumentException(
                $"Type {quantityType} is not a known quantity type. Did you pass in a third-party quantity type defined outside UnitsNet library?");
        }
    }
}
"@;
}

function toCamelCase([string] $str) {
    return [char]::ToLower($str[0]) + $str.Substring(1)
}
