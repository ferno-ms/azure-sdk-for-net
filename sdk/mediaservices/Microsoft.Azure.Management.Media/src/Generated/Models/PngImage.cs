// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes the properties for producing a series of PNG images from the
    /// input video.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.PngImage")]
    public partial class PngImage : Image
    {
        /// <summary>
        /// Initializes a new instance of the PngImage class.
        /// </summary>
        public PngImage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PngImage class.
        /// </summary>
        /// <param name="start">The position in the input video from where to
        /// start generating thumbnails. The value can be in absolute timestamp
        /// (ISO 8601, e.g: PT05S), or a frame count (For example, 10 for the
        /// 10th frame), or a relative value (For example, 1%). Also supports a
        /// macro {Best}, which tells the encoder to select the best thumbnail
        /// from the first few seconds of the video.</param>
        /// <param name="label">An optional label for the codec. The label can
        /// be used to control muxing behavior.</param>
        /// <param name="keyFrameInterval">The distance between two key frames,
        /// thereby defining a group of pictures (GOP). The value should be a
        /// non-zero integer in the range [1, 30] seconds, specified in ISO
        /// 8601 format. The default is 2 seconds (PT2S).</param>
        /// <param name="stretchMode">The resizing mode - how the input video
        /// will be resized to fit the desired output resolution(s). Default is
        /// AutoSize. Possible values include: 'None', 'AutoSize',
        /// 'AutoFit'</param>
        /// <param name="step">The intervals at which thumbnails are generated.
        /// The value can be in absolute timestamp (ISO 8601, e.g: PT05S for
        /// one image every 5 seconds), or a frame count (For example, 30 for
        /// every 30 frames), or a relative value (For example, 1%).</param>
        /// <param name="range">The position in the input video at which to
        /// stop generating thumbnails. The value can be in absolute timestamp
        /// (ISO 8601, e.g: PT5M30S to stop at 5 minutes and 30 seconds), or a
        /// frame count (For example, 300 to stop at the 300th frame), or a
        /// relative value (For example, 100%).</param>
        /// <param name="layers">A collection of output PNG image layers to be
        /// produced by the encoder.</param>
        public PngImage(string start, string label = default(string), System.TimeSpan? keyFrameInterval = default(System.TimeSpan?), StretchMode? stretchMode = default(StretchMode?), string step = default(string), string range = default(string), IList<PngLayer> layers = default(IList<PngLayer>))
            : base(start, label, keyFrameInterval, stretchMode, step, range)
        {
            Layers = layers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a collection of output PNG image layers to be produced
        /// by the encoder.
        /// </summary>
        [JsonProperty(PropertyName = "layers")]
        public IList<PngLayer> Layers { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}