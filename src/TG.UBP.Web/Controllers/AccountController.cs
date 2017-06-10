using OSharp.Utility.Data;
using OSharp.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using OSharp.Web.Mvc.Security;
using TG.UBP.Utility;
using TG.UBP.Utility.Config;
using TG.UBP.Web.Utility;
using System.Threading.Tasks;
using OSharp.Web.Mvc.UI;
using TG.UBP.Application.Service.BaseManage.Identity;
using TG.UBP.Application.Dto.BaseManage.Identity;
using OSharp.Web.Mvc.Extensions;
using TG.UBP.Web.Core;

namespace TG.UBP.Web.Controllers
{
    public class AccountController : BaseController
    {
        public ISiteConfigProvider SiteConfigProvider { get; set; }

        public IIdentityContract IdentityContract { get; set; }

        // GET: Login
        public ActionResult Index()
        {
            SiteConfig siteConfig = SiteConfigProvider.LoadConfig(Utils.GetXmlMapPath("Configpath"));

            //系统名称
            ViewBag.WebName = siteConfig.webname;
            //公司名称
            ViewBag.ComName = siteConfig.webcompany;
            //CopyRight
            ViewBag.CopyRight = siteConfig.webcopyright;

            return View();
        }

        /// <summary>
        /// 生成验证码
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult VerifyCode()
        {
            return File(new VerifyCode().GetVerifyCode(), @"image/Gif");
        }

        [HttpPost]
        public async Task<ActionResult> Login(string UserName, string Password, string Code)
        {
            if (Session[OSharp.Core.Constants.VerifyCodeSession] == null)
                return Json(new OperationResult(OperationResultType.ValidError, "请重新刷新验证码").ToAjaxResult(), JsonRequestBehavior.AllowGet);

            if (!SecurityHelper.CheckVerify(Code))
                return Json(new OperationResult(OperationResultType.ValidError, "验证码错误").ToAjaxResult(), JsonRequestBehavior.AllowGet);

            UserOutputDto user = await IdentityContract.Login(UserName, Password);
            if (user == null)
            {
                Logger.Info("用户:" + UserName + "在" + Utils.NowTime + "登录系统,IP:" + this.Request.GetIpAddress() + "账户或密码错误");
                return Json(new OperationResult(OperationResultType.ValidError, "用户名或密码错误").ToAjaxResult(), JsonRequestBehavior.AllowGet);
            }
            else if (Convert.ToBoolean(user.IsLocked))//被禁用
            {
                return Json(new OperationResult(OperationResultType.ValidError, "账户被系统禁用").ToAjaxResult(), JsonRequestBehavior.AllowGet);
            }

            AccountModel account = new AccountModel();
            account.Id = user.Id.ToString();
            account.NickName = user.NickName;
            //account.Photo = string.IsNullOrEmpty(user.Photo) ? "/Images/Photo.jpg" : user.Photo;
            Session["Account"] = account;
            GetThemes(user.Id.ToString());

            //LoginUserManage.Add(Session.SessionID, account.Id);

            //在线用户统计
            //OnlineHttpModule.ProcessRequest();
            Logger.Info("用户:" + UserName + "在" + Utils.NowTime + "登录系统,IP:" + this.Request.GetIpAddress() + "登录成功");
            return Json(new OperationResult(OperationResultType.Success, "登录成功").ToAjaxResult(), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 安全退出
        /// </summary>
        [HttpPost]
        public void LogOut()
        {
            if (Session["Account"] != null)
                Session["Account"] = null;
            Session.Clear();
            Session.Abandon();
        }

        public void GetThemes(string userid)
        {
            //SysUserConfigModel entity = userConfigBLL.GetById("themes", userid);
            //SysUserConfigModel menuEntity = userConfigBLL.GetById("menu", userid);
            //if (entity != null)
            //{
            //    Session["themes"] = entity.Value;
            //}
            //else
            //{
            //    Session["themes"] = "blue";
            //}
            //if (menuEntity != null)
            //{
            //    Session["menu"] = menuEntity.Value;
            //}
            //else
            //{
            //    Session["menu"] = "accordion";
            //}

            Session["themes"] = "purple";
            Session["menu"] = "accordion,topmenu";
        }
    }
}