using FileData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData.Interfaces
{
    public interface IBusinessRuleLogic
    {
        FileDataEnum GetCallFunction(string[] inputargs);
    }
}
