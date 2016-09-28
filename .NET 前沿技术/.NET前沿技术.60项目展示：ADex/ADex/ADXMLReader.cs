using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace ADex
{
    public class ADXMLReader
    {
        public static List<ADEntity> GetADs()
        {
            List<ADEntity> result=new List<ADEntity>();
            XmlReader xr = XmlReader.Create ( "ADConfig.xml" );
            while(xr.Read())
            {
                string Id = xr.GetAttribute("Id");
               
                string Image = xr.GetAttribute("Image");
                string Title = xr.GetAttribute("Title");
                string Description = xr.GetAttribute("Description");
                if ( Image != null && Title != null )
                {
                    ADEntity ade = new ADEntity();
                    ade.Id = Id;
                    ade.Image = Image;
                    ade.Title = Title;
                    ade.Description = Description;
                    result.Add(ade);
                }
            }
            xr.Close();
            return result;
        }
    }
}