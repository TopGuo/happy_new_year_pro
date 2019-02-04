using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xunit;

namespace tests
{
    public class UnitTest1:ApiTestBase
    {
        HttpClient _client;
        public UnitTest1()
        {
            //_client = base.GetClient();
        }

        [Theory]
        [InlineData("Values","GetName")]
        public async Task Test_Values_GetName(string controllerName,string action)
        {
            // var response = await _client.GetAsync($"/api/{controllerName}/{action}?id=1");
            // response.EnsureSuccessStatusCode();
            // var stringResponse = await response.Content.ReadAsStringAsync();
            // var result = JsonConvert.DeserializeObject<Result>(stringResponse);
            // var data=result.Data;
            // Assert.Equal("你好", result.Data);
            //Assert.NotEmpty(stringResponse);
            //Assert.Empty(stringResponse);
        }


        [Fact]
        public void Test1()
        {

        }


    }
}
