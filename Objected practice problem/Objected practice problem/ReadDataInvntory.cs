using System;
using System.Collections.Generic;
using System.Text;

namespace Objected_practice_problem
{
   public class ReadInventoryData
    {
        public InventoryDataManagementModel Read(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoryDataManagementModel>(json);
                }
                catch (Exception e)
                {
                    Console.WriteLine("problem in getting data {0}", e);
                    return null;
                }
            }
        }
    }
}
