using Aop.Api;
using Aop.Api.Domain;
using Aop.Api.Request;
using Aop.Api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlipayDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection coll)
        {
            double amount = Convert.ToDouble(coll["EnterAmount"]);

            //实例化默认的DefaultAopClient
            DefaultAopClient aop = new DefaultAopClient(AlipayConfig.gateURL, AlipayConfig.APPID, AlipayConfig.private_Key, "json", "1.0", AlipayConfig.sign_Type, AlipayConfig.public_Key, AlipayConfig.charset);//AlipayConfig.charset可写可不写,默认为UTF-8
          
            AlipayTradePagePayModel model = new AlipayTradePagePayModel();

            model.Body = "叫姐姐姐姐姐姐姐姐姐姐姐姐姐姐";

            model.Subject = "沙箱模拟";
            //精确到小数点后2位
            model.TotalAmount = amount.ToString();
            //商品唯一编号
            model.OutTradeNo = Guid.NewGuid().ToString().ToLower();
            //支付类型
            model.ProductCode = "FAST_INSTANT_TRADE_PAY";

            //支付宝请求
            AlipayTradePagePayRequest request = new AlipayTradePagePayRequest();
            //支付成功后的跳转页面
            request.SetReturnUrl("http://localhost:3322/Home/Success");
            request.SetNotifyUrl("");
            //封装支付宝模型到请求对象中
            request.SetBizModel(model);

            //支付宝响应
            AlipayTradePagePayResponse response =null;
            response=aop.pageExecute(request,null,"post");
            Response.Write(response.Body);

            return View();
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}
