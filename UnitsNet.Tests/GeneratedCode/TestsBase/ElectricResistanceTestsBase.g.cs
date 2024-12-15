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
    /// Test of ElectricResistance.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricResistanceTestsBase : QuantityTestsBase
    {
        protected abstract double GigaohmsInOneOhm { get; }
        protected abstract double KiloohmsInOneOhm { get; }
        protected abstract double MegaohmsInOneOhm { get; }
        protected abstract double MicroohmsInOneOhm { get; }
        protected abstract double MilliohmsInOneOhm { get; }
        protected abstract double NanoohmsInOneOhm { get; }
        protected abstract double OhmsInOneOhm { get; }
        protected abstract double TeraohmsInOneOhm { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double GigaohmsTolerance { get { return 1e-5; } }
        protected virtual double KiloohmsTolerance { get { return 1e-5; } }
        protected virtual double MegaohmsTolerance { get { return 1e-5; } }
        protected virtual double MicroohmsTolerance { get { return 1e-5; } }
        protected virtual double MilliohmsTolerance { get { return 1e-5; } }
        protected virtual double NanoohmsTolerance { get { return 1e-5; } }
        protected virtual double OhmsTolerance { get { return 1e-5; } }
        protected virtual double TeraohmsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(ElectricResistanceUnit unit)
        {
            return unit switch
            {
                ElectricResistanceUnit.Gigaohm => (GigaohmsInOneOhm, GigaohmsTolerance),
                ElectricResistanceUnit.Kiloohm => (KiloohmsInOneOhm, KiloohmsTolerance),
                ElectricResistanceUnit.Megaohm => (MegaohmsInOneOhm, MegaohmsTolerance),
                ElectricResistanceUnit.Microohm => (MicroohmsInOneOhm, MicroohmsTolerance),
                ElectricResistanceUnit.Milliohm => (MilliohmsInOneOhm, MilliohmsTolerance),
                ElectricResistanceUnit.Nanoohm => (NanoohmsInOneOhm, NanoohmsTolerance),
                ElectricResistanceUnit.Ohm => (OhmsInOneOhm, OhmsTolerance),
                ElectricResistanceUnit.Teraohm => (TeraohmsInOneOhm, TeraohmsTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { ElectricResistanceUnit.Gigaohm },
            new object[] { ElectricResistanceUnit.Kiloohm },
            new object[] { ElectricResistanceUnit.Megaohm },
            new object[] { ElectricResistanceUnit.Microohm },
            new object[] { ElectricResistanceUnit.Milliohm },
            new object[] { ElectricResistanceUnit.Nanoohm },
            new object[] { ElectricResistanceUnit.Ohm },
            new object[] { ElectricResistanceUnit.Teraohm },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ElectricResistance();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ElectricResistanceUnit.Ohm, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricResistance(double.PositiveInfinity, ElectricResistanceUnit.Ohm));
            Assert.Throws<ArgumentException>(() => new ElectricResistance(double.NegativeInfinity, ElectricResistanceUnit.Ohm));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricResistance(double.NaN, ElectricResistanceUnit.Ohm));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ElectricResistance(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new ElectricResistance(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (ElectricResistance) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void ElectricResistance_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ElectricResistance(1, ElectricResistanceUnit.Ohm);

            QuantityInfo<ElectricResistanceUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ElectricResistance.Zero, quantityInfo.Zero);
            Assert.Equal("ElectricResistance", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<ElectricResistanceUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void OhmToElectricResistanceUnits()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            AssertEx.EqualTolerance(GigaohmsInOneOhm, ohm.Gigaohms, GigaohmsTolerance);
            AssertEx.EqualTolerance(KiloohmsInOneOhm, ohm.Kiloohms, KiloohmsTolerance);
            AssertEx.EqualTolerance(MegaohmsInOneOhm, ohm.Megaohms, MegaohmsTolerance);
            AssertEx.EqualTolerance(MicroohmsInOneOhm, ohm.Microohms, MicroohmsTolerance);
            AssertEx.EqualTolerance(MilliohmsInOneOhm, ohm.Milliohms, MilliohmsTolerance);
            AssertEx.EqualTolerance(NanoohmsInOneOhm, ohm.Nanoohms, NanoohmsTolerance);
            AssertEx.EqualTolerance(OhmsInOneOhm, ohm.Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(TeraohmsInOneOhm, ohm.Teraohms, TeraohmsTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ElectricResistance.From(1, ElectricResistanceUnit.Gigaohm);
            AssertEx.EqualTolerance(1, quantity00.Gigaohms, GigaohmsTolerance);
            Assert.Equal(ElectricResistanceUnit.Gigaohm, quantity00.Unit);

            var quantity01 = ElectricResistance.From(1, ElectricResistanceUnit.Kiloohm);
            AssertEx.EqualTolerance(1, quantity01.Kiloohms, KiloohmsTolerance);
            Assert.Equal(ElectricResistanceUnit.Kiloohm, quantity01.Unit);

            var quantity02 = ElectricResistance.From(1, ElectricResistanceUnit.Megaohm);
            AssertEx.EqualTolerance(1, quantity02.Megaohms, MegaohmsTolerance);
            Assert.Equal(ElectricResistanceUnit.Megaohm, quantity02.Unit);

            var quantity03 = ElectricResistance.From(1, ElectricResistanceUnit.Microohm);
            AssertEx.EqualTolerance(1, quantity03.Microohms, MicroohmsTolerance);
            Assert.Equal(ElectricResistanceUnit.Microohm, quantity03.Unit);

            var quantity04 = ElectricResistance.From(1, ElectricResistanceUnit.Milliohm);
            AssertEx.EqualTolerance(1, quantity04.Milliohms, MilliohmsTolerance);
            Assert.Equal(ElectricResistanceUnit.Milliohm, quantity04.Unit);

            var quantity05 = ElectricResistance.From(1, ElectricResistanceUnit.Nanoohm);
            AssertEx.EqualTolerance(1, quantity05.Nanoohms, NanoohmsTolerance);
            Assert.Equal(ElectricResistanceUnit.Nanoohm, quantity05.Unit);

            var quantity06 = ElectricResistance.From(1, ElectricResistanceUnit.Ohm);
            AssertEx.EqualTolerance(1, quantity06.Ohms, OhmsTolerance);
            Assert.Equal(ElectricResistanceUnit.Ohm, quantity06.Unit);

            var quantity07 = ElectricResistance.From(1, ElectricResistanceUnit.Teraohm);
            AssertEx.EqualTolerance(1, quantity07.Teraohms, TeraohmsTolerance);
            Assert.Equal(ElectricResistanceUnit.Teraohm, quantity07.Unit);

        }

        [Fact]
        public void FromOhms_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricResistance.FromOhms(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ElectricResistance.FromOhms(double.NegativeInfinity));
        }

        [Fact]
        public void FromOhms_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricResistance.FromOhms(double.NaN));
        }

        [Fact]
        public void As()
        {
            var ohm = ElectricResistance.FromOhms(1);
            AssertEx.EqualTolerance(GigaohmsInOneOhm, ohm.As(ElectricResistanceUnit.Gigaohm), GigaohmsTolerance);
            AssertEx.EqualTolerance(KiloohmsInOneOhm, ohm.As(ElectricResistanceUnit.Kiloohm), KiloohmsTolerance);
            AssertEx.EqualTolerance(MegaohmsInOneOhm, ohm.As(ElectricResistanceUnit.Megaohm), MegaohmsTolerance);
            AssertEx.EqualTolerance(MicroohmsInOneOhm, ohm.As(ElectricResistanceUnit.Microohm), MicroohmsTolerance);
            AssertEx.EqualTolerance(MilliohmsInOneOhm, ohm.As(ElectricResistanceUnit.Milliohm), MilliohmsTolerance);
            AssertEx.EqualTolerance(NanoohmsInOneOhm, ohm.As(ElectricResistanceUnit.Nanoohm), NanoohmsTolerance);
            AssertEx.EqualTolerance(OhmsInOneOhm, ohm.As(ElectricResistanceUnit.Ohm), OhmsTolerance);
            AssertEx.EqualTolerance(TeraohmsInOneOhm, ohm.As(ElectricResistanceUnit.Teraohm), TeraohmsTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new ElectricResistance(value: 1, unit: ElectricResistance.BaseUnit);
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
                var parsed = ElectricResistance.Parse("1 GΩ", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Gigaohms, GigaohmsTolerance);
                Assert.Equal(ElectricResistanceUnit.Gigaohm, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricResistance.Parse("1 kΩ", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Kiloohms, KiloohmsTolerance);
                Assert.Equal(ElectricResistanceUnit.Kiloohm, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricResistance.Parse("1 MΩ", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Megaohms, MegaohmsTolerance);
                Assert.Equal(ElectricResistanceUnit.Megaohm, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricResistance.Parse("1 µΩ", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Microohms, MicroohmsTolerance);
                Assert.Equal(ElectricResistanceUnit.Microohm, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricResistance.Parse("1 mΩ", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Milliohms, MilliohmsTolerance);
                Assert.Equal(ElectricResistanceUnit.Milliohm, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricResistance.Parse("1 nΩ", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Nanoohms, NanoohmsTolerance);
                Assert.Equal(ElectricResistanceUnit.Nanoohm, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricResistance.Parse("1 Ω", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Ohms, OhmsTolerance);
                Assert.Equal(ElectricResistanceUnit.Ohm, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricResistance.Parse("1 TΩ", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Teraohms, TeraohmsTolerance);
                Assert.Equal(ElectricResistanceUnit.Teraohm, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(ElectricResistance.TryParse("1 GΩ", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Gigaohms, GigaohmsTolerance);
                Assert.Equal(ElectricResistanceUnit.Gigaohm, parsed.Unit);
            }

            {
                Assert.True(ElectricResistance.TryParse("1 kΩ", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Kiloohms, KiloohmsTolerance);
                Assert.Equal(ElectricResistanceUnit.Kiloohm, parsed.Unit);
            }

            {
                Assert.True(ElectricResistance.TryParse("1 µΩ", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Microohms, MicroohmsTolerance);
                Assert.Equal(ElectricResistanceUnit.Microohm, parsed.Unit);
            }

            {
                Assert.True(ElectricResistance.TryParse("1 nΩ", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Nanoohms, NanoohmsTolerance);
                Assert.Equal(ElectricResistanceUnit.Nanoohm, parsed.Unit);
            }

            {
                Assert.True(ElectricResistance.TryParse("1 Ω", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Ohms, OhmsTolerance);
                Assert.Equal(ElectricResistanceUnit.Ohm, parsed.Unit);
            }

            {
                Assert.True(ElectricResistance.TryParse("1 TΩ", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Teraohms, TeraohmsTolerance);
                Assert.Equal(ElectricResistanceUnit.Teraohm, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = ElectricResistance.ParseUnit("GΩ", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricResistanceUnit.Gigaohm, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricResistance.ParseUnit("kΩ", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricResistanceUnit.Kiloohm, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricResistance.ParseUnit("MΩ", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricResistanceUnit.Megaohm, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricResistance.ParseUnit("µΩ", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricResistanceUnit.Microohm, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricResistance.ParseUnit("mΩ", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricResistanceUnit.Milliohm, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricResistance.ParseUnit("nΩ", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricResistanceUnit.Nanoohm, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricResistance.ParseUnit("Ω", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricResistanceUnit.Ohm, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricResistance.ParseUnit("TΩ", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricResistanceUnit.Teraohm, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(ElectricResistance.TryParseUnit("GΩ", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricResistanceUnit.Gigaohm, parsedUnit);
            }

            {
                Assert.True(ElectricResistance.TryParseUnit("kΩ", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricResistanceUnit.Kiloohm, parsedUnit);
            }

            {
                Assert.True(ElectricResistance.TryParseUnit("µΩ", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricResistanceUnit.Microohm, parsedUnit);
            }

            {
                Assert.True(ElectricResistance.TryParseUnit("nΩ", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricResistanceUnit.Nanoohm, parsedUnit);
            }

            {
                Assert.True(ElectricResistance.TryParseUnit("Ω", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricResistanceUnit.Ohm, parsedUnit);
            }

            {
                Assert.True(ElectricResistance.TryParseUnit("TΩ", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricResistanceUnit.Teraohm, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(ElectricResistanceUnit unit)
        {
            var inBaseUnits = ElectricResistance.From(1.0, ElectricResistance.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(ElectricResistanceUnit unit)
        {
            var quantity = ElectricResistance.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(ElectricResistanceUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = ElectricResistance.Units.First(u => u != ElectricResistance.BaseUnit);

            var quantity = ElectricResistance.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(ElectricResistanceUnit unit)
        {
            var quantity = default(ElectricResistance);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            AssertEx.EqualTolerance(1, ElectricResistance.FromGigaohms(ohm.Gigaohms).Ohms, GigaohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricResistance.FromKiloohms(ohm.Kiloohms).Ohms, KiloohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricResistance.FromMegaohms(ohm.Megaohms).Ohms, MegaohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricResistance.FromMicroohms(ohm.Microohms).Ohms, MicroohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricResistance.FromMilliohms(ohm.Milliohms).Ohms, MilliohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricResistance.FromNanoohms(ohm.Nanoohms).Ohms, NanoohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricResistance.FromOhms(ohm.Ohms).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(1, ElectricResistance.FromTeraohms(ohm.Teraohms).Ohms, TeraohmsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricResistance v = ElectricResistance.FromOhms(1);
            AssertEx.EqualTolerance(-1, -v.Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(2, (ElectricResistance.FromOhms(3)-v).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(2, (ElectricResistance.FromOhms(10)/5).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(2, ElectricResistance.FromOhms(10)/ElectricResistance.FromOhms(5), OhmsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricResistance oneOhm = ElectricResistance.FromOhms(1);
            ElectricResistance twoOhms = ElectricResistance.FromOhms(2);

            Assert.True(oneOhm < twoOhms);
            Assert.True(oneOhm <= twoOhms);
            Assert.True(twoOhms > oneOhm);
            Assert.True(twoOhms >= oneOhm);

            Assert.False(oneOhm > twoOhms);
            Assert.False(oneOhm >= twoOhms);
            Assert.False(twoOhms < oneOhm);
            Assert.False(twoOhms <= oneOhm);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            Assert.Equal(0, ohm.CompareTo(ohm));
            Assert.True(ohm.CompareTo(ElectricResistance.Zero) > 0);
            Assert.True(ElectricResistance.Zero.CompareTo(ohm) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            Assert.Throws<ArgumentException>(() => ohm.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            Assert.Throws<ArgumentNullException>(() => ohm.CompareTo(null));
        }

        [Theory]
        [InlineData(1, ElectricResistanceUnit.Ohm, 1, ElectricResistanceUnit.Ohm, true)]  // Same value and unit.
        [InlineData(1, ElectricResistanceUnit.Ohm, 2, ElectricResistanceUnit.Ohm, false)] // Different value.
        [InlineData(2, ElectricResistanceUnit.Ohm, 1, ElectricResistanceUnit.Gigaohm, false)] // Different value and unit.
        [InlineData(1, ElectricResistanceUnit.Ohm, 1, ElectricResistanceUnit.Gigaohm, false)] // Different unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, ElectricResistanceUnit unitA, double valueB, ElectricResistanceUnit unitB, bool expectEqual)
        {
            var a = new ElectricResistance(valueA, unitA);
            var b = new ElectricResistance(valueB, unitB);

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
            var a = ElectricResistance.Zero;

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
            var v = ElectricResistance.FromOhms(1);
            Assert.True(v.Equals(ElectricResistance.FromOhms(1), OhmsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricResistance.Zero, OhmsTolerance, ComparisonType.Relative));
            Assert.True(ElectricResistance.FromOhms(100).Equals(ElectricResistance.FromOhms(120), (double)0.3m, ComparisonType.Relative));
            Assert.False(ElectricResistance.FromOhms(100).Equals(ElectricResistance.FromOhms(120), (double)0.1m, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ElectricResistance.FromOhms(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ElectricResistance.FromOhms(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            Assert.False(ohm.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            Assert.False(ohm.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ElectricResistanceUnit)).Cast<ElectricResistanceUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ElectricResistance.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 GΩ", new ElectricResistance(1, ElectricResistanceUnit.Gigaohm).ToString());
                Assert.Equal("1 kΩ", new ElectricResistance(1, ElectricResistanceUnit.Kiloohm).ToString());
                Assert.Equal("1 MΩ", new ElectricResistance(1, ElectricResistanceUnit.Megaohm).ToString());
                Assert.Equal("1 µΩ", new ElectricResistance(1, ElectricResistanceUnit.Microohm).ToString());
                Assert.Equal("1 mΩ", new ElectricResistance(1, ElectricResistanceUnit.Milliohm).ToString());
                Assert.Equal("1 nΩ", new ElectricResistance(1, ElectricResistanceUnit.Nanoohm).ToString());
                Assert.Equal("1 Ω", new ElectricResistance(1, ElectricResistanceUnit.Ohm).ToString());
                Assert.Equal("1 TΩ", new ElectricResistance(1, ElectricResistanceUnit.Teraohm).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentCulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 GΩ", new ElectricResistance(1, ElectricResistanceUnit.Gigaohm).ToString(swedishCulture));
            Assert.Equal("1 kΩ", new ElectricResistance(1, ElectricResistanceUnit.Kiloohm).ToString(swedishCulture));
            Assert.Equal("1 MΩ", new ElectricResistance(1, ElectricResistanceUnit.Megaohm).ToString(swedishCulture));
            Assert.Equal("1 µΩ", new ElectricResistance(1, ElectricResistanceUnit.Microohm).ToString(swedishCulture));
            Assert.Equal("1 mΩ", new ElectricResistance(1, ElectricResistanceUnit.Milliohm).ToString(swedishCulture));
            Assert.Equal("1 nΩ", new ElectricResistance(1, ElectricResistanceUnit.Nanoohm).ToString(swedishCulture));
            Assert.Equal("1 Ω", new ElectricResistance(1, ElectricResistanceUnit.Ohm).ToString(swedishCulture));
            Assert.Equal("1 TΩ", new ElectricResistance(1, ElectricResistanceUnit.Teraohm).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 Ω", new ElectricResistance(0.123456, ElectricResistanceUnit.Ohm).ToString("s1"));
                Assert.Equal("0.12 Ω", new ElectricResistance(0.123456, ElectricResistanceUnit.Ohm).ToString("s2"));
                Assert.Equal("0.123 Ω", new ElectricResistance(0.123456, ElectricResistanceUnit.Ohm).ToString("s3"));
                Assert.Equal("0.1235 Ω", new ElectricResistance(0.123456, ElectricResistanceUnit.Ohm).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentCulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 Ω", new ElectricResistance(0.123456, ElectricResistanceUnit.Ohm).ToString("s1", culture));
            Assert.Equal("0.12 Ω", new ElectricResistance(0.123456, ElectricResistanceUnit.Ohm).ToString("s2", culture));
            Assert.Equal("0.123 Ω", new ElectricResistance(0.123456, ElectricResistanceUnit.Ohm).ToString("s3", culture));
            Assert.Equal("0.1235 Ω", new ElectricResistance(0.123456, ElectricResistanceUnit.Ohm).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = ElectricResistance.FromOhms(1.0);
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
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ElectricResistance)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ElectricResistanceUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Equal(ElectricResistance.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Equal(ElectricResistance.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ElectricResistance.FromOhms(1.0);
            Assert.Equal(new {ElectricResistance.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ElectricResistance.FromOhms(value);
            Assert.Equal(ElectricResistance.FromOhms(-value), -quantity);
        }
    }
}
