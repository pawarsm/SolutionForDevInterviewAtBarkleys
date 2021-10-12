using FileData.Interfaces;
using FileData.Models;
using FileData.Constants;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData.Controller
{
    public class BusinessRuleLogic : IBusinessRuleLogic
    {
        private readonly List<string> fileversionconfig;
        private readonly List<string> filesizeconfig;

        // Providing the Valid list of input args from app.config via constructor 
        public BusinessRuleLogic()
        {
            fileversionconfig = new List<string>(ConfigurationManager.AppSettings[Constant.Fileversionconfigkey].Split(new char[] { ';' })) ?? throw new ArgumentNullException("Missing File Version Config");
            filesizeconfig = new List<string>(ConfigurationManager.AppSettings[Constant.Filesizeconfigkey].Split(new char[] { ';' })) ?? throw new ArgumentNullException("Missing File Size Config");

        }

        //This will define that Which method client want to call - File Version or File Size
        public FileDataEnum GetCallFunction(string[] inputargs)
        {
            //input argument count should be 2 
            if (inputargs.Count() == 2)
            {
                if (fileversionconfig.Contains(inputargs[0]))
                {
                    return FileDataEnum.FileVersion;
                }

                if (filesizeconfig.Contains(inputargs[0]))
                {
                    return FileDataEnum.FileSize;
                }
            }
            return FileDataEnum.none;
        }
    }
}
