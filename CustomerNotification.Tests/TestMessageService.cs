using CustomerNotification.API;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CustomerNotification.Tests
{
  public  class TestMessageService
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public TestMessageService()
        {
            // Arrange
            _server = new TestServer(new WebHostBuilder()
               .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Fact]
        public async Task response_should_be_success()
        {
            // Act
            var response = await _client.GetAsync("/Message/CustomerNotification/Customer1");
            // Assert
            Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task response_should_be_csv()
        {
            //Given
            var expected_csv = "UserDeleted,Customer2";
            // Act
            var response = await _client.GetAsync("/Message/CustomerNotification/Customer2");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            // Assert
            Assert.True(expected_csv.Equals(responseString));
        }

        [Fact]
        public async Task response_should_be_json()
        {
            //Given
            var expected_csv = JObject.Parse(File.ReadAllText("InputJson.json"));
            // Act
            var response = await _client.GetAsync("/Message/CustomerNotification/Customer1");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            // Assert
            Assert.Equal(expected_csv,JObject.Parse(responseString));
        }
    }

}
