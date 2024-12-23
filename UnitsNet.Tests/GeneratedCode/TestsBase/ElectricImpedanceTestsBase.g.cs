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
    /// Test of ElectricImpedance.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricImpedanceTestsBase : QuantityTestsBase
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

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(ElectricImpedanceUnit unit)
        {
            return unit switch
            {
                ElectricImpedanceUnit.Gigaohm => (GigaohmsInOneOhm, GigaohmsTolerance),
                ElectricImpedanceUnit.Kiloohm => (KiloohmsInOneOhm, KiloohmsTolerance),
                ElectricImpedanceUnit.Megaohm => (MegaohmsInOneOhm, MegaohmsTolerance),
                ElectricImpedanceUnit.Microohm => (MicroohmsInOneOhm, MicroohmsTolerance),
                ElectricImpedanceUnit.Milliohm => (MilliohmsInOneOhm, MilliohmsTolerance),
                ElectricImpedanceUnit.Nanoohm => (NanoohmsInOneOhm, NanoohmsTolerance),
                ElectricImpedanceUnit.Ohm => (OhmsInOneOhm, OhmsTolerance),
                ElectricImpedanceUnit.Teraohm => (TeraohmsInOneOhm, TeraohmsTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { ElectricImpedanceUnit.Gigaohm },
            new object[] { ElectricImpedanceUnit.Kiloohm },
            new object[] { ElectricImpedanceUnit.Megaohm },
            new object[] { ElectricImpedanceUnit.Microohm },
            new object[] { ElectricImpedanceUnit.Milliohm },
            new object[] { ElectricImpedanceUnit.Nanoohm },
            new object[] { ElectricImpedanceUnit.Ohm },
            new object[] { ElectricImpedanceUnit.Teraohm },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ElectricImpedance();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ElectricImpedanceUnit.Ohm, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => new ElectricImpedance(double.PositiveInfinity, ElectricImpedanceUnit.Ohm));
            var exception2 = Record.Exception(() => new ElectricImpedance(double.NegativeInfinity, ElectricImpedanceUnit.Ohm));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void Ctor_WithNaNValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => new ElectricImpedance(double.NaN, ElectricImpedanceUnit.Ohm));

            Assert.Null(exception);
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ElectricImpedance(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new ElectricImpedance(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (ElectricImpedance) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void ElectricImpedance_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ElectricImpedance(1, ElectricImpedanceUnit.Ohm);

            QuantityInfo<ElectricImpedanceUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ElectricImpedance.Zero, quantityInfo.Zero);
            Assert.Equal("ElectricImpedance", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<ElectricImpedanceUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void OhmToElectricImpedanceUnits()
        {
            ElectricImpedance ohm = ElectricImpedance.FromOhms(1);
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
            var quantity00 = ElectricImpedance.From(1, ElectricImpedanceUnit.Gigaohm);
            AssertEx.EqualTolerance(1, quantity00.Gigaohms, GigaohmsTolerance);
            Assert.Equal(ElectricImpedanceUnit.Gigaohm, quantity00.Unit);

            var quantity01 = ElectricImpedance.From(1, ElectricImpedanceUnit.Kiloohm);
            AssertEx.EqualTolerance(1, quantity01.Kiloohms, KiloohmsTolerance);
            Assert.Equal(ElectricImpedanceUnit.Kiloohm, quantity01.Unit);

            var quantity02 = ElectricImpedance.From(1, ElectricImpedanceUnit.Megaohm);
            AssertEx.EqualTolerance(1, quantity02.Megaohms, MegaohmsTolerance);
            Assert.Equal(ElectricImpedanceUnit.Megaohm, quantity02.Unit);

            var quantity03 = ElectricImpedance.From(1, ElectricImpedanceUnit.Microohm);
            AssertEx.EqualTolerance(1, quantity03.Microohms, MicroohmsTolerance);
            Assert.Equal(ElectricImpedanceUnit.Microohm, quantity03.Unit);

            var quantity04 = ElectricImpedance.From(1, ElectricImpedanceUnit.Milliohm);
            AssertEx.EqualTolerance(1, quantity04.Milliohms, MilliohmsTolerance);
            Assert.Equal(ElectricImpedanceUnit.Milliohm, quantity04.Unit);

            var quantity05 = ElectricImpedance.From(1, ElectricImpedanceUnit.Nanoohm);
            AssertEx.EqualTolerance(1, quantity05.Nanoohms, NanoohmsTolerance);
            Assert.Equal(ElectricImpedanceUnit.Nanoohm, quantity05.Unit);

            var quantity06 = ElectricImpedance.From(1, ElectricImpedanceUnit.Ohm);
            AssertEx.EqualTolerance(1, quantity06.Ohms, OhmsTolerance);
            Assert.Equal(ElectricImpedanceUnit.Ohm, quantity06.Unit);

            var quantity07 = ElectricImpedance.From(1, ElectricImpedanceUnit.Teraohm);
            AssertEx.EqualTolerance(1, quantity07.Teraohms, TeraohmsTolerance);
            Assert.Equal(ElectricImpedanceUnit.Teraohm, quantity07.Unit);

        }

        [Fact]
        public void FromOhms_WithInfinityValue_DoNotThrowsArgumentException()
        {
            var exception1 = Record.Exception(() => ElectricImpedance.FromOhms(double.PositiveInfinity));
            var exception2 = Record.Exception(() => ElectricImpedance.FromOhms(double.NegativeInfinity));

            Assert.Null(exception1);
            Assert.Null(exception2);
        }

        [Fact]
        public void FromOhms_WithNanValue_DoNotThrowsArgumentException()
        {
            var exception = Record.Exception(() => ElectricImpedance.FromOhms(double.NaN));

            Assert.Null(exception);
        }

        [Fact]
        public void As()
        {
            var ohm = ElectricImpedance.FromOhms(1);
            AssertEx.EqualTolerance(GigaohmsInOneOhm, ohm.As(ElectricImpedanceUnit.Gigaohm), GigaohmsTolerance);
            AssertEx.EqualTolerance(KiloohmsInOneOhm, ohm.As(ElectricImpedanceUnit.Kiloohm), KiloohmsTolerance);
            AssertEx.EqualTolerance(MegaohmsInOneOhm, ohm.As(ElectricImpedanceUnit.Megaohm), MegaohmsTolerance);
            AssertEx.EqualTolerance(MicroohmsInOneOhm, ohm.As(ElectricImpedanceUnit.Microohm), MicroohmsTolerance);
            AssertEx.EqualTolerance(MilliohmsInOneOhm, ohm.As(ElectricImpedanceUnit.Milliohm), MilliohmsTolerance);
            AssertEx.EqualTolerance(NanoohmsInOneOhm, ohm.As(ElectricImpedanceUnit.Nanoohm), NanoohmsTolerance);
            AssertEx.EqualTolerance(OhmsInOneOhm, ohm.As(ElectricImpedanceUnit.Ohm), OhmsTolerance);
            AssertEx.EqualTolerance(TeraohmsInOneOhm, ohm.As(ElectricImpedanceUnit.Teraohm), TeraohmsTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new ElectricImpedance(value: 1, unit: ElectricImpedance.BaseUnit);
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
                var parsed = ElectricImpedance.Parse("1 GΩ", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Gigaohms, GigaohmsTolerance);
                Assert.Equal(ElectricImpedanceUnit.Gigaohm, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricImpedance.Parse("1 kΩ", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Kiloohms, KiloohmsTolerance);
                Assert.Equal(ElectricImpedanceUnit.Kiloohm, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricImpedance.Parse("1 MΩ", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Megaohms, MegaohmsTolerance);
                Assert.Equal(ElectricImpedanceUnit.Megaohm, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricImpedance.Parse("1 µΩ", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Microohms, MicroohmsTolerance);
                Assert.Equal(ElectricImpedanceUnit.Microohm, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricImpedance.Parse("1 mΩ", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Milliohms, MilliohmsTolerance);
                Assert.Equal(ElectricImpedanceUnit.Milliohm, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricImpedance.Parse("1 nΩ", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Nanoohms, NanoohmsTolerance);
                Assert.Equal(ElectricImpedanceUnit.Nanoohm, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricImpedance.Parse("1 Ω", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Ohms, OhmsTolerance);
                Assert.Equal(ElectricImpedanceUnit.Ohm, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricImpedance.Parse("1 TΩ", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.Teraohms, TeraohmsTolerance);
                Assert.Equal(ElectricImpedanceUnit.Teraohm, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(ElectricImpedance.TryParse("1 GΩ", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Gigaohms, GigaohmsTolerance);
                Assert.Equal(ElectricImpedanceUnit.Gigaohm, parsed.Unit);
            }

            {
                Assert.True(ElectricImpedance.TryParse("1 kΩ", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Kiloohms, KiloohmsTolerance);
                Assert.Equal(ElectricImpedanceUnit.Kiloohm, parsed.Unit);
            }

            {
                Assert.True(ElectricImpedance.TryParse("1 µΩ", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Microohms, MicroohmsTolerance);
                Assert.Equal(ElectricImpedanceUnit.Microohm, parsed.Unit);
            }

            {
                Assert.True(ElectricImpedance.TryParse("1 nΩ", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Nanoohms, NanoohmsTolerance);
                Assert.Equal(ElectricImpedanceUnit.Nanoohm, parsed.Unit);
            }

            {
                Assert.True(ElectricImpedance.TryParse("1 Ω", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Ohms, OhmsTolerance);
                Assert.Equal(ElectricImpedanceUnit.Ohm, parsed.Unit);
            }

            {
                Assert.True(ElectricImpedance.TryParse("1 TΩ", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.Teraohms, TeraohmsTolerance);
                Assert.Equal(ElectricImpedanceUnit.Teraohm, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = ElectricImpedance.ParseUnit("GΩ", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricImpedanceUnit.Gigaohm, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricImpedance.ParseUnit("kΩ", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricImpedanceUnit.Kiloohm, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricImpedance.ParseUnit("MΩ", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricImpedanceUnit.Megaohm, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricImpedance.ParseUnit("µΩ", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricImpedanceUnit.Microohm, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricImpedance.ParseUnit("mΩ", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricImpedanceUnit.Milliohm, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricImpedance.ParseUnit("nΩ", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricImpedanceUnit.Nanoohm, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricImpedance.ParseUnit("Ω", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricImpedanceUnit.Ohm, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricImpedance.ParseUnit("TΩ", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricImpedanceUnit.Teraohm, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(ElectricImpedance.TryParseUnit("GΩ", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricImpedanceUnit.Gigaohm, parsedUnit);
            }

            {
                Assert.True(ElectricImpedance.TryParseUnit("kΩ", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricImpedanceUnit.Kiloohm, parsedUnit);
            }

            {
                Assert.True(ElectricImpedance.TryParseUnit("µΩ", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricImpedanceUnit.Microohm, parsedUnit);
            }

            {
                Assert.True(ElectricImpedance.TryParseUnit("nΩ", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricImpedanceUnit.Nanoohm, parsedUnit);
            }

            {
                Assert.True(ElectricImpedance.TryParseUnit("Ω", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricImpedanceUnit.Ohm, parsedUnit);
            }

            {
                Assert.True(ElectricImpedance.TryParseUnit("TΩ", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricImpedanceUnit.Teraohm, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(ElectricImpedanceUnit unit)
        {
            var inBaseUnits = ElectricImpedance.From(1.0, ElectricImpedance.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(ElectricImpedanceUnit unit)
        {
            var quantity = ElectricImpedance.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(ElectricImpedanceUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = ElectricImpedance.Units.First(u => u != ElectricImpedance.BaseUnit);

            var quantity = ElectricImpedance.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(ElectricImpedanceUnit unit)
        {
            var quantity = default(ElectricImpedance);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricImpedance ohm = ElectricImpedance.FromOhms(1);
            AssertEx.EqualTolerance(1, ElectricImpedance.FromGigaohms(ohm.Gigaohms).Ohms, GigaohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricImpedance.FromKiloohms(ohm.Kiloohms).Ohms, KiloohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricImpedance.FromMegaohms(ohm.Megaohms).Ohms, MegaohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricImpedance.FromMicroohms(ohm.Microohms).Ohms, MicroohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricImpedance.FromMilliohms(ohm.Milliohms).Ohms, MilliohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricImpedance.FromNanoohms(ohm.Nanoohms).Ohms, NanoohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricImpedance.FromOhms(ohm.Ohms).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(1, ElectricImpedance.FromTeraohms(ohm.Teraohms).Ohms, TeraohmsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricImpedance v = ElectricImpedance.FromOhms(1);
            AssertEx.EqualTolerance(-1, -v.Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(2, (ElectricImpedance.FromOhms(3)-v).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(2, (ElectricImpedance.FromOhms(10)/5).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(2, ElectricImpedance.FromOhms(10)/ElectricImpedance.FromOhms(5), OhmsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricImpedance oneOhm = ElectricImpedance.FromOhms(1);
            ElectricImpedance twoOhms = ElectricImpedance.FromOhms(2);

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
            ElectricImpedance ohm = ElectricImpedance.FromOhms(1);
            Assert.Equal(0, ohm.CompareTo(ohm));
            Assert.True(ohm.CompareTo(ElectricImpedance.Zero) > 0);
            Assert.True(ElectricImpedance.Zero.CompareTo(ohm) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricImpedance ohm = ElectricImpedance.FromOhms(1);
            Assert.Throws<ArgumentException>(() => ohm.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricImpedance ohm = ElectricImpedance.FromOhms(1);
            Assert.Throws<ArgumentNullException>(() => ohm.CompareTo(null));
        }

        [Theory]
        [InlineData(1, ElectricImpedanceUnit.Ohm, 1, ElectricImpedanceUnit.Ohm, true)]  // Same value and unit.
        [InlineData(1, ElectricImpedanceUnit.Ohm, 2, ElectricImpedanceUnit.Ohm, false)] // Different value.
        [InlineData(2, ElectricImpedanceUnit.Ohm, 1, ElectricImpedanceUnit.Gigaohm, false)] // Different value and unit.
        [InlineData(1, ElectricImpedanceUnit.Ohm, 1, ElectricImpedanceUnit.Gigaohm, false)] // Different unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, ElectricImpedanceUnit unitA, double valueB, ElectricImpedanceUnit unitB, bool expectEqual)
        {
            var a = new ElectricImpedance(valueA, unitA);
            var b = new ElectricImpedance(valueB, unitB);

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
            var a = ElectricImpedance.Zero;

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
            var v = ElectricImpedance.FromOhms(1);
            Assert.True(v.Equals(ElectricImpedance.FromOhms(1), OhmsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricImpedance.Zero, OhmsTolerance, ComparisonType.Relative));
            Assert.True(ElectricImpedance.FromOhms(100).Equals(ElectricImpedance.FromOhms(120), 0.3, ComparisonType.Relative));
            Assert.False(ElectricImpedance.FromOhms(100).Equals(ElectricImpedance.FromOhms(120), 0.1, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ElectricImpedance.FromOhms(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ElectricImpedance.FromOhms(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricImpedance ohm = ElectricImpedance.FromOhms(1);
            Assert.False(ohm.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricImpedance ohm = ElectricImpedance.FromOhms(1);
            Assert.False(ohm.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ElectricImpedanceUnit)).Cast<ElectricImpedanceUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ElectricImpedance.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 GΩ", new ElectricImpedance(1, ElectricImpedanceUnit.Gigaohm).ToString());
                Assert.Equal("1 kΩ", new ElectricImpedance(1, ElectricImpedanceUnit.Kiloohm).ToString());
                Assert.Equal("1 MΩ", new ElectricImpedance(1, ElectricImpedanceUnit.Megaohm).ToString());
                Assert.Equal("1 µΩ", new ElectricImpedance(1, ElectricImpedanceUnit.Microohm).ToString());
                Assert.Equal("1 mΩ", new ElectricImpedance(1, ElectricImpedanceUnit.Milliohm).ToString());
                Assert.Equal("1 nΩ", new ElectricImpedance(1, ElectricImpedanceUnit.Nanoohm).ToString());
                Assert.Equal("1 Ω", new ElectricImpedance(1, ElectricImpedanceUnit.Ohm).ToString());
                Assert.Equal("1 TΩ", new ElectricImpedance(1, ElectricImpedanceUnit.Teraohm).ToString());
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

            Assert.Equal("1 GΩ", new ElectricImpedance(1, ElectricImpedanceUnit.Gigaohm).ToString(swedishCulture));
            Assert.Equal("1 kΩ", new ElectricImpedance(1, ElectricImpedanceUnit.Kiloohm).ToString(swedishCulture));
            Assert.Equal("1 MΩ", new ElectricImpedance(1, ElectricImpedanceUnit.Megaohm).ToString(swedishCulture));
            Assert.Equal("1 µΩ", new ElectricImpedance(1, ElectricImpedanceUnit.Microohm).ToString(swedishCulture));
            Assert.Equal("1 mΩ", new ElectricImpedance(1, ElectricImpedanceUnit.Milliohm).ToString(swedishCulture));
            Assert.Equal("1 nΩ", new ElectricImpedance(1, ElectricImpedanceUnit.Nanoohm).ToString(swedishCulture));
            Assert.Equal("1 Ω", new ElectricImpedance(1, ElectricImpedanceUnit.Ohm).ToString(swedishCulture));
            Assert.Equal("1 TΩ", new ElectricImpedance(1, ElectricImpedanceUnit.Teraohm).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 Ω", new ElectricImpedance(0.123456, ElectricImpedanceUnit.Ohm).ToString("s1"));
                Assert.Equal("0.12 Ω", new ElectricImpedance(0.123456, ElectricImpedanceUnit.Ohm).ToString("s2"));
                Assert.Equal("0.123 Ω", new ElectricImpedance(0.123456, ElectricImpedanceUnit.Ohm).ToString("s3"));
                Assert.Equal("0.1235 Ω", new ElectricImpedance(0.123456, ElectricImpedanceUnit.Ohm).ToString("s4"));
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
            Assert.Equal("0.1 Ω", new ElectricImpedance(0.123456, ElectricImpedanceUnit.Ohm).ToString("s1", culture));
            Assert.Equal("0.12 Ω", new ElectricImpedance(0.123456, ElectricImpedanceUnit.Ohm).ToString("s2", culture));
            Assert.Equal("0.123 Ω", new ElectricImpedance(0.123456, ElectricImpedanceUnit.Ohm).ToString("s3", culture));
            Assert.Equal("0.1235 Ω", new ElectricImpedance(0.123456, ElectricImpedanceUnit.Ohm).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            CultureInfo formatProvider = cultureName == null
                ? null
                : CultureInfo.GetCultureInfo(cultureName);

            Assert.Equal(quantity.ToString("G", formatProvider), quantity.ToString(null, formatProvider));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("g")]
        public void ToString_NullProvider_EqualsCurrentCulture(string format)
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ElectricImpedance)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ElectricImpedanceUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Equal(ElectricImpedance.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Equal(ElectricImpedance.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ElectricImpedance.FromOhms(1.0);
            Assert.Equal(new {ElectricImpedance.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ElectricImpedance.FromOhms(value);
            Assert.Equal(ElectricImpedance.FromOhms(-value), -quantity);
        }
    }
}
