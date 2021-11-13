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
    /// Test of RotationalSpeed.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class RotationalSpeedTestsBase : QuantityTestsBase
    {
        protected abstract double CentiradiansPerSecondInOneRadianPerSecond { get; }
        protected abstract double DeciradiansPerSecondInOneRadianPerSecond { get; }
        protected abstract double DegreesPerMinuteInOneRadianPerSecond { get; }
        protected abstract double DegreesPerSecondInOneRadianPerSecond { get; }
        protected abstract double MicrodegreesPerSecondInOneRadianPerSecond { get; }
        protected abstract double MicroradiansPerSecondInOneRadianPerSecond { get; }
        protected abstract double MillidegreesPerSecondInOneRadianPerSecond { get; }
        protected abstract double MilliradiansPerSecondInOneRadianPerSecond { get; }
        protected abstract double NanodegreesPerSecondInOneRadianPerSecond { get; }
        protected abstract double NanoradiansPerSecondInOneRadianPerSecond { get; }
        protected abstract double RadiansPerSecondInOneRadianPerSecond { get; }
        protected abstract double RevolutionsPerMinuteInOneRadianPerSecond { get; }
        protected abstract double RevolutionsPerSecondInOneRadianPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentiradiansPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DeciradiansPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DegreesPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double DegreesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MicrodegreesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MicroradiansPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MillidegreesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MilliradiansPerSecondTolerance { get { return 1e-5; } }
        protected virtual double NanodegreesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double NanoradiansPerSecondTolerance { get { return 1e-5; } }
        protected virtual double RadiansPerSecondTolerance { get { return 1e-5; } }
        protected virtual double RevolutionsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double RevolutionsPerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalSpeed((double)0.0, RotationalSpeedUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new RotationalSpeed();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(RotationalSpeedUnit.RadianPerSecond, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalSpeed(double.PositiveInfinity, RotationalSpeedUnit.RadianPerSecond));
            Assert.Throws<ArgumentException>(() => new RotationalSpeed(double.NegativeInfinity, RotationalSpeedUnit.RadianPerSecond));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalSpeed(double.NaN, RotationalSpeedUnit.RadianPerSecond));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new RotationalSpeed(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new RotationalSpeed(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (RotationalSpeed) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void RotationalSpeed_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new RotationalSpeed(1, RotationalSpeedUnit.RadianPerSecond);

            QuantityInfo<RotationalSpeedUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(RotationalSpeed.Zero, quantityInfo.Zero);
            Assert.Equal("RotationalSpeed", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<RotationalSpeedUnit>().Except(new[] {RotationalSpeedUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void RadianPerSecondToRotationalSpeedUnits()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            AssertEx.EqualTolerance(CentiradiansPerSecondInOneRadianPerSecond, radianpersecond.CentiradiansPerSecond, CentiradiansPerSecondTolerance);
            AssertEx.EqualTolerance(DeciradiansPerSecondInOneRadianPerSecond, radianpersecond.DeciradiansPerSecond, DeciradiansPerSecondTolerance);
            AssertEx.EqualTolerance(DegreesPerMinuteInOneRadianPerSecond, radianpersecond.DegreesPerMinute, DegreesPerMinuteTolerance);
            AssertEx.EqualTolerance(DegreesPerSecondInOneRadianPerSecond, radianpersecond.DegreesPerSecond, DegreesPerSecondTolerance);
            AssertEx.EqualTolerance(MicrodegreesPerSecondInOneRadianPerSecond, radianpersecond.MicrodegreesPerSecond, MicrodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(MicroradiansPerSecondInOneRadianPerSecond, radianpersecond.MicroradiansPerSecond, MicroradiansPerSecondTolerance);
            AssertEx.EqualTolerance(MillidegreesPerSecondInOneRadianPerSecond, radianpersecond.MillidegreesPerSecond, MillidegreesPerSecondTolerance);
            AssertEx.EqualTolerance(MilliradiansPerSecondInOneRadianPerSecond, radianpersecond.MilliradiansPerSecond, MilliradiansPerSecondTolerance);
            AssertEx.EqualTolerance(NanodegreesPerSecondInOneRadianPerSecond, radianpersecond.NanodegreesPerSecond, NanodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(NanoradiansPerSecondInOneRadianPerSecond, radianpersecond.NanoradiansPerSecond, NanoradiansPerSecondTolerance);
            AssertEx.EqualTolerance(RadiansPerSecondInOneRadianPerSecond, radianpersecond.RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(RevolutionsPerMinuteInOneRadianPerSecond, radianpersecond.RevolutionsPerMinute, RevolutionsPerMinuteTolerance);
            AssertEx.EqualTolerance(RevolutionsPerSecondInOneRadianPerSecond, radianpersecond.RevolutionsPerSecond, RevolutionsPerSecondTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = RotationalSpeed.From(1, RotationalSpeedUnit.CentiradianPerSecond);
            AssertEx.EqualTolerance(1, quantity00.CentiradiansPerSecond, CentiradiansPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.CentiradianPerSecond, quantity00.Unit);

            var quantity01 = RotationalSpeed.From(1, RotationalSpeedUnit.DeciradianPerSecond);
            AssertEx.EqualTolerance(1, quantity01.DeciradiansPerSecond, DeciradiansPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.DeciradianPerSecond, quantity01.Unit);

            var quantity02 = RotationalSpeed.From(1, RotationalSpeedUnit.DegreePerMinute);
            AssertEx.EqualTolerance(1, quantity02.DegreesPerMinute, DegreesPerMinuteTolerance);
            Assert.Equal(RotationalSpeedUnit.DegreePerMinute, quantity02.Unit);

            var quantity03 = RotationalSpeed.From(1, RotationalSpeedUnit.DegreePerSecond);
            AssertEx.EqualTolerance(1, quantity03.DegreesPerSecond, DegreesPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.DegreePerSecond, quantity03.Unit);

            var quantity04 = RotationalSpeed.From(1, RotationalSpeedUnit.MicrodegreePerSecond);
            AssertEx.EqualTolerance(1, quantity04.MicrodegreesPerSecond, MicrodegreesPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.MicrodegreePerSecond, quantity04.Unit);

            var quantity05 = RotationalSpeed.From(1, RotationalSpeedUnit.MicroradianPerSecond);
            AssertEx.EqualTolerance(1, quantity05.MicroradiansPerSecond, MicroradiansPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.MicroradianPerSecond, quantity05.Unit);

            var quantity06 = RotationalSpeed.From(1, RotationalSpeedUnit.MillidegreePerSecond);
            AssertEx.EqualTolerance(1, quantity06.MillidegreesPerSecond, MillidegreesPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.MillidegreePerSecond, quantity06.Unit);

            var quantity07 = RotationalSpeed.From(1, RotationalSpeedUnit.MilliradianPerSecond);
            AssertEx.EqualTolerance(1, quantity07.MilliradiansPerSecond, MilliradiansPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.MilliradianPerSecond, quantity07.Unit);

            var quantity08 = RotationalSpeed.From(1, RotationalSpeedUnit.NanodegreePerSecond);
            AssertEx.EqualTolerance(1, quantity08.NanodegreesPerSecond, NanodegreesPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.NanodegreePerSecond, quantity08.Unit);

            var quantity09 = RotationalSpeed.From(1, RotationalSpeedUnit.NanoradianPerSecond);
            AssertEx.EqualTolerance(1, quantity09.NanoradiansPerSecond, NanoradiansPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.NanoradianPerSecond, quantity09.Unit);

            var quantity10 = RotationalSpeed.From(1, RotationalSpeedUnit.RadianPerSecond);
            AssertEx.EqualTolerance(1, quantity10.RadiansPerSecond, RadiansPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.RadianPerSecond, quantity10.Unit);

            var quantity11 = RotationalSpeed.From(1, RotationalSpeedUnit.RevolutionPerMinute);
            AssertEx.EqualTolerance(1, quantity11.RevolutionsPerMinute, RevolutionsPerMinuteTolerance);
            Assert.Equal(RotationalSpeedUnit.RevolutionPerMinute, quantity11.Unit);

            var quantity12 = RotationalSpeed.From(1, RotationalSpeedUnit.RevolutionPerSecond);
            AssertEx.EqualTolerance(1, quantity12.RevolutionsPerSecond, RevolutionsPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.RevolutionPerSecond, quantity12.Unit);

        }

        [Fact]
        public void FromRadiansPerSecond_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => RotationalSpeed.FromRadiansPerSecond(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => RotationalSpeed.FromRadiansPerSecond(double.NegativeInfinity));
        }

        [Fact]
        public void FromRadiansPerSecond_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => RotationalSpeed.FromRadiansPerSecond(double.NaN));
        }

        [Fact]
        public void As()
        {
            var radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            AssertEx.EqualTolerance(CentiradiansPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.CentiradianPerSecond), CentiradiansPerSecondTolerance);
            AssertEx.EqualTolerance(DeciradiansPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.DeciradianPerSecond), DeciradiansPerSecondTolerance);
            AssertEx.EqualTolerance(DegreesPerMinuteInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.DegreePerMinute), DegreesPerMinuteTolerance);
            AssertEx.EqualTolerance(DegreesPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.DegreePerSecond), DegreesPerSecondTolerance);
            AssertEx.EqualTolerance(MicrodegreesPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.MicrodegreePerSecond), MicrodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(MicroradiansPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.MicroradianPerSecond), MicroradiansPerSecondTolerance);
            AssertEx.EqualTolerance(MillidegreesPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.MillidegreePerSecond), MillidegreesPerSecondTolerance);
            AssertEx.EqualTolerance(MilliradiansPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.MilliradianPerSecond), MilliradiansPerSecondTolerance);
            AssertEx.EqualTolerance(NanodegreesPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.NanodegreePerSecond), NanodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(NanoradiansPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.NanoradianPerSecond), NanoradiansPerSecondTolerance);
            AssertEx.EqualTolerance(RadiansPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.RadianPerSecond), RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(RevolutionsPerMinuteInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.RevolutionPerMinute), RevolutionsPerMinuteTolerance);
            AssertEx.EqualTolerance(RevolutionsPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.RevolutionPerSecond), RevolutionsPerSecondTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new RotationalSpeed(value: 1, unit: RotationalSpeed.ConversionBaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (double) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void ToUnit()
        {
            var radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);

            var centiradianpersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.CentiradianPerSecond);
            AssertEx.EqualTolerance(CentiradiansPerSecondInOneRadianPerSecond, (double)centiradianpersecondQuantity.Value, CentiradiansPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.CentiradianPerSecond, centiradianpersecondQuantity.Unit);

            var deciradianpersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.DeciradianPerSecond);
            AssertEx.EqualTolerance(DeciradiansPerSecondInOneRadianPerSecond, (double)deciradianpersecondQuantity.Value, DeciradiansPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.DeciradianPerSecond, deciradianpersecondQuantity.Unit);

            var degreeperminuteQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.DegreePerMinute);
            AssertEx.EqualTolerance(DegreesPerMinuteInOneRadianPerSecond, (double)degreeperminuteQuantity.Value, DegreesPerMinuteTolerance);
            Assert.Equal(RotationalSpeedUnit.DegreePerMinute, degreeperminuteQuantity.Unit);

            var degreepersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.DegreePerSecond);
            AssertEx.EqualTolerance(DegreesPerSecondInOneRadianPerSecond, (double)degreepersecondQuantity.Value, DegreesPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.DegreePerSecond, degreepersecondQuantity.Unit);

            var microdegreepersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.MicrodegreePerSecond);
            AssertEx.EqualTolerance(MicrodegreesPerSecondInOneRadianPerSecond, (double)microdegreepersecondQuantity.Value, MicrodegreesPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.MicrodegreePerSecond, microdegreepersecondQuantity.Unit);

            var microradianpersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.MicroradianPerSecond);
            AssertEx.EqualTolerance(MicroradiansPerSecondInOneRadianPerSecond, (double)microradianpersecondQuantity.Value, MicroradiansPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.MicroradianPerSecond, microradianpersecondQuantity.Unit);

            var millidegreepersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.MillidegreePerSecond);
            AssertEx.EqualTolerance(MillidegreesPerSecondInOneRadianPerSecond, (double)millidegreepersecondQuantity.Value, MillidegreesPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.MillidegreePerSecond, millidegreepersecondQuantity.Unit);

            var milliradianpersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.MilliradianPerSecond);
            AssertEx.EqualTolerance(MilliradiansPerSecondInOneRadianPerSecond, (double)milliradianpersecondQuantity.Value, MilliradiansPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.MilliradianPerSecond, milliradianpersecondQuantity.Unit);

            var nanodegreepersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.NanodegreePerSecond);
            AssertEx.EqualTolerance(NanodegreesPerSecondInOneRadianPerSecond, (double)nanodegreepersecondQuantity.Value, NanodegreesPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.NanodegreePerSecond, nanodegreepersecondQuantity.Unit);

            var nanoradianpersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.NanoradianPerSecond);
            AssertEx.EqualTolerance(NanoradiansPerSecondInOneRadianPerSecond, (double)nanoradianpersecondQuantity.Value, NanoradiansPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.NanoradianPerSecond, nanoradianpersecondQuantity.Unit);

            var radianpersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.RadianPerSecond);
            AssertEx.EqualTolerance(RadiansPerSecondInOneRadianPerSecond, (double)radianpersecondQuantity.Value, RadiansPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.RadianPerSecond, radianpersecondQuantity.Unit);

            var revolutionperminuteQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.RevolutionPerMinute);
            AssertEx.EqualTolerance(RevolutionsPerMinuteInOneRadianPerSecond, (double)revolutionperminuteQuantity.Value, RevolutionsPerMinuteTolerance);
            Assert.Equal(RotationalSpeedUnit.RevolutionPerMinute, revolutionperminuteQuantity.Unit);

            var revolutionpersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.RevolutionPerSecond);
            AssertEx.EqualTolerance(RevolutionsPerSecondInOneRadianPerSecond, (double)revolutionpersecondQuantity.Value, RevolutionsPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.RevolutionPerSecond, revolutionpersecondQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = RotationalSpeed.FromRadiansPerSecond(1).ToBaseUnit();
            Assert.Equal(RotationalSpeed.ConversionBaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromCentiradiansPerSecond(radianpersecond.CentiradiansPerSecond).RadiansPerSecond, CentiradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromDeciradiansPerSecond(radianpersecond.DeciradiansPerSecond).RadiansPerSecond, DeciradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromDegreesPerMinute(radianpersecond.DegreesPerMinute).RadiansPerSecond, DegreesPerMinuteTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromDegreesPerSecond(radianpersecond.DegreesPerSecond).RadiansPerSecond, DegreesPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromMicrodegreesPerSecond(radianpersecond.MicrodegreesPerSecond).RadiansPerSecond, MicrodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromMicroradiansPerSecond(radianpersecond.MicroradiansPerSecond).RadiansPerSecond, MicroradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromMillidegreesPerSecond(radianpersecond.MillidegreesPerSecond).RadiansPerSecond, MillidegreesPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromMilliradiansPerSecond(radianpersecond.MilliradiansPerSecond).RadiansPerSecond, MilliradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromNanodegreesPerSecond(radianpersecond.NanodegreesPerSecond).RadiansPerSecond, NanodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromNanoradiansPerSecond(radianpersecond.NanoradiansPerSecond).RadiansPerSecond, NanoradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromRadiansPerSecond(radianpersecond.RadiansPerSecond).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromRevolutionsPerMinute(radianpersecond.RevolutionsPerMinute).RadiansPerSecond, RevolutionsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromRevolutionsPerSecond(radianpersecond.RevolutionsPerSecond).RadiansPerSecond, RevolutionsPerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            RotationalSpeed v = RotationalSpeed.FromRadiansPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(2, (RotationalSpeed.FromRadiansPerSecond(3)-v).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(2, (RotationalSpeed.FromRadiansPerSecond(10)/5).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(2, RotationalSpeed.FromRadiansPerSecond(10)/RotationalSpeed.FromRadiansPerSecond(5), RadiansPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            RotationalSpeed oneRadianPerSecond = RotationalSpeed.FromRadiansPerSecond(1);
            RotationalSpeed twoRadiansPerSecond = RotationalSpeed.FromRadiansPerSecond(2);

            Assert.True(oneRadianPerSecond < twoRadiansPerSecond);
            Assert.True(oneRadianPerSecond <= twoRadiansPerSecond);
            Assert.True(twoRadiansPerSecond > oneRadianPerSecond);
            Assert.True(twoRadiansPerSecond >= oneRadianPerSecond);

            Assert.False(oneRadianPerSecond > twoRadiansPerSecond);
            Assert.False(oneRadianPerSecond >= twoRadiansPerSecond);
            Assert.False(twoRadiansPerSecond < oneRadianPerSecond);
            Assert.False(twoRadiansPerSecond <= oneRadianPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            Assert.Equal(0, radianpersecond.CompareTo(radianpersecond));
            Assert.True(radianpersecond.CompareTo(RotationalSpeed.Zero) > 0);
            Assert.True(RotationalSpeed.Zero.CompareTo(radianpersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            Assert.Throws<ArgumentException>(() => radianpersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => radianpersecond.CompareTo(null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = RotationalSpeed.FromRadiansPerSecond(1);
            Assert.True(v.Equals(RotationalSpeed.FromRadiansPerSecond(1), RadiansPerSecondTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(RotationalSpeed.Zero, RadiansPerSecondTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = RotationalSpeed.FromRadiansPerSecond(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(RotationalSpeed.FromRadiansPerSecond(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            Assert.False(radianpersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            Assert.False(radianpersecond.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(RotationalSpeedUnit.Undefined, RotationalSpeed.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(RotationalSpeedUnit)).Cast<RotationalSpeedUnit>();
            foreach(var unit in units)
            {
                if(unit == RotationalSpeedUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(RotationalSpeed.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 crad/s", new RotationalSpeed(1, RotationalSpeedUnit.CentiradianPerSecond).ToString());
                Assert.Equal("1 drad/s", new RotationalSpeed(1, RotationalSpeedUnit.DeciradianPerSecond).ToString());
                Assert.Equal("1 °/min", new RotationalSpeed(1, RotationalSpeedUnit.DegreePerMinute).ToString());
                Assert.Equal("1 °/s", new RotationalSpeed(1, RotationalSpeedUnit.DegreePerSecond).ToString());
                Assert.Equal("1 µ°/s", new RotationalSpeed(1, RotationalSpeedUnit.MicrodegreePerSecond).ToString());
                Assert.Equal("1 µrad/s", new RotationalSpeed(1, RotationalSpeedUnit.MicroradianPerSecond).ToString());
                Assert.Equal("1 m°/s", new RotationalSpeed(1, RotationalSpeedUnit.MillidegreePerSecond).ToString());
                Assert.Equal("1 mrad/s", new RotationalSpeed(1, RotationalSpeedUnit.MilliradianPerSecond).ToString());
                Assert.Equal("1 n°/s", new RotationalSpeed(1, RotationalSpeedUnit.NanodegreePerSecond).ToString());
                Assert.Equal("1 nrad/s", new RotationalSpeed(1, RotationalSpeedUnit.NanoradianPerSecond).ToString());
                Assert.Equal("1 rad/s", new RotationalSpeed(1, RotationalSpeedUnit.RadianPerSecond).ToString());
                Assert.Equal("1 rpm", new RotationalSpeed(1, RotationalSpeedUnit.RevolutionPerMinute).ToString());
                Assert.Equal("1 r/s", new RotationalSpeed(1, RotationalSpeedUnit.RevolutionPerSecond).ToString());
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

            Assert.Equal("1 crad/s", new RotationalSpeed(1, RotationalSpeedUnit.CentiradianPerSecond).ToString(swedishCulture));
            Assert.Equal("1 drad/s", new RotationalSpeed(1, RotationalSpeedUnit.DeciradianPerSecond).ToString(swedishCulture));
            Assert.Equal("1 °/min", new RotationalSpeed(1, RotationalSpeedUnit.DegreePerMinute).ToString(swedishCulture));
            Assert.Equal("1 °/s", new RotationalSpeed(1, RotationalSpeedUnit.DegreePerSecond).ToString(swedishCulture));
            Assert.Equal("1 µ°/s", new RotationalSpeed(1, RotationalSpeedUnit.MicrodegreePerSecond).ToString(swedishCulture));
            Assert.Equal("1 µrad/s", new RotationalSpeed(1, RotationalSpeedUnit.MicroradianPerSecond).ToString(swedishCulture));
            Assert.Equal("1 m°/s", new RotationalSpeed(1, RotationalSpeedUnit.MillidegreePerSecond).ToString(swedishCulture));
            Assert.Equal("1 mrad/s", new RotationalSpeed(1, RotationalSpeedUnit.MilliradianPerSecond).ToString(swedishCulture));
            Assert.Equal("1 n°/s", new RotationalSpeed(1, RotationalSpeedUnit.NanodegreePerSecond).ToString(swedishCulture));
            Assert.Equal("1 nrad/s", new RotationalSpeed(1, RotationalSpeedUnit.NanoradianPerSecond).ToString(swedishCulture));
            Assert.Equal("1 rad/s", new RotationalSpeed(1, RotationalSpeedUnit.RadianPerSecond).ToString(swedishCulture));
            Assert.Equal("1 rpm", new RotationalSpeed(1, RotationalSpeedUnit.RevolutionPerMinute).ToString(swedishCulture));
            Assert.Equal("1 r/s", new RotationalSpeed(1, RotationalSpeedUnit.RevolutionPerSecond).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 rad/s", new RotationalSpeed(0.123456, RotationalSpeedUnit.RadianPerSecond).ToString("s1"));
                Assert.Equal("0.12 rad/s", new RotationalSpeed(0.123456, RotationalSpeedUnit.RadianPerSecond).ToString("s2"));
                Assert.Equal("0.123 rad/s", new RotationalSpeed(0.123456, RotationalSpeedUnit.RadianPerSecond).ToString("s3"));
                Assert.Equal("0.1235 rad/s", new RotationalSpeed(0.123456, RotationalSpeedUnit.RadianPerSecond).ToString("s4"));
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
            Assert.Equal("0.1 rad/s", new RotationalSpeed(0.123456, RotationalSpeedUnit.RadianPerSecond).ToString("s1", culture));
            Assert.Equal("0.12 rad/s", new RotationalSpeed(0.123456, RotationalSpeedUnit.RadianPerSecond).ToString("s2", culture));
            Assert.Equal("0.123 rad/s", new RotationalSpeed(0.123456, RotationalSpeedUnit.RadianPerSecond).ToString("s3", culture));
            Assert.Equal("0.1235 rad/s", new RotationalSpeed(0.123456, RotationalSpeedUnit.RadianPerSecond).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
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
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(RotationalSpeed)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(RotationalSpeedUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Equal(RotationalSpeed.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Equal(RotationalSpeed.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(1.0);
            Assert.Equal(new {RotationalSpeed.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = RotationalSpeed.FromRadiansPerSecond(value);
            Assert.Equal(RotationalSpeed.FromRadiansPerSecond(-value), -quantity);
        }
    }
}
