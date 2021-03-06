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

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToElectricResistivity
{
    public static class NumberToElectricResistivityExtensions
    {
        #region MicroohmMeter

        /// <inheritdoc cref="ElectricResistivity.FromMicroohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity MicroohmMeters(this int value) => ElectricResistivity.FromMicroohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromMicroohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity? MicroohmMeters(this int? value) => ElectricResistivity.FromMicroohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromMicroohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity MicroohmMeters(this long value) => ElectricResistivity.FromMicroohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromMicroohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity? MicroohmMeters(this long? value) => ElectricResistivity.FromMicroohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromMicroohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity MicroohmMeters(this double value) => ElectricResistivity.FromMicroohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromMicroohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity? MicroohmMeters(this double? value) => ElectricResistivity.FromMicroohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromMicroohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity MicroohmMeters(this float value) => ElectricResistivity.FromMicroohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromMicroohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity? MicroohmMeters(this float? value) => ElectricResistivity.FromMicroohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromMicroohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity MicroohmMeters(this decimal value) => ElectricResistivity.FromMicroohmMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistivity.FromMicroohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity? MicroohmMeters(this decimal? value) => ElectricResistivity.FromMicroohmMeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MilliohmMeter

        /// <inheritdoc cref="ElectricResistivity.FromMilliohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity MilliohmMeters(this int value) => ElectricResistivity.FromMilliohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromMilliohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity? MilliohmMeters(this int? value) => ElectricResistivity.FromMilliohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromMilliohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity MilliohmMeters(this long value) => ElectricResistivity.FromMilliohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromMilliohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity? MilliohmMeters(this long? value) => ElectricResistivity.FromMilliohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromMilliohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity MilliohmMeters(this double value) => ElectricResistivity.FromMilliohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromMilliohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity? MilliohmMeters(this double? value) => ElectricResistivity.FromMilliohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromMilliohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity MilliohmMeters(this float value) => ElectricResistivity.FromMilliohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromMilliohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity? MilliohmMeters(this float? value) => ElectricResistivity.FromMilliohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromMilliohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity MilliohmMeters(this decimal value) => ElectricResistivity.FromMilliohmMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistivity.FromMilliohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity? MilliohmMeters(this decimal? value) => ElectricResistivity.FromMilliohmMeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NanoohmMeter

        /// <inheritdoc cref="ElectricResistivity.FromNanoohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity NanoohmMeters(this int value) => ElectricResistivity.FromNanoohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromNanoohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity? NanoohmMeters(this int? value) => ElectricResistivity.FromNanoohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromNanoohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity NanoohmMeters(this long value) => ElectricResistivity.FromNanoohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromNanoohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity? NanoohmMeters(this long? value) => ElectricResistivity.FromNanoohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromNanoohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity NanoohmMeters(this double value) => ElectricResistivity.FromNanoohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromNanoohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity? NanoohmMeters(this double? value) => ElectricResistivity.FromNanoohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromNanoohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity NanoohmMeters(this float value) => ElectricResistivity.FromNanoohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromNanoohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity? NanoohmMeters(this float? value) => ElectricResistivity.FromNanoohmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromNanoohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity NanoohmMeters(this decimal value) => ElectricResistivity.FromNanoohmMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistivity.FromNanoohmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity? NanoohmMeters(this decimal? value) => ElectricResistivity.FromNanoohmMeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region OhmMeter

        /// <inheritdoc cref="ElectricResistivity.FromOhmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity OhmMeters(this int value) => ElectricResistivity.FromOhmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromOhmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity? OhmMeters(this int? value) => ElectricResistivity.FromOhmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromOhmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity OhmMeters(this long value) => ElectricResistivity.FromOhmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromOhmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity? OhmMeters(this long? value) => ElectricResistivity.FromOhmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromOhmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity OhmMeters(this double value) => ElectricResistivity.FromOhmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromOhmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity? OhmMeters(this double? value) => ElectricResistivity.FromOhmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromOhmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity OhmMeters(this float value) => ElectricResistivity.FromOhmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromOhmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity? OhmMeters(this float? value) => ElectricResistivity.FromOhmMeters(value);

        /// <inheritdoc cref="ElectricResistivity.FromOhmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity OhmMeters(this decimal value) => ElectricResistivity.FromOhmMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistivity.FromOhmMeters(UnitsNet.QuantityValue)" />
        public static ElectricResistivity? OhmMeters(this decimal? value) => ElectricResistivity.FromOhmMeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
