using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access YouTube web service
                // Read the data
                // Create a list of Video objects
                throw new Exception("Some low level YouTube error");
            }
            catch(Exception ex)
            {
                throw new YouTubeException("Could not fetch the vides from YouTube.", ex);
            }
            return new List<Video>();
        }
    }
}
