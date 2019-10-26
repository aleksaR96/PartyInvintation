using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvintation.Models
{
    public static class Repository
    {
        private static List<ResponseModel> responses = new List<ResponseModel>();

        public static IEnumerable<ResponseModel> Responses
        {
            get
            {
                return responses;
            }
        }

        public static void AddResponse(ResponseModel newResponse)
        {
            responses.Add(newResponse);
        }
    }
}
