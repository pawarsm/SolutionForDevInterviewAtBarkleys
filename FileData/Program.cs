using FileData.Controller;
using FileData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        //This is Console UI which client can use
        public static void Main(string[] args)
        {
            string response = null;
            try
            {
                //use interface reference to achive DI
                IBusinessRuleLogic businessrulelogic = new BusinessRuleLogic();
                var result = businessrulelogic.GetCallFunction(args);
                var filedetails = new FileDetails();

                switch (result)
                {
                    case Models.FileDataEnum.FileVersion:
                        response = filedetails.Version(args[1]);
                        break;
                    case Models.FileDataEnum.FileSize:
                        response = filedetails.Version(args[1]);
                        break;
                    case Models.FileDataEnum.none:
                        response = "Input argument are invalid, please try again";
                        break;
                    default:
                        response = "Please check your Input and try again";
                        break;
                }
                System.Diagnostics.Debug.WriteLine(response);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Application Error Occured - Exception Details - {ex}");              
            }
        }
    }
}
