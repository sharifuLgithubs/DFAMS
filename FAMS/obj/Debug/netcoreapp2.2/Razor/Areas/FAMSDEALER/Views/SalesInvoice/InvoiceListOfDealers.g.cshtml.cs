#pragma checksum "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\SalesInvoice\InvoiceListOfDealers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5bab9a0b70ada189e6ce928a670f4578b731844"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_FAMSDEALER_Views_SalesInvoice_InvoiceListOfDealers), @"mvc.1.0.view", @"/Areas/FAMSDEALER/Views/SalesInvoice/InvoiceListOfDealers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/FAMSDEALER/Views/SalesInvoice/InvoiceListOfDealers.cshtml", typeof(AspNetCore.Areas_FAMSDEALER_Views_SalesInvoice_InvoiceListOfDealers))]
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
#line 7 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\SalesInvoice\InvoiceListOfDealers.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5bab9a0b70ada189e6ce928a670f4578b731844", @"/Areas/FAMSDEALER/Views/SalesInvoice/InvoiceListOfDealers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d6da59ad1f56a285e9f316e27282c43cacd5d73", @"/Areas/FAMSDEALER/Views/_ViewImports.cshtml")]
    public class Areas_FAMSDEALER_Views_SalesInvoice_InvoiceListOfDealers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FADMS.Areas.FAMSDEALER.Models.SalesInvoiceViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\SalesInvoice\InvoiceListOfDealers.cshtml"
  
    ViewData["Title"] = "InvoiceListOfDealers";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(163, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(249, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Style", async() => {
                BeginContext(266, 164, true);
                WriteLiteral("\r\n    <style>\r\n        .redStar {\r\n            color: red;\r\n        }\r\n\r\n        #tblInvoiceList tbody tr {\r\n            cursor: pointer;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(433, 1725, true);
            WriteLiteral(@"
<div class=""col-12"">
    <div class=""card"" style=""width: 100%;"">
        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-6"">
                    <h5 class=""card-title"" style=""color: black"">বিক্রয় চালানের তালিকা</h5>
                </div>
                <div class=""col-6"">
                    <a href=""/FAMSDEALER/SalesInvoice/DealerSales?id=0"" style=""background-color:#024972;float:right;"" class=""btn btn-info btn-sm"">নতুন যুক্ত করুন</a>
                </div>
            </div>
            <hr>
            <div class=""container"">
                <div class=""row"">
                    <input type=""hidden"" id=""rowCount"" name=""rowCount"" value=""0"" />
                    <div class=""col-12"">
                        <table class=""table table-bordered table-striped"" id=""tblInvoiceList"" data-parsley-required=""true"">
                            <thead style=""width:100%;"">
                                <tr>
                                    <th>ক্রমিক নং</t");
            WriteLiteral(@"h>
                                    <th>ডিলারের নাম</th>
                                    <th>চালান নং</th>
                                    <th>আগ্নেয়াস্ত্র নাম</th>
                                    <th>চালান তারিখ</th>
                                    <th>লাইসেন্স নম্বর </th>
                                    <th>সর্ব মোট (Gross)</th>
                                    <th>ভ্যাট</th>
                                    <th>ট্যাক্স</th>
                                    <th>সর্বমোট(net)</th>
                                    <th>প্রক্রিয়া 	</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 55 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\SalesInvoice\InvoiceListOfDealers.cshtml"
                                  

                                    int i = 1;

                                    

#line default
#line hidden
#line 59 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\SalesInvoice\InvoiceListOfDealers.cshtml"
                                     foreach (var item in Model.salesInvoiceMastersDetails.OrderByDescending(x=>x.salesInvoiceMaster.invoiceDate))
                                    {


#line default
#line hidden
            BeginContext(2435, 105, true);
            WriteLiteral("                                        <tr>\r\n                                            <td width=\"2%\">");
            EndContext();
            BeginContext(2541, 1, false);
#line 63 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\SalesInvoice\InvoiceListOfDealers.cshtml"
                                                      Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2542, 67, true);
            WriteLiteral("</td>\r\n                                            <td width=\"10%\">");
            EndContext();
            BeginContext(2610, 42, false);
#line 64 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\SalesInvoice\InvoiceListOfDealers.cshtml"
                                                       Write(item.salesInvoiceMaster.dealer?.dealerName);

#line default
#line hidden
            EndContext();
            BeginContext(2652, 95, true);
            WriteLiteral("</td>\r\n                                            <td width=\"15%\"><span style=\"display:none\">-");
            EndContext();
            BeginContext(2748, 7, false);
#line 65 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\SalesInvoice\InvoiceListOfDealers.cshtml"
                                                                                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2755, 8, true);
            WriteLiteral("-</span>");
            EndContext();
            BeginContext(2764, 38, false);
#line 65 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\SalesInvoice\InvoiceListOfDealers.cshtml"
                                                                                                   Write(item.salesInvoiceMaster?.invoiceNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2802, 66, true);
            WriteLiteral("</td>\r\n                                            <td width=\"2%\">");
            EndContext();
            BeginContext(2869, 38, false);
#line 66 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\SalesInvoice\InvoiceListOfDealers.cshtml"
                                                      Write(item.itemSpecification?.Item?.itemName);

#line default
#line hidden
            EndContext();
            BeginContext(2907, 67, true);
            WriteLiteral("</td>\r\n                                            <td width=\"10%\">");
            EndContext();
            BeginContext(2975, 60, false);
#line 67 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\SalesInvoice\InvoiceListOfDealers.cshtml"
                                                       Write(item.salesInvoiceMaster?.invoiceDate?.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3035, 67, true);
            WriteLiteral("</td>\r\n                                            <td width=\"13%\">");
            EndContext();
            BeginContext(3103, 51, false);
#line 68 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\SalesInvoice\InvoiceListOfDealers.cshtml"
                                                       Write(item.salesInvoiceMaster?.licenseInfo?.licenseNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3154, 92, true);
            WriteLiteral("</td>\r\n                                            <td width=\"10%\" style=\"text-align:right\">");
            EndContext();
            BeginContext(3247, 56, false);
#line 69 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\SalesInvoice\InvoiceListOfDealers.cshtml"
                                                                                Write(item.salesInvoiceMaster?.totalAmount?.ToString("0,0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(3303, 91, true);
            WriteLiteral("</td>\r\n                                            <td width=\"8%\" style=\"text-align:right\">");
            EndContext();
            BeginContext(3395, 55, false);
#line 70 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\SalesInvoice\InvoiceListOfDealers.cshtml"
                                                                               Write(item.salesInvoiceMaster?.VATOnTotal?.ToString("0,0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(3450, 91, true);
            WriteLiteral("</td>\r\n                                            <td width=\"8%\" style=\"text-align:right\">");
            EndContext();
            BeginContext(3542, 55, false);
#line 71 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\SalesInvoice\InvoiceListOfDealers.cshtml"
                                                                               Write(item.salesInvoiceMaster?.TAXOnTotal?.ToString("0,0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(3597, 92, true);
            WriteLiteral("</td>\r\n                                            <td width=\"10%\" style=\"text-align:right\">");
            EndContext();
            BeginContext(3690, 53, false);
#line 72 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\SalesInvoice\InvoiceListOfDealers.cshtml"
                                                                                Write(item.salesInvoiceMaster?.NetTotal?.ToString("0,0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(3743, 140, true);
            WriteLiteral("</td>\r\n                                            <td width=\"15%\">\r\n                                                <a class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3883, "\"", 3958, 2);
            WriteAttributeValue("", 3890, "/FAMSDEALER/SalesInvoice/DealerSales?id=", 3890, 40, true);
#line 74 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\SalesInvoice\InvoiceListOfDealers.cshtml"
WriteAttributeValue("", 3930, item.salesInvoiceMaster?.Id, 3930, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3959, 128, true);
            WriteLiteral(" title=\"Invoice Edit\"><i class=\"fa fa-edit\"></i></a>\r\n                                                <a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4087, "\"", 4165, 2);
            WriteAttributeValue("", 4094, "/FAMSDEALER/SalesInvoice/InvoiceDetails?id=", 4094, 43, true);
#line 75 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\SalesInvoice\InvoiceListOfDealers.cshtml"
WriteAttributeValue("", 4137, item.salesInvoiceMaster?.Id, 4137, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4166, 147, true);
            WriteLiteral(" target=\"_blank\" title=\"Details\"><i class=\"fas fa-info-circle\"></i></a>\r\n                                                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4313, "\"", 4393, 2);
            WriteAttributeValue("", 4320, "/FAMSDEALER/SalesInvoice/InvoicePDFAction?id=", 4320, 45, true);
#line 76 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\SalesInvoice\InvoiceListOfDealers.cshtml"
WriteAttributeValue("", 4365, item.salesInvoiceMaster?.Id, 4365, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4394, 163, true);
            WriteLiteral(" target=\"_blank\" title=\"Report\"><i class=\"fa fa-print\"></i></a>\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 79 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\SalesInvoice\InvoiceListOfDealers.cshtml"
                                        i++;
                                    }

#line default
#line hidden
            BeginContext(4677, 182, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4876, 758, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#tblInvoiceList').DataTable();
            var table = $('#tblInvoiceList').DataTable();

            $('#tblInvoiceList tbody').on('click', 'tr', function () {
                var data = table.row(this).data();
                var iddata = data[1];
                let id = iddata.replace('<span style=""display:none"">', """").replace(""</span>"", """");
                var vid = parseInt(id.split('-')[1]);
                window.location.href = ""/Sales/SalesInvoice/InvoiceDetails/?id="" + vid;
            });
            $('#tblInvoiceList tbody').on('click', 'td:last-child', function (e) {
                e.stopPropagation();
            });
        });

    </script>
");
                EndContext();
            }
            );
            BeginContext(5637, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FADMS.Areas.FAMSDEALER.Models.SalesInvoiceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591