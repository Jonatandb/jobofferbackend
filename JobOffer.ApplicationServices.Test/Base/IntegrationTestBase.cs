﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;

namespace JobOffer.ApplicationServices.Test.Base
{
    [TestClass]
    public class IntegrationTestBase
    {
        protected readonly IMongoDatabase _database;


        public IntegrationTestBase()
        {
            _database = SetupIntegrationTest.DatabaseTest;
        }
    }
}
