#pragma checksum "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b214c26910bccc00d014ed7c6c8faf88d4769432"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_FAMSDEALER_Views_Report_GetDealerSales), @"mvc.1.0.view", @"/Areas/FAMSDEALER/Views/Report/GetDealerSales.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/FAMSDEALER/Views/Report/GetDealerSales.cshtml", typeof(AspNetCore.Areas_FAMSDEALER_Views_Report_GetDealerSales))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b214c26910bccc00d014ed7c6c8faf88d4769432", @"/Areas/FAMSDEALER/Views/Report/GetDealerSales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d6da59ad1f56a285e9f316e27282c43cacd5d73", @"/Areas/FAMSDEALER/Views/_ViewImports.cshtml")]
    public class Areas_FAMSDEALER_Views_Report_GetDealerSales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FADMS.Areas.FAMSDEALER.Models.DealerReportViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Special branch.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("OPUS ERP"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:80px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
  
    ViewData["Title"] = "Sales Report";
    Layout = "~/Views/Shared/_PrintView.cshtml";

#line default
#line hidden
            BeginContext(158, 1527, true);
            WriteLiteral(@"<style>
    .table-bordered {
        border-collapse: collapse !important;
    }

        .table-bordered th {
            border: 1px solid gray !important;
        }

        .table-bordered td {
            border: 1px solid gray !important;
        }

    h5 {
        color: black;
    }

    .hm-gradient {
        background-image: linear-gradient(to top, #f3e7e9 0%, #e3eeff 99%, #e3eeff 100%);
    }

    .darken-grey-text {
        color: #2E2E2E;
    }

    .input-group.md-form.form-sm.form-2 input {
        border: 1px solid #bdbdbd;
        border-top-left-radius: 0.25rem;
        border-bottom-left-radius: 0.25rem;
    }

        .input-group.md-form.form-sm.form-2 input.purple-border {
            border: 1px solid #9e9e9e;
        }

        .input-group.md-form.form-sm.form-2 input[type=text]:focus:not([readonly]).purple-border {
            border: 1px solid #ba68c8;
            box-shadow: none;
        }

    .form-2 .input-group-addon {
        border");
            WriteLiteral(@": 1px solid #ba68c8;
    }

    .danger-text {
        color: #ff3547;
    }

    .success-text {
        color: #00C851;
    }

    .table-bordered.red-border, .table-bordered.red-border th, .table-bordered.red-border td {
        border: 1px solid #ff3547 !important;
    }

    .table.table-bordered th {
        text-align: center;
    }
</style>

<div>
    <div class=""container-fluid"">
        <div class=""fa-pull-right"">
            <p style=""font-size:smaller;"">Print at: ");
            EndContext();
            BeginContext(1686, 45, false);
#line 70 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                               Write(DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(1731, 58, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"fa-pull-left\">\r\n");
            EndContext();
            BeginContext(1862, 223, true);
            WriteLiteral("        </div>\r\n        <div class=\"row\" style=\"padding-top:0px;\">\r\n            <div class=\"col-1\"></div>\r\n            <div class=\"col-10\">\r\n                <div style=\"color:black;text-align:center;\">\r\n                    ");
            EndContext();
            BeginContext(2085, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b214c26910bccc00d014ed7c6c8faf88d47694327435", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2162, 57, true);
            WriteLiteral("\r\n                    <h3>Fair and Arms Management System");
            EndContext();
            BeginContext(2249, 115, true);
            WriteLiteral("</h3>\r\n                    <label>\r\n                        215, Shaheed Syed Nazrul Islam Sarani Dhaka, Bangladesh");
            EndContext();
            BeginContext(2394, 97, true);
            WriteLiteral("\r\n                    </label> <br />\r\n                    <label>Telephone Number:+88 02 9553587");
            EndContext();
            BeginContext(2525, 102, true);
            WriteLiteral("</label>\r\n                    <h5>Dealer Purchase & Sales Report</h5>\r\n                    <h5>From : ");
            EndContext();
            BeginContext(2628, 40, false);
#line 86 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                          Write(Model.fromDdate?.ToString("dd-MMM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2668, 6, true);
            WriteLiteral(" To : ");
            EndContext();
            BeginContext(2675, 37, false);
#line 86 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                                         Write(Model.toDate?.ToString("dd-MMM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2712, 624, true);
            WriteLiteral(@"</h5>
                    <br />
                </div>
            </div>
            <div class=""col-1""></div>
        </div>
    </div>
    <hr style=""border:1px solid black;"">

    <div class=""col-md-12"">
        <div class=""block-content tab-content overflow-hidden"">
            <div class=""tab-pane fade fade-left active show"" id=""profile-info"" role=""tabpanel"">
                <div class=""block-content"">
                    <div class=""block block-rounded block-fx-shadow"">
                        <div class=""block-content"">
                            <div class=""table-responsive table-rounded"">
");
            EndContext();
            BeginContext(3399, 39, true);
            WriteLiteral("                                <div>\r\n");
            EndContext();
#line 107 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                     if (Model.salesInvoiceDetailReport != null)
                                    {

#line default
#line hidden
            BeginContext(3761, 974, true);
            WriteLiteral(@"                                        <table class=""table table-striped table-bordered"" id=""voucherList"">
                                            <thead>
                                                <tr>
                                                    <th>SL</th>
                                                    <th>ডিলারের নাম</th>
                                                    <th>আইটেমের নাম</th>
                                                    <th>চালান তারিখ</th>
                                                    <th>চালান নাম্বার</th>
                                                    <th>আগ্নেয়াস্ত্রের ধরন</th>
                                                    <th>লাইসেন্সে নাম্বার</th>
                                                    <th>নিট টোটাল</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
            EndContext();
#line 123 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                  
                                                    var gunDeopIndex = 1;
                                                    

#line default
#line hidden
#line 125 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                     foreach (var item in Model.salesInvoiceDetailReport)
                                                    {

#line default
#line hidden
            BeginContext(5024, 126, true);
            WriteLiteral("                                                        <tr>\r\n                                                            <td>");
            EndContext();
            BeginContext(5151, 12, false);
#line 128 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                           Write(gunDeopIndex);

#line default
#line hidden
            EndContext();
            BeginContext(5163, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(5235, 15, false);
#line 129 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                           Write(item.dealerName);

#line default
#line hidden
            EndContext();
            BeginContext(5250, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(5322, 13, false);
#line 130 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                           Write(item.itemName);

#line default
#line hidden
            EndContext();
            BeginContext(5335, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(5407, 16, false);
#line 131 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                           Write(item.invoiceDate);

#line default
#line hidden
            EndContext();
            BeginContext(5423, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(5495, 18, false);
#line 132 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                           Write(item.invoiceNumber);

#line default
#line hidden
            EndContext();
            BeginContext(5513, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(5585, 13, false);
#line 133 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                           Write(item.armsType);

#line default
#line hidden
            EndContext();
            BeginContext(5598, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(5670, 18, false);
#line 134 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                           Write(item.licenseNumber);

#line default
#line hidden
            EndContext();
            BeginContext(5688, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(5760, 13, false);
#line 135 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                           Write(item.netTotal);

#line default
#line hidden
            EndContext();
            BeginContext(5773, 72, true);
            WriteLiteral("</td>\r\n\r\n                                                        </tr>\r\n");
            EndContext();
#line 138 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                        gunDeopIndex++;
                                                    }

#line default
#line hidden
            BeginContext(6024, 54, true);
            WriteLiteral("                                            </tbody>\r\n");
            EndContext();
#line 142 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                             if (Model.salesInvoiceDetailReport.Count() <= 0)
                                            {

#line default
#line hidden
            BeginContext(6220, 244, true);
            WriteLiteral("                                                <tfoot>\r\n                                                    <tr><td colspan=\"8\" class=\"text-center\">কোন  ডাটা পাওয়া যায় নি !!</td></tr>\r\n                                                </tfoot>\r\n");
            EndContext();
#line 147 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                            }

#line default
#line hidden
            BeginContext(6511, 50, true);
            WriteLiteral("                                        </table>\r\n");
            EndContext();
#line 149 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                    }

#line default
#line hidden
            BeginContext(6600, 36, true);
            WriteLiteral("                                    ");
            EndContext();
#line 150 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                     if (Model.purchaseDetailReport != null)
                                    {

#line default
#line hidden
            BeginContext(6717, 805, true);
            WriteLiteral(@"                                        <table class=""table table-striped table-bordered"" id=""voucherList"">
                                            <thead>
                                                <tr>
                                                    <th>SL</th>
                                                    <th>Supplier Name</th>
                                                    <th>Po Number</th>
                                                    <th>Lc Date</th>
                                                    <th>Arms Type</th>
                                                    <th>Net Total</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
            EndContext();
#line 164 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                  
                                                    var i = 1;
                                                    

#line default
#line hidden
#line 166 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                     foreach (var item in Model.purchaseDetailReport)
                                                    {

#line default
#line hidden
            BeginContext(7796, 126, true);
            WriteLiteral("                                                        <tr>\r\n                                                            <td>");
            EndContext();
            BeginContext(7923, 1, false);
#line 169 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(7924, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(7996, 17, false);
#line 170 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                           Write(item.supplierName);

#line default
#line hidden
            EndContext();
            BeginContext(8013, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(8085, 9, false);
#line 171 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                           Write(item.poNo);

#line default
#line hidden
            EndContext();
            BeginContext(8094, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(8166, 11, false);
#line 172 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                           Write(item.lcDate);

#line default
#line hidden
            EndContext();
            BeginContext(8177, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(8249, 13, false);
#line 173 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                           Write(item.armsType);

#line default
#line hidden
            EndContext();
            BeginContext(8262, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(8334, 13, false);
#line 174 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                           Write(item.netTotal);

#line default
#line hidden
            EndContext();
            BeginContext(8347, 72, true);
            WriteLiteral("</td>\r\n\r\n                                                        </tr>\r\n");
            EndContext();
#line 177 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                                        i++;
                                                    }

#line default
#line hidden
            BeginContext(8587, 54, true);
            WriteLiteral("                                            </tbody>\r\n");
            EndContext();
#line 181 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                             if (Model.purchaseDetailReport.Count() <= 0)
                                            {

#line default
#line hidden
            BeginContext(8779, 245, true);
            WriteLiteral("                                                <tfoot>\r\n                                                    <tr><td colspan=\"8\" class=\"text-center\">There are no data found !!</td></tr>\r\n                                                </tfoot>\r\n");
            EndContext();
#line 186 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                            }

#line default
#line hidden
            BeginContext(9071, 50, true);
            WriteLiteral("                                        </table>\r\n");
            EndContext();
#line 188 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\Report\GetDealerSales.cshtml"
                                    }

#line default
#line hidden
            BeginContext(9160, 222, true);
            WriteLiteral("                                </div>\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FADMS.Areas.FAMSDEALER.Models.DealerReportViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591