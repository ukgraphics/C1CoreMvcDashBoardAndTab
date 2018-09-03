using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C1CoreMvcDashBoardAndTab.Models
{
    public class ProductDashboardData
    {
        public static IEnumerable<ProductData> GetProductData()
        {
            var rand = new Random(0);
            var productID = new[] { "GC001", "GC002", "GC003", "GC004", "GC005" };
            var products = new[] { "ActiveReports", "SPREAD", "ComponetOne", "Wijmo", "SpreadJS" };
            var categories = new[] { ".NET", ".NET", ".NET", "JavaScript", "JavaScript" };
            var description = new[] { "使いやすいデザイナ、縦書きなどの日本仕様対応、PDFやExcelへの出力など、日本の帳票開発に必要なすべての機能を搭載したコンポーネントです。",
                                        "グリッドとスプレッドシートの特長を兼ね備えた表計算データグリッドです。ExcelライクなUIを持つアプリケーションを短期間で開発できます。",
                                        "Windowsフォーム、ASP.NET MVC／Web Forms、WPF、UWP、Xamarinのアプリケーションを開発できるコンポーネントを数多く収録したセットです。",
                                        "軽量／高速、タッチファーストで保守性の高いコントロールにより業務アプリケーション開発をサポートする新世代のJavaScriptコントロールです。",
                                        "Excel風グリッドから自在レイアウトまで、Webアプリのデータ表示に特化したSpread.SheetsとSpread.Viewsの２つのコントロールを搭載する高機能JavaScriptライブラリです。"};
            

            var list = products.Select((p, i) =>
            {
                int stockunits = rand.Next(1, 6);
                int orderunits = rand.Next(1, 9);
                int sales = rand.Next(1, 6);
                return new ProductData { ProductID = productID[i],
                                        ProductName = p,
                                        Category = categories[i],
                                        UnitsInStock = stockunits,
                                        UnitsOnOrder = orderunits,
                                        Sales = sales,
                                        Descriptison = description[i] };
            });

            return list;
        }
    }

    public class ProductData
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int Sales { get; set; }
        public string Descriptison { get; set; }
    }
}
