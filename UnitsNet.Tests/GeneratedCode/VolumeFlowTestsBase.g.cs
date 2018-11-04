﻿//------------------------------------------------------------------------------
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
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of VolumeFlow.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class VolumeFlowTestsBase
    {
        protected abstract double CentilitersPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double CubicDecimetersPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double CubicFeetPerHourInOneCubicMeterPerSecond { get; }
        protected abstract double CubicFeetPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double CubicFeetPerSecondInOneCubicMeterPerSecond { get; }
        protected abstract double CubicMetersPerHourInOneCubicMeterPerSecond { get; }
        protected abstract double CubicMetersPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double CubicMetersPerSecondInOneCubicMeterPerSecond { get; }
        protected abstract double CubicYardsPerHourInOneCubicMeterPerSecond { get; }
        protected abstract double CubicYardsPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double CubicYardsPerSecondInOneCubicMeterPerSecond { get; }
        protected abstract double DecilitersPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double KilolitersPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double LitersPerHourInOneCubicMeterPerSecond { get; }
        protected abstract double LitersPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double LitersPerSecondInOneCubicMeterPerSecond { get; }
        protected abstract double MicrolitersPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double MillilitersPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double MillionUsGallonsPerDayInOneCubicMeterPerSecond { get; }
        protected abstract double NanolitersPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double OilBarrelsPerDayInOneCubicMeterPerSecond { get; }
        protected abstract double OilBarrelsPerHourInOneCubicMeterPerSecond { get; }
        protected abstract double OilBarrelsPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double UsGallonsPerHourInOneCubicMeterPerSecond { get; }
        protected abstract double UsGallonsPerMinuteInOneCubicMeterPerSecond { get; }
        protected abstract double UsGallonsPerSecondInOneCubicMeterPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentilitersPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double CubicDecimetersPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double CubicFeetPerHourTolerance { get { return 1e-5; } }
        protected virtual double CubicFeetPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double CubicFeetPerSecondTolerance { get { return 1e-5; } }
        protected virtual double CubicMetersPerHourTolerance { get { return 1e-5; } }
        protected virtual double CubicMetersPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double CubicMetersPerSecondTolerance { get { return 1e-5; } }
        protected virtual double CubicYardsPerHourTolerance { get { return 1e-5; } }
        protected virtual double CubicYardsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double CubicYardsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DecilitersPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double KilolitersPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double LitersPerHourTolerance { get { return 1e-5; } }
        protected virtual double LitersPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double LitersPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MicrolitersPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double MillilitersPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double MillionUsGallonsPerDayTolerance { get { return 1e-5; } }
        protected virtual double NanolitersPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double OilBarrelsPerDayTolerance { get { return 1e-5; } }
        protected virtual double OilBarrelsPerHourTolerance { get { return 1e-5; } }
        protected virtual double OilBarrelsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double UsGallonsPerHourTolerance { get { return 1e-5; } }
        protected virtual double UsGallonsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double UsGallonsPerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void CubicMeterPerSecondToVolumeFlowUnits()
        {
            VolumeFlow cubicmeterpersecond = VolumeFlow.FromCubicMetersPerSecond(1);
            AssertEx.EqualTolerance(CentilitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.CentilitersPerMinute, CentilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(CubicDecimetersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.CubicDecimetersPerMinute, CubicDecimetersPerMinuteTolerance);
            AssertEx.EqualTolerance(CubicFeetPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.CubicFeetPerHour, CubicFeetPerHourTolerance);
            AssertEx.EqualTolerance(CubicFeetPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.CubicFeetPerMinute, CubicFeetPerMinuteTolerance);
            AssertEx.EqualTolerance(CubicFeetPerSecondInOneCubicMeterPerSecond, cubicmeterpersecond.CubicFeetPerSecond, CubicFeetPerSecondTolerance);
            AssertEx.EqualTolerance(CubicMetersPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.CubicMetersPerHour, CubicMetersPerHourTolerance);
            AssertEx.EqualTolerance(CubicMetersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.CubicMetersPerMinute, CubicMetersPerMinuteTolerance);
            AssertEx.EqualTolerance(CubicMetersPerSecondInOneCubicMeterPerSecond, cubicmeterpersecond.CubicMetersPerSecond, CubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(CubicYardsPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.CubicYardsPerHour, CubicYardsPerHourTolerance);
            AssertEx.EqualTolerance(CubicYardsPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.CubicYardsPerMinute, CubicYardsPerMinuteTolerance);
            AssertEx.EqualTolerance(CubicYardsPerSecondInOneCubicMeterPerSecond, cubicmeterpersecond.CubicYardsPerSecond, CubicYardsPerSecondTolerance);
            AssertEx.EqualTolerance(DecilitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.DecilitersPerMinute, DecilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(KilolitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.KilolitersPerMinute, KilolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(LitersPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.LitersPerHour, LitersPerHourTolerance);
            AssertEx.EqualTolerance(LitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.LitersPerMinute, LitersPerMinuteTolerance);
            AssertEx.EqualTolerance(LitersPerSecondInOneCubicMeterPerSecond, cubicmeterpersecond.LitersPerSecond, LitersPerSecondTolerance);
            AssertEx.EqualTolerance(MicrolitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.MicrolitersPerMinute, MicrolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(MillilitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.MillilitersPerMinute, MillilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(MillionUsGallonsPerDayInOneCubicMeterPerSecond, cubicmeterpersecond.MillionUsGallonsPerDay, MillionUsGallonsPerDayTolerance);
            AssertEx.EqualTolerance(NanolitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.NanolitersPerMinute, NanolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(OilBarrelsPerDayInOneCubicMeterPerSecond, cubicmeterpersecond.OilBarrelsPerDay, OilBarrelsPerDayTolerance);
            AssertEx.EqualTolerance(OilBarrelsPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.OilBarrelsPerHour, OilBarrelsPerHourTolerance);
            AssertEx.EqualTolerance(OilBarrelsPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.OilBarrelsPerMinute, OilBarrelsPerMinuteTolerance);
            AssertEx.EqualTolerance(UsGallonsPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.UsGallonsPerHour, UsGallonsPerHourTolerance);
            AssertEx.EqualTolerance(UsGallonsPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.UsGallonsPerMinute, UsGallonsPerMinuteTolerance);
            AssertEx.EqualTolerance(UsGallonsPerSecondInOneCubicMeterPerSecond, cubicmeterpersecond.UsGallonsPerSecond, UsGallonsPerSecondTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.CentilitersPerMinute).CentilitersPerMinute, CentilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.CubicDecimeterPerMinute).CubicDecimetersPerMinute, CubicDecimetersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.CubicFootPerHour).CubicFeetPerHour, CubicFeetPerHourTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.CubicFootPerMinute).CubicFeetPerMinute, CubicFeetPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.CubicFootPerSecond).CubicFeetPerSecond, CubicFeetPerSecondTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.CubicMeterPerHour).CubicMetersPerHour, CubicMetersPerHourTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.CubicMeterPerMinute).CubicMetersPerMinute, CubicMetersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.CubicMeterPerSecond).CubicMetersPerSecond, CubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.CubicYardPerHour).CubicYardsPerHour, CubicYardsPerHourTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.CubicYardPerMinute).CubicYardsPerMinute, CubicYardsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.CubicYardPerSecond).CubicYardsPerSecond, CubicYardsPerSecondTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.DecilitersPerMinute).DecilitersPerMinute, DecilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.KilolitersPerMinute).KilolitersPerMinute, KilolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.LitersPerHour).LitersPerHour, LitersPerHourTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.LitersPerMinute).LitersPerMinute, LitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.LitersPerSecond).LitersPerSecond, LitersPerSecondTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.MicrolitersPerMinute).MicrolitersPerMinute, MicrolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.MillilitersPerMinute).MillilitersPerMinute, MillilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.MillionUsGallonsPerDay).MillionUsGallonsPerDay, MillionUsGallonsPerDayTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.NanolitersPerMinute).NanolitersPerMinute, NanolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.OilBarrelsPerDay).OilBarrelsPerDay, OilBarrelsPerDayTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.OilBarrelsPerHour).OilBarrelsPerHour, OilBarrelsPerHourTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.OilBarrelsPerMinute).OilBarrelsPerMinute, OilBarrelsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.UsGallonsPerHour).UsGallonsPerHour, UsGallonsPerHourTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.UsGallonsPerMinute).UsGallonsPerMinute, UsGallonsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.From(1, VolumeFlowUnit.UsGallonsPerSecond).UsGallonsPerSecond, UsGallonsPerSecondTolerance);
        }

        [Fact]
        public void As()
        {
            var cubicmeterpersecond = VolumeFlow.FromCubicMetersPerSecond(1);
            AssertEx.EqualTolerance(CentilitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.CentilitersPerMinute), CentilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(CubicDecimetersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.CubicDecimeterPerMinute), CubicDecimetersPerMinuteTolerance);
            AssertEx.EqualTolerance(CubicFeetPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.CubicFootPerHour), CubicFeetPerHourTolerance);
            AssertEx.EqualTolerance(CubicFeetPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.CubicFootPerMinute), CubicFeetPerMinuteTolerance);
            AssertEx.EqualTolerance(CubicFeetPerSecondInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.CubicFootPerSecond), CubicFeetPerSecondTolerance);
            AssertEx.EqualTolerance(CubicMetersPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.CubicMeterPerHour), CubicMetersPerHourTolerance);
            AssertEx.EqualTolerance(CubicMetersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.CubicMeterPerMinute), CubicMetersPerMinuteTolerance);
            AssertEx.EqualTolerance(CubicMetersPerSecondInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.CubicMeterPerSecond), CubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(CubicYardsPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.CubicYardPerHour), CubicYardsPerHourTolerance);
            AssertEx.EqualTolerance(CubicYardsPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.CubicYardPerMinute), CubicYardsPerMinuteTolerance);
            AssertEx.EqualTolerance(CubicYardsPerSecondInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.CubicYardPerSecond), CubicYardsPerSecondTolerance);
            AssertEx.EqualTolerance(DecilitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.DecilitersPerMinute), DecilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(KilolitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.KilolitersPerMinute), KilolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(LitersPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.LitersPerHour), LitersPerHourTolerance);
            AssertEx.EqualTolerance(LitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.LitersPerMinute), LitersPerMinuteTolerance);
            AssertEx.EqualTolerance(LitersPerSecondInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.LitersPerSecond), LitersPerSecondTolerance);
            AssertEx.EqualTolerance(MicrolitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.MicrolitersPerMinute), MicrolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(MillilitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.MillilitersPerMinute), MillilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(MillionUsGallonsPerDayInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.MillionUsGallonsPerDay), MillionUsGallonsPerDayTolerance);
            AssertEx.EqualTolerance(NanolitersPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.NanolitersPerMinute), NanolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(OilBarrelsPerDayInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.OilBarrelsPerDay), OilBarrelsPerDayTolerance);
            AssertEx.EqualTolerance(OilBarrelsPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.OilBarrelsPerHour), OilBarrelsPerHourTolerance);
            AssertEx.EqualTolerance(OilBarrelsPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.OilBarrelsPerMinute), OilBarrelsPerMinuteTolerance);
            AssertEx.EqualTolerance(UsGallonsPerHourInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.UsGallonsPerHour), UsGallonsPerHourTolerance);
            AssertEx.EqualTolerance(UsGallonsPerMinuteInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.UsGallonsPerMinute), UsGallonsPerMinuteTolerance);
            AssertEx.EqualTolerance(UsGallonsPerSecondInOneCubicMeterPerSecond, cubicmeterpersecond.As(VolumeFlowUnit.UsGallonsPerSecond), UsGallonsPerSecondTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var cubicmeterpersecond = VolumeFlow.FromCubicMetersPerSecond(1);

            var centilitersperminuteQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.CentilitersPerMinute);
            AssertEx.EqualTolerance(CentilitersPerMinuteInOneCubicMeterPerSecond, (double)centilitersperminuteQuantity.Value, CentilitersPerMinuteTolerance);
            Assert.Equal(VolumeFlowUnit.CentilitersPerMinute, centilitersperminuteQuantity.Unit);

            var cubicdecimeterperminuteQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.CubicDecimeterPerMinute);
            AssertEx.EqualTolerance(CubicDecimetersPerMinuteInOneCubicMeterPerSecond, (double)cubicdecimeterperminuteQuantity.Value, CubicDecimetersPerMinuteTolerance);
            Assert.Equal(VolumeFlowUnit.CubicDecimeterPerMinute, cubicdecimeterperminuteQuantity.Unit);

            var cubicfootperhourQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.CubicFootPerHour);
            AssertEx.EqualTolerance(CubicFeetPerHourInOneCubicMeterPerSecond, (double)cubicfootperhourQuantity.Value, CubicFeetPerHourTolerance);
            Assert.Equal(VolumeFlowUnit.CubicFootPerHour, cubicfootperhourQuantity.Unit);

            var cubicfootperminuteQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.CubicFootPerMinute);
            AssertEx.EqualTolerance(CubicFeetPerMinuteInOneCubicMeterPerSecond, (double)cubicfootperminuteQuantity.Value, CubicFeetPerMinuteTolerance);
            Assert.Equal(VolumeFlowUnit.CubicFootPerMinute, cubicfootperminuteQuantity.Unit);

            var cubicfootpersecondQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.CubicFootPerSecond);
            AssertEx.EqualTolerance(CubicFeetPerSecondInOneCubicMeterPerSecond, (double)cubicfootpersecondQuantity.Value, CubicFeetPerSecondTolerance);
            Assert.Equal(VolumeFlowUnit.CubicFootPerSecond, cubicfootpersecondQuantity.Unit);

            var cubicmeterperhourQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.CubicMeterPerHour);
            AssertEx.EqualTolerance(CubicMetersPerHourInOneCubicMeterPerSecond, (double)cubicmeterperhourQuantity.Value, CubicMetersPerHourTolerance);
            Assert.Equal(VolumeFlowUnit.CubicMeterPerHour, cubicmeterperhourQuantity.Unit);

            var cubicmeterperminuteQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.CubicMeterPerMinute);
            AssertEx.EqualTolerance(CubicMetersPerMinuteInOneCubicMeterPerSecond, (double)cubicmeterperminuteQuantity.Value, CubicMetersPerMinuteTolerance);
            Assert.Equal(VolumeFlowUnit.CubicMeterPerMinute, cubicmeterperminuteQuantity.Unit);

            var cubicmeterpersecondQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.CubicMeterPerSecond);
            AssertEx.EqualTolerance(CubicMetersPerSecondInOneCubicMeterPerSecond, (double)cubicmeterpersecondQuantity.Value, CubicMetersPerSecondTolerance);
            Assert.Equal(VolumeFlowUnit.CubicMeterPerSecond, cubicmeterpersecondQuantity.Unit);

            var cubicyardperhourQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.CubicYardPerHour);
            AssertEx.EqualTolerance(CubicYardsPerHourInOneCubicMeterPerSecond, (double)cubicyardperhourQuantity.Value, CubicYardsPerHourTolerance);
            Assert.Equal(VolumeFlowUnit.CubicYardPerHour, cubicyardperhourQuantity.Unit);

            var cubicyardperminuteQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.CubicYardPerMinute);
            AssertEx.EqualTolerance(CubicYardsPerMinuteInOneCubicMeterPerSecond, (double)cubicyardperminuteQuantity.Value, CubicYardsPerMinuteTolerance);
            Assert.Equal(VolumeFlowUnit.CubicYardPerMinute, cubicyardperminuteQuantity.Unit);

            var cubicyardpersecondQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.CubicYardPerSecond);
            AssertEx.EqualTolerance(CubicYardsPerSecondInOneCubicMeterPerSecond, (double)cubicyardpersecondQuantity.Value, CubicYardsPerSecondTolerance);
            Assert.Equal(VolumeFlowUnit.CubicYardPerSecond, cubicyardpersecondQuantity.Unit);

            var decilitersperminuteQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.DecilitersPerMinute);
            AssertEx.EqualTolerance(DecilitersPerMinuteInOneCubicMeterPerSecond, (double)decilitersperminuteQuantity.Value, DecilitersPerMinuteTolerance);
            Assert.Equal(VolumeFlowUnit.DecilitersPerMinute, decilitersperminuteQuantity.Unit);

            var kilolitersperminuteQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.KilolitersPerMinute);
            AssertEx.EqualTolerance(KilolitersPerMinuteInOneCubicMeterPerSecond, (double)kilolitersperminuteQuantity.Value, KilolitersPerMinuteTolerance);
            Assert.Equal(VolumeFlowUnit.KilolitersPerMinute, kilolitersperminuteQuantity.Unit);

            var litersperhourQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.LitersPerHour);
            AssertEx.EqualTolerance(LitersPerHourInOneCubicMeterPerSecond, (double)litersperhourQuantity.Value, LitersPerHourTolerance);
            Assert.Equal(VolumeFlowUnit.LitersPerHour, litersperhourQuantity.Unit);

            var litersperminuteQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.LitersPerMinute);
            AssertEx.EqualTolerance(LitersPerMinuteInOneCubicMeterPerSecond, (double)litersperminuteQuantity.Value, LitersPerMinuteTolerance);
            Assert.Equal(VolumeFlowUnit.LitersPerMinute, litersperminuteQuantity.Unit);

            var literspersecondQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.LitersPerSecond);
            AssertEx.EqualTolerance(LitersPerSecondInOneCubicMeterPerSecond, (double)literspersecondQuantity.Value, LitersPerSecondTolerance);
            Assert.Equal(VolumeFlowUnit.LitersPerSecond, literspersecondQuantity.Unit);

            var microlitersperminuteQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.MicrolitersPerMinute);
            AssertEx.EqualTolerance(MicrolitersPerMinuteInOneCubicMeterPerSecond, (double)microlitersperminuteQuantity.Value, MicrolitersPerMinuteTolerance);
            Assert.Equal(VolumeFlowUnit.MicrolitersPerMinute, microlitersperminuteQuantity.Unit);

            var millilitersperminuteQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.MillilitersPerMinute);
            AssertEx.EqualTolerance(MillilitersPerMinuteInOneCubicMeterPerSecond, (double)millilitersperminuteQuantity.Value, MillilitersPerMinuteTolerance);
            Assert.Equal(VolumeFlowUnit.MillilitersPerMinute, millilitersperminuteQuantity.Unit);

            var millionusgallonsperdayQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.MillionUsGallonsPerDay);
            AssertEx.EqualTolerance(MillionUsGallonsPerDayInOneCubicMeterPerSecond, (double)millionusgallonsperdayQuantity.Value, MillionUsGallonsPerDayTolerance);
            Assert.Equal(VolumeFlowUnit.MillionUsGallonsPerDay, millionusgallonsperdayQuantity.Unit);

            var nanolitersperminuteQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.NanolitersPerMinute);
            AssertEx.EqualTolerance(NanolitersPerMinuteInOneCubicMeterPerSecond, (double)nanolitersperminuteQuantity.Value, NanolitersPerMinuteTolerance);
            Assert.Equal(VolumeFlowUnit.NanolitersPerMinute, nanolitersperminuteQuantity.Unit);

            var oilbarrelsperdayQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.OilBarrelsPerDay);
            AssertEx.EqualTolerance(OilBarrelsPerDayInOneCubicMeterPerSecond, (double)oilbarrelsperdayQuantity.Value, OilBarrelsPerDayTolerance);
            Assert.Equal(VolumeFlowUnit.OilBarrelsPerDay, oilbarrelsperdayQuantity.Unit);

            var oilbarrelsperhourQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.OilBarrelsPerHour);
            AssertEx.EqualTolerance(OilBarrelsPerHourInOneCubicMeterPerSecond, (double)oilbarrelsperhourQuantity.Value, OilBarrelsPerHourTolerance);
            Assert.Equal(VolumeFlowUnit.OilBarrelsPerHour, oilbarrelsperhourQuantity.Unit);

            var oilbarrelsperminuteQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.OilBarrelsPerMinute);
            AssertEx.EqualTolerance(OilBarrelsPerMinuteInOneCubicMeterPerSecond, (double)oilbarrelsperminuteQuantity.Value, OilBarrelsPerMinuteTolerance);
            Assert.Equal(VolumeFlowUnit.OilBarrelsPerMinute, oilbarrelsperminuteQuantity.Unit);

            var usgallonsperhourQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.UsGallonsPerHour);
            AssertEx.EqualTolerance(UsGallonsPerHourInOneCubicMeterPerSecond, (double)usgallonsperhourQuantity.Value, UsGallonsPerHourTolerance);
            Assert.Equal(VolumeFlowUnit.UsGallonsPerHour, usgallonsperhourQuantity.Unit);

            var usgallonsperminuteQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.UsGallonsPerMinute);
            AssertEx.EqualTolerance(UsGallonsPerMinuteInOneCubicMeterPerSecond, (double)usgallonsperminuteQuantity.Value, UsGallonsPerMinuteTolerance);
            Assert.Equal(VolumeFlowUnit.UsGallonsPerMinute, usgallonsperminuteQuantity.Unit);

            var usgallonspersecondQuantity = cubicmeterpersecond.ToUnit(VolumeFlowUnit.UsGallonsPerSecond);
            AssertEx.EqualTolerance(UsGallonsPerSecondInOneCubicMeterPerSecond, (double)usgallonspersecondQuantity.Value, UsGallonsPerSecondTolerance);
            Assert.Equal(VolumeFlowUnit.UsGallonsPerSecond, usgallonspersecondQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            VolumeFlow cubicmeterpersecond = VolumeFlow.FromCubicMetersPerSecond(1);
            AssertEx.EqualTolerance(1, VolumeFlow.FromCentilitersPerMinute(cubicmeterpersecond.CentilitersPerMinute).CubicMetersPerSecond, CentilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromCubicDecimetersPerMinute(cubicmeterpersecond.CubicDecimetersPerMinute).CubicMetersPerSecond, CubicDecimetersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromCubicFeetPerHour(cubicmeterpersecond.CubicFeetPerHour).CubicMetersPerSecond, CubicFeetPerHourTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromCubicFeetPerMinute(cubicmeterpersecond.CubicFeetPerMinute).CubicMetersPerSecond, CubicFeetPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromCubicFeetPerSecond(cubicmeterpersecond.CubicFeetPerSecond).CubicMetersPerSecond, CubicFeetPerSecondTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromCubicMetersPerHour(cubicmeterpersecond.CubicMetersPerHour).CubicMetersPerSecond, CubicMetersPerHourTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromCubicMetersPerMinute(cubicmeterpersecond.CubicMetersPerMinute).CubicMetersPerSecond, CubicMetersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromCubicMetersPerSecond(cubicmeterpersecond.CubicMetersPerSecond).CubicMetersPerSecond, CubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromCubicYardsPerHour(cubicmeterpersecond.CubicYardsPerHour).CubicMetersPerSecond, CubicYardsPerHourTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromCubicYardsPerMinute(cubicmeterpersecond.CubicYardsPerMinute).CubicMetersPerSecond, CubicYardsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromCubicYardsPerSecond(cubicmeterpersecond.CubicYardsPerSecond).CubicMetersPerSecond, CubicYardsPerSecondTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromDecilitersPerMinute(cubicmeterpersecond.DecilitersPerMinute).CubicMetersPerSecond, DecilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromKilolitersPerMinute(cubicmeterpersecond.KilolitersPerMinute).CubicMetersPerSecond, KilolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromLitersPerHour(cubicmeterpersecond.LitersPerHour).CubicMetersPerSecond, LitersPerHourTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromLitersPerMinute(cubicmeterpersecond.LitersPerMinute).CubicMetersPerSecond, LitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromLitersPerSecond(cubicmeterpersecond.LitersPerSecond).CubicMetersPerSecond, LitersPerSecondTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromMicrolitersPerMinute(cubicmeterpersecond.MicrolitersPerMinute).CubicMetersPerSecond, MicrolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromMillilitersPerMinute(cubicmeterpersecond.MillilitersPerMinute).CubicMetersPerSecond, MillilitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromMillionUsGallonsPerDay(cubicmeterpersecond.MillionUsGallonsPerDay).CubicMetersPerSecond, MillionUsGallonsPerDayTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromNanolitersPerMinute(cubicmeterpersecond.NanolitersPerMinute).CubicMetersPerSecond, NanolitersPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromOilBarrelsPerDay(cubicmeterpersecond.OilBarrelsPerDay).CubicMetersPerSecond, OilBarrelsPerDayTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromOilBarrelsPerHour(cubicmeterpersecond.OilBarrelsPerHour).CubicMetersPerSecond, OilBarrelsPerHourTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromOilBarrelsPerMinute(cubicmeterpersecond.OilBarrelsPerMinute).CubicMetersPerSecond, OilBarrelsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromUsGallonsPerHour(cubicmeterpersecond.UsGallonsPerHour).CubicMetersPerSecond, UsGallonsPerHourTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromUsGallonsPerMinute(cubicmeterpersecond.UsGallonsPerMinute).CubicMetersPerSecond, UsGallonsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, VolumeFlow.FromUsGallonsPerSecond(cubicmeterpersecond.UsGallonsPerSecond).CubicMetersPerSecond, UsGallonsPerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            VolumeFlow v = VolumeFlow.FromCubicMetersPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.CubicMetersPerSecond, CubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (VolumeFlow.FromCubicMetersPerSecond(3)-v).CubicMetersPerSecond, CubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).CubicMetersPerSecond, CubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).CubicMetersPerSecond, CubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).CubicMetersPerSecond, CubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (VolumeFlow.FromCubicMetersPerSecond(10)/5).CubicMetersPerSecond, CubicMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, VolumeFlow.FromCubicMetersPerSecond(10)/VolumeFlow.FromCubicMetersPerSecond(5), CubicMetersPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            VolumeFlow oneCubicMeterPerSecond = VolumeFlow.FromCubicMetersPerSecond(1);
            VolumeFlow twoCubicMetersPerSecond = VolumeFlow.FromCubicMetersPerSecond(2);

            Assert.True(oneCubicMeterPerSecond < twoCubicMetersPerSecond);
            Assert.True(oneCubicMeterPerSecond <= twoCubicMetersPerSecond);
            Assert.True(twoCubicMetersPerSecond > oneCubicMeterPerSecond);
            Assert.True(twoCubicMetersPerSecond >= oneCubicMeterPerSecond);

            Assert.False(oneCubicMeterPerSecond > twoCubicMetersPerSecond);
            Assert.False(oneCubicMeterPerSecond >= twoCubicMetersPerSecond);
            Assert.False(twoCubicMetersPerSecond < oneCubicMeterPerSecond);
            Assert.False(twoCubicMetersPerSecond <= oneCubicMeterPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            VolumeFlow cubicmeterpersecond = VolumeFlow.FromCubicMetersPerSecond(1);
            Assert.Equal(0, cubicmeterpersecond.CompareTo(cubicmeterpersecond));
            Assert.True(cubicmeterpersecond.CompareTo(VolumeFlow.Zero) > 0);
            Assert.True(VolumeFlow.Zero.CompareTo(cubicmeterpersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            VolumeFlow cubicmeterpersecond = VolumeFlow.FromCubicMetersPerSecond(1);
            Assert.Throws<ArgumentException>(() => cubicmeterpersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            VolumeFlow cubicmeterpersecond = VolumeFlow.FromCubicMetersPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => cubicmeterpersecond.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            VolumeFlow a = VolumeFlow.FromCubicMetersPerSecond(1);
            VolumeFlow b = VolumeFlow.FromCubicMetersPerSecond(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            VolumeFlow v = VolumeFlow.FromCubicMetersPerSecond(1);
            Assert.True(v.Equals(VolumeFlow.FromCubicMetersPerSecond(1), VolumeFlow.FromCubicMetersPerSecond(CubicMetersPerSecondTolerance)));
            Assert.False(v.Equals(VolumeFlow.Zero, VolumeFlow.FromCubicMetersPerSecond(CubicMetersPerSecondTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            VolumeFlow cubicmeterpersecond = VolumeFlow.FromCubicMetersPerSecond(1);
            Assert.False(cubicmeterpersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            VolumeFlow cubicmeterpersecond = VolumeFlow.FromCubicMetersPerSecond(1);
            Assert.False(cubicmeterpersecond.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(VolumeFlowUnit.Undefined, VolumeFlow.Units);
        }

    }
}