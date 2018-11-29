/* 
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * Contact: anoordover@hetcak.nl
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing RelatieApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RelatieApiTests
    {
        private RelatieApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RelatieApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RelatieApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RelatieApi
            //Assert.IsInstanceOfType(typeof(RelatieApi), instance, "instance is a RelatieApi");
        }

        
        /// <summary>
        /// Test GetRelatiesByPersoonId
        /// </summary>
        [Test]
        public void GetRelatiesByPersoonIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? persoonId = null;
            //DateTime? opdrachtdatum = null;
            //string xCakOrigin = null;
            //DateTime? xCakCreationdate = null;
            //string xCakMessageid = null;
            //string xCakRequestid = null;
            //string xCakBusinessobject = null;
            //string xCakBusinessid = null;
            //string xCakUserid = null;
            //string xCakCallbackurl = null;
            //string xCakPreviousrequestid = null;
            //string xCakAuthorization = null;
            //string xCakInformation = null;
            //var response = instance.GetRelatiesByPersoonId(persoonId, opdrachtdatum, xCakOrigin, xCakCreationdate, xCakMessageid, xCakRequestid, xCakBusinessobject, xCakBusinessid, xCakUserid, xCakCallbackurl, xCakPreviousrequestid, xCakAuthorization, xCakInformation);
            //Assert.IsInstanceOf<Persoon> (response, "response is Persoon");
        }
        
    }

}
