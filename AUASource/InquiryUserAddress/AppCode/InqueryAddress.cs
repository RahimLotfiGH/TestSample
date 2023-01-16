using InquiryUserAddress.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using UpdateCity.Agetn.AppCode;

namespace InquiryUserAddress.AppCode
{
    public class InqueryAddress
    {
        private readonly DataStorage _storage;

        public InqueryAddress()
        {
            _storage = new DataStorage();
        }

        public void Run()
        {
            int cityId = 3; //Tehran city Id is 3 

            Inquery(cityId);

        }

        private void Inquery(int cityId)
        {
            try
            {
                TryInquery(cityId);
            }
            catch (Exception ex)
            {
                LogSyetem.Log("inquery >>", ex.Message);
            }
        }
        private void TryInquery(int cityId)
        {

            var pagesize = 10;
            var lastIdCount = LastId(cityId);


            while (true)
            {
                var dtos = GetAddressCityId(cityId, lastIdCount, pagesize);

                if (!dtos.Any()) return;

                _storage.BalkInsert(dtos);

                lastIdCount = dtos.Max(x => x.Id);

                System.Threading.Thread.Sleep(1000);
            }

        }

        public List<UserAddressDto> GetAddressCityId(int cityId, long startId, int count)
        {
            //api/V1.0/AppUserAddress/GetAddressCityId

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7032/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                var path = "api/V1.0/AppUserAddress/GetAddressCityId/?cityId=" + cityId + "&startId=" + startId + "&count=" + count;

                HttpResponseMessage response =  client.GetAsync(path).Result;
                if (response.IsSuccessStatusCode)
                {
                    var  result= response.Content.ReadAsStringAsync().Result;
                    
                    var dtos= JsonConvert.DeserializeObject<Root>(result);

                    return dtos.result;
                }

                return new List<UserAddressDto>();
            }
        }

        public long LastId(int cityId)
        {
            return _storage.GetLastId(cityId);
        }
    }
}
