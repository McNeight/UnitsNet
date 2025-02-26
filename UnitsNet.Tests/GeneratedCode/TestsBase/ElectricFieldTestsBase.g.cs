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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ElectricField.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricFieldTestsBase : QuantityTestsBase
    {
        protected abstract double VoltsPerMeterInOneVoltPerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double VoltsPerMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(ElectricFieldUnit unit)
        {
            return unit switch
            {
                ElectricFieldUnit.VoltPerMeter => (VoltsPerMeterInOneVoltPerMeter, VoltsPerMeterTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { ElectricFieldUnit.VoltPerMeter },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ElectricField();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ElectricFieldUnit.VoltPerMeter, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricField(double.PositiveInfinity, ElectricFieldUnit.VoltPerMeter));
            Assert.Throws<ArgumentException>(() => new ElectricField(double.NegativeInfinity, ElectricFieldUnit.VoltPerMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricField(double.NaN, ElectricFieldUnit.VoltPerMeter));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ElectricField(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new ElectricField(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (ElectricField) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void ElectricField_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ElectricField(1, ElectricFieldUnit.VoltPerMeter);

            QuantityInfo<ElectricFieldUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ElectricField.Zero, quantityInfo.Zero);
            Assert.Equal("ElectricField", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<ElectricFieldUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void VoltPerMeterToElectricFieldUnits()
        {
            ElectricField voltpermeter = ElectricField.FromVoltsPerMeter(1);
            AssertEx.EqualTolerance(VoltsPerMeterInOneVoltPerMeter, voltpermeter.VoltsPerMeter, VoltsPerMeterTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ElectricField.From(1, ElectricFieldUnit.VoltPerMeter);
            AssertEx.EqualTolerance(1, quantity00.VoltsPerMeter, VoltsPerMeterTolerance);
            Assert.Equal(ElectricFieldUnit.VoltPerMeter, quantity00.Unit);

        }

        [Fact]
        public void FromVoltsPerMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricField.FromVoltsPerMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ElectricField.FromVoltsPerMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromVoltsPerMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricField.FromVoltsPerMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var voltpermeter = ElectricField.FromVoltsPerMeter(1);
            AssertEx.EqualTolerance(VoltsPerMeterInOneVoltPerMeter, voltpermeter.As(ElectricFieldUnit.VoltPerMeter), VoltsPerMeterTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new ElectricField(value: 1, unit: ElectricField.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = Convert.ToDouble(AsWithSIUnitSystem());
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void Parse()
        {
            try
            {
                var parsed = ElectricField.Parse("1 V/m", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.VoltsPerMeter, VoltsPerMeterTolerance);
                Assert.Equal(ElectricFieldUnit.VoltPerMeter, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(ElectricField.TryParse("1 V/m", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.VoltsPerMeter, VoltsPerMeterTolerance);
                Assert.Equal(ElectricFieldUnit.VoltPerMeter, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = ElectricField.ParseUnit("V/m", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricFieldUnit.VoltPerMeter, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(ElectricField.TryParseUnit("V/m", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricFieldUnit.VoltPerMeter, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(ElectricFieldUnit unit)
        {
            var inBaseUnits = ElectricField.From(1.0, ElectricField.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(ElectricFieldUnit unit)
        {
            var quantity = ElectricField.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory(Skip = "Multiple units required")]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(ElectricFieldUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = ElectricField.Units.First(u => u != ElectricField.BaseUnit);

            var quantity = ElectricField.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(ElectricFieldUnit unit)
        {
            var quantity = default(ElectricField);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricField voltpermeter = ElectricField.FromVoltsPerMeter(1);
            AssertEx.EqualTolerance(1, ElectricField.FromVoltsPerMeter(voltpermeter.VoltsPerMeter).VoltsPerMeter, VoltsPerMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricField v = ElectricField.FromVoltsPerMeter(1);
            AssertEx.EqualTolerance(-1, -v.VoltsPerMeter, VoltsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (ElectricField.FromVoltsPerMeter(3)-v).VoltsPerMeter, VoltsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).VoltsPerMeter, VoltsPerMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).VoltsPerMeter, VoltsPerMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).VoltsPerMeter, VoltsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (ElectricField.FromVoltsPerMeter(10)/5).VoltsPerMeter, VoltsPerMeterTolerance);
            AssertEx.EqualTolerance(2, ElectricField.FromVoltsPerMeter(10)/ElectricField.FromVoltsPerMeter(5), VoltsPerMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricField oneVoltPerMeter = ElectricField.FromVoltsPerMeter(1);
            ElectricField twoVoltsPerMeter = ElectricField.FromVoltsPerMeter(2);

            Assert.True(oneVoltPerMeter < twoVoltsPerMeter);
            Assert.True(oneVoltPerMeter <= twoVoltsPerMeter);
            Assert.True(twoVoltsPerMeter > oneVoltPerMeter);
            Assert.True(twoVoltsPerMeter >= oneVoltPerMeter);

            Assert.False(oneVoltPerMeter > twoVoltsPerMeter);
            Assert.False(oneVoltPerMeter >= twoVoltsPerMeter);
            Assert.False(twoVoltsPerMeter < oneVoltPerMeter);
            Assert.False(twoVoltsPerMeter <= oneVoltPerMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricField voltpermeter = ElectricField.FromVoltsPerMeter(1);
            Assert.Equal(0, voltpermeter.CompareTo(voltpermeter));
            Assert.True(voltpermeter.CompareTo(ElectricField.Zero) > 0);
            Assert.True(ElectricField.Zero.CompareTo(voltpermeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricField voltpermeter = ElectricField.FromVoltsPerMeter(1);
            Assert.Throws<ArgumentException>(() => voltpermeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricField voltpermeter = ElectricField.FromVoltsPerMeter(1);
            Assert.Throws<ArgumentNullException>(() => voltpermeter.CompareTo(null));
        }

        [Theory]
        [InlineData(1, ElectricFieldUnit.VoltPerMeter, 1, ElectricFieldUnit.VoltPerMeter, true)]  // Same value and unit.
        [InlineData(1, ElectricFieldUnit.VoltPerMeter, 2, ElectricFieldUnit.VoltPerMeter, false)] // Different value.
        [InlineData(2, ElectricFieldUnit.VoltPerMeter, 1, ElectricFieldUnit.VoltPerMeter, false)] // Different value and unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, ElectricFieldUnit unitA, double valueB, ElectricFieldUnit unitB, bool expectEqual)
        {
            var a = new ElectricField(valueA, unitA);
            var b = new ElectricField(valueB, unitB);

            // Operator overloads.
            Assert.Equal(expectEqual, a == b);
            Assert.Equal(expectEqual, b == a);
            Assert.Equal(!expectEqual, a != b);
            Assert.Equal(!expectEqual, b != a);

            // IEquatable<T>
            Assert.Equal(expectEqual, a.Equals(b));
            Assert.Equal(expectEqual, b.Equals(a));

            // IEquatable
            Assert.Equal(expectEqual, a.Equals((object)b));
            Assert.Equal(expectEqual, b.Equals((object)a));
        }

        [Fact]
        public void Equals_Null_ReturnsFalse()
        {
            var a = ElectricField.Zero;

            Assert.False(a.Equals((object)null));

            // "The result of the expression is always 'false'..."
            #pragma warning disable CS8073
            Assert.False(a == null);
            Assert.False(null == a);
            Assert.True(a != null);
            Assert.True(null != a);
            #pragma warning restore CS8073
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = ElectricField.FromVoltsPerMeter(1);
            Assert.True(v.Equals(ElectricField.FromVoltsPerMeter(1), VoltsPerMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricField.Zero, VoltsPerMeterTolerance, ComparisonType.Relative));
            Assert.True(ElectricField.FromVoltsPerMeter(100).Equals(ElectricField.FromVoltsPerMeter(120), (double)0.3m, ComparisonType.Relative));
            Assert.False(ElectricField.FromVoltsPerMeter(100).Equals(ElectricField.FromVoltsPerMeter(120), (double)0.1m, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ElectricField.FromVoltsPerMeter(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ElectricField.FromVoltsPerMeter(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricField voltpermeter = ElectricField.FromVoltsPerMeter(1);
            Assert.False(voltpermeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricField voltpermeter = ElectricField.FromVoltsPerMeter(1);
            Assert.False(voltpermeter.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ElectricFieldUnit)).Cast<ElectricFieldUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ElectricField.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            using var _ = new CultureScope("en-US");
            Assert.Equal("1 V/m", new ElectricField(1, ElectricFieldUnit.VoltPerMeter).ToString());
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 V/m", new ElectricField(1, ElectricFieldUnit.VoltPerMeter).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var _ = new CultureScope(CultureInfo.InvariantCulture);
            Assert.Equal("0.1 V/m", new ElectricField(0.123456, ElectricFieldUnit.VoltPerMeter).ToString("s1"));
            Assert.Equal("0.12 V/m", new ElectricField(0.123456, ElectricFieldUnit.VoltPerMeter).ToString("s2"));
            Assert.Equal("0.123 V/m", new ElectricField(0.123456, ElectricFieldUnit.VoltPerMeter).ToString("s3"));
            Assert.Equal("0.1235 V/m", new ElectricField(0.123456, ElectricFieldUnit.VoltPerMeter).ToString("s4"));
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 V/m", new ElectricField(0.123456, ElectricFieldUnit.VoltPerMeter).ToString("s1", culture));
            Assert.Equal("0.12 V/m", new ElectricField(0.123456, ElectricFieldUnit.VoltPerMeter).ToString("s2", culture));
            Assert.Equal("0.123 V/m", new ElectricField(0.123456, ElectricFieldUnit.VoltPerMeter).ToString("s3", culture));
            Assert.Equal("0.1235 V/m", new ElectricField(0.123456, ElectricFieldUnit.VoltPerMeter).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            CultureInfo formatProvider = cultureName == null
                ? null
                : CultureInfo.GetCultureInfo(cultureName);

            Assert.Equal(quantity.ToString("g", formatProvider), quantity.ToString(null, formatProvider));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("g")]
        public void ToString_NullProvider_EqualsCurrentCulture(string format)
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ElectricField)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ElectricFieldUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Equal(ElectricField.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Equal(ElectricField.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ElectricField.FromVoltsPerMeter(1.0);
            Assert.Equal(new {ElectricField.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ElectricField.FromVoltsPerMeter(value);
            Assert.Equal(ElectricField.FromVoltsPerMeter(-value), -quantity);
        }
    }
}
