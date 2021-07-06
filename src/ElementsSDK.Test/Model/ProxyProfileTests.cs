/*
 * ELEMENTS API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ElementsSDK.Api;
using ElementsSDK.Model;
using ElementsSDK.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace ElementsSDK.Test.Model
{
    /// <summary>
    ///  Class for testing ProxyProfile
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ProxyProfileTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ProxyProfile
        //private ProxyProfile instance;

        public ProxyProfileTests()
        {
            // TODO uncomment below to create an instance of ProxyProfile
            //instance = new ProxyProfile();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProxyProfile
        /// </summary>
        [Fact]
        public void ProxyProfileInstanceTest()
        {
            // TODO uncomment below to test "IsType" ProxyProfile
            //Assert.IsType<ProxyProfile>(instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'ProxyGenerator'
        /// </summary>
        [Fact]
        public void ProxyGeneratorTest()
        {
            // TODO unit test for the property 'ProxyGenerator'
        }
        /// <summary>
        /// Test the property 'Resolution'
        /// </summary>
        [Fact]
        public void ResolutionTest()
        {
            // TODO unit test for the property 'Resolution'
        }
        /// <summary>
        /// Test the property 'RateControl'
        /// </summary>
        [Fact]
        public void RateControlTest()
        {
            // TODO unit test for the property 'RateControl'
        }
        /// <summary>
        /// Test the property 'Crf'
        /// </summary>
        [Fact]
        public void CrfTest()
        {
            // TODO unit test for the property 'Crf'
        }
        /// <summary>
        /// Test the property 'Bitrate'
        /// </summary>
        [Fact]
        public void BitrateTest()
        {
            // TODO unit test for the property 'Bitrate'
        }
        /// <summary>
        /// Test the property 'AudioBitrate'
        /// </summary>
        [Fact]
        public void AudioBitrateTest()
        {
            // TODO unit test for the property 'AudioBitrate'
        }
        /// <summary>
        /// Test the property 'VariantsLimit'
        /// </summary>
        [Fact]
        public void VariantsLimitTest()
        {
            // TODO unit test for the property 'VariantsLimit'
        }
        /// <summary>
        /// Test the property 'EnableRealtimeRead'
        /// </summary>
        [Fact]
        public void EnableRealtimeReadTest()
        {
            // TODO unit test for the property 'EnableRealtimeRead'
        }
        /// <summary>
        /// Test the property 'EnableDenseFilmstrip'
        /// </summary>
        [Fact]
        public void EnableDenseFilmstripTest()
        {
            // TODO unit test for the property 'EnableDenseFilmstrip'
        }
        /// <summary>
        /// Test the property 'EnableWatermark'
        /// </summary>
        [Fact]
        public void EnableWatermarkTest()
        {
            // TODO unit test for the property 'EnableWatermark'
        }
        /// <summary>
        /// Test the property 'WatermarkImage'
        /// </summary>
        [Fact]
        public void WatermarkImageTest()
        {
            // TODO unit test for the property 'WatermarkImage'
        }
        /// <summary>
        /// Test the property 'WatermarkPosition'
        /// </summary>
        [Fact]
        public void WatermarkPositionTest()
        {
            // TODO unit test for the property 'WatermarkPosition'
        }
        /// <summary>
        /// Test the property 'WatermarkOpacity'
        /// </summary>
        [Fact]
        public void WatermarkOpacityTest()
        {
            // TODO unit test for the property 'WatermarkOpacity'
        }
        /// <summary>
        /// Test the property 'WatermarkSize'
        /// </summary>
        [Fact]
        public void WatermarkSizeTest()
        {
            // TODO unit test for the property 'WatermarkSize'
        }
        /// <summary>
        /// Test the property 'EnableTimecode'
        /// </summary>
        [Fact]
        public void EnableTimecodeTest()
        {
            // TODO unit test for the property 'EnableTimecode'
        }
        /// <summary>
        /// Test the property 'TimecodePosition'
        /// </summary>
        [Fact]
        public void TimecodePositionTest()
        {
            // TODO unit test for the property 'TimecodePosition'
        }
        /// <summary>
        /// Test the property 'TimecodeOpacity'
        /// </summary>
        [Fact]
        public void TimecodeOpacityTest()
        {
            // TODO unit test for the property 'TimecodeOpacity'
        }
        /// <summary>
        /// Test the property 'TimecodeSize'
        /// </summary>
        [Fact]
        public void TimecodeSizeTest()
        {
            // TODO unit test for the property 'TimecodeSize'
        }
        /// <summary>
        /// Test the property 'Lut'
        /// </summary>
        [Fact]
        public void LutTest()
        {
            // TODO unit test for the property 'Lut'
        }
        /// <summary>
        /// Test the property 'HotfolderCopyTo'
        /// </summary>
        [Fact]
        public void HotfolderCopyToTest()
        {
            // TODO unit test for the property 'HotfolderCopyTo'
        }
        /// <summary>
        /// Test the property 'HotfolderReadFrom'
        /// </summary>
        [Fact]
        public void HotfolderReadFromTest()
        {
            // TODO unit test for the property 'HotfolderReadFrom'
        }
        /// <summary>
        /// Test the property 'HotfolderQueueTimeout'
        /// </summary>
        [Fact]
        public void HotfolderQueueTimeoutTest()
        {
            // TODO unit test for the property 'HotfolderQueueTimeout'
        }
        /// <summary>
        /// Test the property 'HotfolderEncodeTimeout'
        /// </summary>
        [Fact]
        public void HotfolderEncodeTimeoutTest()
        {
            // TODO unit test for the property 'HotfolderEncodeTimeout'
        }
        /// <summary>
        /// Test the property 'VantageWorkflowId'
        /// </summary>
        [Fact]
        public void VantageWorkflowIdTest()
        {
            // TODO unit test for the property 'VantageWorkflowId'
        }
        /// <summary>
        /// Test the property 'ExternalTranscoderStagingPath'
        /// </summary>
        [Fact]
        public void ExternalTranscoderStagingPathTest()
        {
            // TODO unit test for the property 'ExternalTranscoderStagingPath'
        }
        /// <summary>
        /// Test the property 'ExternalTranscoder'
        /// </summary>
        [Fact]
        public void ExternalTranscoderTest()
        {
            // TODO unit test for the property 'ExternalTranscoder'
        }

    }

}