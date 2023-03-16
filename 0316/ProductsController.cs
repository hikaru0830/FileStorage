using EveryDay.Core.Entities;
using EveryDay.Models.ViewModels;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace EveryDay.Controllers
{
    public class ProductsController : Controller
    {
		public IActionResult Index()
        {
            return View();
		}
		[Route("Products/{Id}")]
        public IActionResult Index(int Id)
        {
            var productsList = new List<ProductViewModel>
            {
                new ProductViewModel{
					Id=1,
					Name="【韓國旅遊】連假出遊．首爾春櫻 5+1 日｜不進人蔘＋保證兩晚市區飯店、石村湖櫻花大道、輪中路櫻花隧道、歐式慶熙大學賞櫻、江華LUGE滑車、樂天世界、穿韓服遊古宮、米其林推薦雙美食｜台灣虎航",
					City="韓國", District="首爾",
                    Price=19900,
                    Images=new List<string>{ "/img/test/test01.jpg", "/img/test/test02.jpg", "/img/test/test03.jpg", "/img/test/test04.jpg", "/img/test/test05.jpg", "/img/test/test06.jpg", "/img/test/test07.jpg", "/img/test/test08.jpg", "/img/test/test09.jpg", "/img/test/test10.jpg", },
                    Feature=@"<ul style=""box-sizing: border-box; padding-left: 2rem; margin-top: 0px; margin-bottom: 1rem; color: rgb(33, 37, 41); font-family: system-ui, -apple-system, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, &quot;Noto Sans&quot;, &quot;Liberation Sans&quot;, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; font-size: 16px;"">
					<li style=""box-sizing: border-box;"">
						不進人蔘購物站，保證入住兩晚市區飯店，深度遊韓零壓力</li>
					<li style=""box-sizing: border-box;"">
						首爾賞櫻名所＋文青網美景點一次滿足</li>
					<li style=""box-sizing: border-box;"">
						穿韓服遊古宮、品嚐米其林美食＆漢江公園野餐體驗</li>
					<li style=""box-sizing: border-box;"">
						海外團體＆自由行 客服諮詢專線 02-77415163</li>
					</ul>",
				},
                new ProductViewModel{
					Id=2,
					Name="日本京都｜嵐山・嵯峨野小火車車票｜嵯峨ー龜岡區間",
					City="日本", District="京都",
                    Price=12000,
                    Images=new List<string>{ "/img/test/1/01.jpg", "/img/test/1/02.jpg", "/img/test/1/03.jpg", "/img/test/1/04.jpg", "/img/test/1/05.jpg", },
                    Feature=@"<ul style=""box-sizing: border-box; padding-left: 2rem; margin-top: 0px; margin-bottom: 1rem; color: rgb(33, 37, 41); font-family: system-ui, -apple-system, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, &quot;Noto Sans&quot;, &quot;Liberation Sans&quot;, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; font-size: 16px;"">
					<li style=""box-sizing: border-box; padding: 5px 0px; word-break: break-word;"">
						事前預約，就可以讓您在黃金週等連休或楓葉季時輕鬆搭車</li>
					<li style=""box-sizing: border-box; padding: 5px 0px; word-break: break-word;"">
						連接嵐山和龜岡的「嵯峨野小火車」，是可以欣賞到新鮮的綠葉和楓葉等嵯峨野四季景色的觀光列車。</li>
					<li style=""box-sizing: border-box; padding: 5px 0px; word-break: break-word;"">
						坐在車內就可以欣賞到春天的櫻花、夏天的綠芽、秋天的楓樹等四季不同的美景。</li>
					</ul>"
				},
                new ProductViewModel{
                    Id=3,
                    Name="亞拉河谷熱氣球之旅 |維多利亞",
                    City="澳洲", District="墨爾本",
                    Price=999,
                    Images=new List<string>{ "/img/test/2/1.jpg", "/img/test/2/2.jpg", "/img/test/2/3.jpg", "/img/test/2/4.jpg", "/img/test/2/5.jpg", },
                    Feature=@"<p style=""box-sizing: border-box; margin: 0px 0px 10px; font-size: 14px; color: rgb(51, 51, 51); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; letter-spacing: 0.5px;"">
					乘坐令人難忘的熱氣球飛越亞拉河谷，欣賞澳大利亞標誌性地標的日出，鳥瞰墨爾本市中心甦醒。同時隨著您漂蕩並從高處發現下方必看景點！</p>
					<ul style=""box-sizing: border-box; margin-top: 0px; margin-bottom: 10px; padding-left: 25px; color: rgb(51, 51, 51); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px; letter-spacing: 0.5px;"">
					<li style=""box-sizing: border-box; padding: 5px 0px; word-break: break-word;"">
						乘坐熱氣球觀光，360 度俯瞰墨爾本城市生活</li>
					<li style=""box-sizing: border-box; padding: 5px 0px; word-break: break-word;"">
						專業的熱氣球飛行員帶旅客飛行在藝術氣息的墨爾本上空</li>
					<li style=""box-sizing: border-box; padding: 5px 0px; word-break: break-word;"">
						於飛行後能感受尊榮禮遇，享用美味早餐與香檳</li>
					</ul>"
                },
            };

            var model = productsList.First(x => x.Id == Id);


			return View(model);
        }

        [Route("Products/ProductSearch")]
        public IActionResult ProductSearch()
        {
            return View();
        }
    }
}
