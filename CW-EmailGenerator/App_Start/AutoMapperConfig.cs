using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CW_EmailGenerator.App_Start
{
    public class AutoMapperConfig
    { 
        /// <summary>
      /// Not used anymore, if you are going to use DI use the Automapper Module to 
      /// load into AutoFac
      /// </summary>
        public static void Configure()
        {
            Mapper.Initialize((config) =>
            {
               
            });
        }
    }
}