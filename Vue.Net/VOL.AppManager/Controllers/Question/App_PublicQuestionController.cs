﻿/*
 *Author：jxx
 *Contact：283591387@qq.com
 *Date：2018-07-01
 * 此代码由框架生成，请勿随意更改
 */
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOL.AppManager.IServices;
using VOL.Core.Controllers.Basic;
using Microsoft.AspNetCore.Mvc;

namespace VOL.AppManager.Controllers
{
    public partial class App_PublicQuestionController : WebBaseController<IApp_PublicQuestionService>
    {
        public App_PublicQuestionController(IApp_PublicQuestionService service)
        : base("AppManager","Question","App_PublicQuestion", service)
        {
        }
    }
}

