using Newtonsoft.Json;
using System;
using System.Xml.Linq;

namespace azure_portal_lib.Helpers
{
    public static class ConvertXmlToJson
    {
        
        public static string Convert(string restResponseContent)
        {
            try
            {
                XDocument xmlDoc = XDocument.Parse(restResponseContent);

                string jsonString = JsonConvert.SerializeXNode(xmlDoc, Newtonsoft.Json.Formatting.None, true);

                return jsonString;
            }
            catch (Exception e)
            {
                //tratar melhor em ingles
                throw new Exception(e.Message);
            }
            
        }
    }
}
