#pragma checksum "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\AllDealerPurchaseList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d2bf8cc5a3a361bf0051d45a4e247fcea910760"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_FAMSDEALER_Views_Purchase_AllDealerPurchaseList), @"mvc.1.0.view", @"/Areas/FAMSDEALER/Views/Purchase/AllDealerPurchaseList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/FAMSDEALER/Views/Purchase/AllDealerPurchaseList.cshtml", typeof(AspNetCore.Areas_FAMSDEALER_Views_Purchase_AllDealerPurchaseList))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\_ViewImports.cshtml"
using FADMS;

#line default
#line hidden
#line 2 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\_ViewImports.cshtml"
using FADMS.Models;

#line default
#line hidden
#line 3 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\_ViewImports.cshtml"
using FADMS.Areas.FAMSDEALER;

#line default
#line hidden
#line 6 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\AllDealerPurchaseList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d2bf8cc5a3a361bf0051d45a4e247fcea910760", @"/Areas/FAMSDEALER/Views/Purchase/AllDealerPurchaseList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d6da59ad1f56a285e9f316e27282c43cacd5d73", @"/Areas/FAMSDEALER/Views/_ViewImports.cshtml")]
    public class Areas_FAMSDEALER_Views_Purchase_AllDealerPurchaseList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FADMS.Areas.FAMSDEALER.Models.PurchaseViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\AllDealerPurchaseList.cshtml"
  
    ViewData["Title"] = "AllDealerPurchaseList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(244, 1218, true);
            WriteLiteral(@"<div class=""col-12"" style=""width:98%"">
    <div class=""row clearfix"">
        <div class=""col-12"">
            <div class=""card mb-4"">
                <!-- Card Header - Dropdown -->
                <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                    <h5 class=""m-0 font-weight-bold"">ক্রয়ের তালিকা </h5>
                    <a href=""/FAMSDEALER/Purchase/Index"" class=""btn btn-info btn-sm pull-right"">নতুন যোগ করুন</a>
                </div>

                <!-- Card Body -->
                <div class=""card-body"">
                    <table class=""table table-striped table-bordered table-sm"" id=""PurchaseList"">
                        <thead>
                            <tr>
                                <th width=""5%"">ক্রমিক নং</th>
                                <th width=""10%"">ডিলারের নাম</th>
                                <th width=""15%"">ক্রয় নম্বর</th>
                                <th width=""10%"">ক্রয় তারিখ</th>
          ");
            WriteLiteral("                      <th width=\"15%\">সরবরাহকারীর নাম</th>\r\n                                <th width=\"10%\">প্রক্রিয়া \t</th>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 31 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\AllDealerPurchaseList.cshtml"
                              
                                int i = 1;


                                

#line default
#line hidden
#line 35 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\AllDealerPurchaseList.cshtml"
                                 foreach (var data in Model.purchaseOrderMasters.OrderByDescending(x => x.poDate))
                                {

#line default
#line hidden
            BeginContext(1693, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(1780, 1, false);
#line 38 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\AllDealerPurchaseList.cshtml"
                                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1781, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1833, 23, false);
#line 39 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\AllDealerPurchaseList.cshtml"
                                       Write(data.dealer?.dealerName);

#line default
#line hidden
            EndContext();
            BeginContext(1856, 79, true);
            WriteLiteral("</td>\r\n                                        <td><span style=\"display:none\">-");
            EndContext();
            BeginContext(1936, 7, false);
#line 40 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\AllDealerPurchaseList.cshtml"
                                                                   Write(data.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1943, 8, true);
            WriteLiteral("-</span>");
            EndContext();
            BeginContext(1952, 9, false);
#line 40 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\AllDealerPurchaseList.cshtml"
                                                                                   Write(data.poNo);

#line default
#line hidden
            EndContext();
            BeginContext(1961, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2013, 36, false);
#line 41 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\AllDealerPurchaseList.cshtml"
                                       Write(data.poDate?.ToString("dd-MMM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2049, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2101, 27, false);
#line 42 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\AllDealerPurchaseList.cshtml"
                                       Write(data.supplier?.supplierName);

#line default
#line hidden
            EndContext();
            BeginContext(2128, 123, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2251, "\"", 2296, 2);
            WriteAttributeValue("", 2258, "/FAMSDEALER/Purchase/Index?id=", 2258, 30, true);
#line 44 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\AllDealerPurchaseList.cshtml"
WriteAttributeValue("", 2288, data.Id, 2288, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2297, 116, true);
            WriteLiteral(" title=\"Edit\"><i class=\"fa fa-edit\"></i></a>\r\n                                            <a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2413, "\"", 2467, 2);
            WriteAttributeValue("", 2420, "/FAMSDEALER/Purchase/PurchaseDetail?id=", 2420, 39, true);
#line 45 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\AllDealerPurchaseList.cshtml"
WriteAttributeValue("", 2459, data.Id, 2459, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2468, 140, true);
            WriteLiteral(" target=\"_blank\" title=\"Details\"><i class=\"fas fa-info-circle\"></i></a>\r\n                                            <a class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2608, "\"", 2676, 2);
            WriteAttributeValue("", 2615, "/FAMSDEALER/Purchase/PurchaseOrderPdfAction?MasterId=", 2615, 53, true);
#line 46 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\AllDealerPurchaseList.cshtml"
WriteAttributeValue("", 2668, data.Id, 2668, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2677, 165, true);
            WriteLiteral(" target=\"_blank\" title=\"Purchase Invoice\"><i class=\"fa fa-print\"></i></a>\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 49 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\AllDealerPurchaseList.cshtml"
                                    i++;
                                }

#line default
#line hidden
            BeginContext(2952, 152, true);
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3121, 782, true);
                WriteLiteral(@"


    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#PurchaseList').DataTable();


            var table = $('#PurchaseList').DataTable();

            $('#PurchaseList tbody').on('click', 'tr', function () {
                var data = table.row(this).data();
                var iddata = data[1];
                let id = iddata.replace('<span style=""display:none"">', """").replace(""</span>"", """");
                var vid = parseInt(id.split('-')[1]);
                window.location.href = ""/FAMSDEALER/Purchase/PurchaseDetail/?id="" + vid;
            });
            $('#PurchaseList tbody').on('click', 'td:last-child', function (e) {
                e.stopPropagation();
            });

        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(3906, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Style", async() => {
                BeginContext(3925, 104, true);
                WriteLiteral("\r\n    <style>\r\n        #PurchaseList tbody tr {\r\n            cursor: pointer;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(4032, 14, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FADMS.Areas.FAMSDEALER.Models.PurchaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591