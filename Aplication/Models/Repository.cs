using System.Collections.Generic;
namespace Aplication.Models
{
    public static class Repository
    {
        private static List <User> responses = new List<User>();
        public static IEnumerable<User> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(User response)
        {
            responses.Add(response);
        }
    }
}
