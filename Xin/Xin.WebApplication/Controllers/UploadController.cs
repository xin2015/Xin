using Common.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Xin.WebApplication.Controllers
{
    public class UploadController : Controller
    {
        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MultipleFilesUpload()
        {
            return View();
        }

        public JsonResult Upload(FormCollection fc)
        {
            ILog logger = LogManager.GetLogger("Upload");
            bool status;
            string message;
            try
            {
                HttpPostedFileBase file = Request.Files[0];
                string imgType = fc["imgType"];
                string filePath = "/Content/Upload/";
                string absolutePath = Server.MapPath(filePath);
                if (!Directory.Exists(absolutePath))//判断上传文件夹是否存在，若不存在，则创建
                {
                    Directory.CreateDirectory(absolutePath);//创建文件夹
                }
                file.SaveAs(absolutePath + file.FileName);
                status = true;
                message = "图片上传成功！";
            }
            catch (Exception e)
            {
                logger.Error("上传图片失败！", e);
                status = false;
                message = "图片上传失败！";
            }
            return Json(new { Status = status, Message = message }, JsonRequestBehavior.DenyGet);
        }
    }
}