#pragma checksum "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\PurchaseImportList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffe14902076dd4a695c30dc4347bf7aedd21b741"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_FAMSDEALER_Views_Purchase_PurchaseImportList), @"mvc.1.0.view", @"/Areas/FAMSDEALER/Views/Purchase/PurchaseImportList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/FAMSDEALER/Views/Purchase/PurchaseImportList.cshtml", typeof(AspNetCore.Areas_FAMSDEALER_Views_Purchase_PurchaseImportList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffe14902076dd4a695c30dc4347bf7aedd21b741", @"/Areas/FAMSDEALER/Views/Purchase/PurchaseImportList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d6da59ad1f56a285e9f316e27282c43cacd5d73", @"/Areas/FAMSDEALER/Views/_ViewImports.cshtml")]
    public class Areas_FAMSDEALER_Views_Purchase_PurchaseImportList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FADMS.Areas.FAMSDEALER.Models.PurchaseViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\PurchaseImportList.cshtml"
  
    ViewData["Title"] = "PurchaseImportList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(157, 1156, true);
            WriteLiteral(@"
<div class=""col-12"" style=""width:98%"">
    <div class=""row clearfix"">
        <div class=""col-12"">
            <div class=""card mb-4"">
                <!-- Card Header - Dropdown -->
                <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                    <h5 class=""m-0 font-weight-bold""> ক্রয় তালিকা </h5>
                    <a href=""/FAMSDEALER/Purchase/Index"" class=""btn btn-info btn-sm pull-right"">নতুন যোগ করুন </a>
                </div>

                <!-- Card Body -->
                <div class=""card-body"">
                    <table class=""table table-striped table-bordered table-sm"" id=""PurchaseList"">
                        <thead>
                            <tr>
                                <th width=""5%"">সিরিয়াল নং </th>
                                <th width=""15%"">ক্রয় নং</th>
                                <th width=""10%""> ক্রয়ের তারিখ </th>
                                <th width=""25%"">সরবরাহকারীর নাম</th>
   ");
            WriteLiteral("                             <th width=\"10%\">সম্পাদনা করুন</th>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 29 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\PurchaseImportList.cshtml"
                              
                                int i = 1;


                                

#line default
#line hidden
#line 33 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\PurchaseImportList.cshtml"
                                 foreach (var data in Model.purchaseOrderMasters)
                                {

#line default
#line hidden
            BeginContext(1511, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(1598, 1, false);
#line 36 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\PurchaseImportList.cshtml"
                                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1599, 79, true);
            WriteLiteral("</td>\r\n                                        <td><span style=\"display:none\">-");
            EndContext();
            BeginContext(1679, 7, false);
#line 37 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\PurchaseImportList.cshtml"
                                                                   Write(data.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1686, 8, true);
            WriteLiteral("-</span>");
            EndContext();
            BeginContext(1695, 9, false);
#line 37 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\PurchaseImportList.cshtml"
                                                                                   Write(data.poNo);

#line default
#line hidden
            EndContext();
            BeginContext(1704, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1756, 36, false);
#line 38 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\PurchaseImportList.cshtml"
                                       Write(data.poDate?.ToString("dd-MMM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1792, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1844, 27, false);
#line 39 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\PurchaseImportList.cshtml"
                                       Write(data.supplier?.supplierName);

#line default
#line hidden
            EndContext();
            BeginContext(1871, 123, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1994, "\"", 2048, 2);
            WriteAttributeValue("", 2001, "/FAMSDEALER/Purchase/DealerPurchase?id=", 2001, 39, true);
#line 41 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\PurchaseImportList.cshtml"
WriteAttributeValue("", 2040, data.Id, 2040, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2049, 116, true);
            WriteLiteral(" title=\"Edit\"><i class=\"fa fa-edit\"></i></a>\r\n                                            <a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2165, "\"", 2219, 2);
            WriteAttributeValue("", 2172, "/FAMSDEALER/Purchase/PurchaseDetail?id=", 2172, 39, true);
#line 42 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\PurchaseImportList.cshtml"
WriteAttributeValue("", 2211, data.Id, 2211, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2220, 140, true);
            WriteLiteral(" target=\"_blank\" title=\"Details\"><i class=\"fas fa-info-circle\"></i></a>\r\n                                            <a class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2360, "\"", 2428, 2);
            WriteAttributeValue("", 2367, "/FAMSDEALER/Purchase/PurchaseOrderPdfAction?MasterId=", 2367, 53, true);
#line 43 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\PurchaseImportList.cshtml"
WriteAttributeValue("", 2420, data.Id, 2420, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2429, 165, true);
            WriteLiteral(" target=\"_blank\" title=\"Purchase Invoice\"><i class=\"fa fa-print\"></i></a>\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 46 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Purchase\PurchaseImportList.cshtml"
                                    i++;
                                }

#line default
#line hidden
            BeginContext(2704, 152, true);
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2873, 782, true);
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
            BeginContext(3658, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Style", async() => {
                BeginContext(3677, 104, true);
                WriteLiteral("\r\n    <style>\r\n        #PurchaseList tbody tr {\r\n            cursor: pointer;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(3784, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
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