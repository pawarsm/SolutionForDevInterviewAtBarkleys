using System;
using FileData.Controller;
using FileData.Interfaces;
using FileData.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileDataTest
{
    [TestClass]
    public class BusinessRuleLogicTest
    {
        
        [TestMethod]
        public void BusinessRuleLogicTest_PassInvalidargs_shouldreturnnullEnumvalue()
        {
            IBusinessRuleLogic businessrulelogic = new BusinessRuleLogic();
            var args = CreateInvalidinputargs();
            var result = businessrulelogic.GetCallFunction(args);
            Assert.AreEqual(result, FileDataEnum.none);

        }

        [TestMethod]
        public void BusinessRuleLogicTest_PassValidargs_ShouldReturnFileversionEnum()
        {
            IBusinessRuleLogic businessrulelogic = new BusinessRuleLogic();
            var args = CreateValidFIleVersioninputargs();
            var result = businessrulelogic.GetCallFunction(args);
            Assert.AreEqual(result, FileDataEnum.FileVersion);

        }

        [TestMethod]
        public void BusinessRuleLogicTest_PassValidargs_ShouldReturnFileSizeEnum()
        {
            IBusinessRuleLogic businessrulelogic = new BusinessRuleLogic();
            var args = CreateValidFIleSizeinputargs();
            var result = businessrulelogic.GetCallFunction(args);
            Assert.AreEqual(result, FileDataEnum.FileSize);

        }

        private string[] CreateInvalidinputargs()
        {
            return new string[2] { "invalid" , "FileDetails.Version" };
        }

        private string[] CreateValidFIleVersioninputargs()
        {
            return new string[2] { "-v", "C:/test.txt" };
        }

        private string[] CreateValidFIleSizeinputargs()
        {
            return new string[2] { "--s", "C:/test.txt" };
        }
    }
}
