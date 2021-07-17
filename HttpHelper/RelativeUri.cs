using System.Linq;

namespace MainLibrary.HttpHelper
{
    public class RelativeUri
    {
        public string StringUri;

        public RelativeUri(string stringUri)
        {
            StringUri = stringUri;
        }
        
        public RelativeUri()
        {
            StringUri = "";
        }

        public RelativeUri AddQueryParam(string paramName, string paramValue)
        {
            string toAdd = $"{paramName}={paramValue}"; 
            if (StringUri.Contains("?"))
            {
                StringUri += "&" +  toAdd; 
            }
            else
            {
                StringUri += ("?" + toAdd); 
            }
            return this;
        }
        public RelativeUri AddNormalParam(string paramName)
        {
           
            string toAdd = $"{paramName}";

            
            StringUri += "/";
            

            StringUri += toAdd;

            return this;
        }
        
    }
}