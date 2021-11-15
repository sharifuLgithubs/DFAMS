#pragma checksum "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\ItemInfo\ItemListByDealer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63afa8f9580c0276f64f8e0e84b2215c6c36de0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_FAMSDEALER_Views_ItemInfo_ItemListByDealer), @"mvc.1.0.view", @"/Areas/FAMSDEALER/Views/ItemInfo/ItemListByDealer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/FAMSDEALER/Views/ItemInfo/ItemListByDealer.cshtml", typeof(AspNetCore.Areas_FAMSDEALER_Views_ItemInfo_ItemListByDealer))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63afa8f9580c0276f64f8e0e84b2215c6c36de0a", @"/Areas/FAMSDEALER/Views/ItemInfo/ItemListByDealer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d6da59ad1f56a285e9f316e27282c43cacd5d73", @"/Areas/FAMSDEALER/Views/_ViewImports.cshtml")]
    public class Areas_FAMSDEALER_Views_ItemInfo_ItemListByDealer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FADMS.Areas.FAMSDEALER.Models.ItemViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\ItemInfo\ItemListByDealer.cshtml"
  
    ViewData["Title"] = "ItemListByDealer";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(151, 823, true);
            WriteLiteral(@"

<div class=""col-12 mt-3"">
    <div class=""card-header border"" style=""background-color:#F8F9FC;width:98%"">
        <h4 class=""m-0 font-weight-bold""> আগ্নেয়াস্ত্রের তালিকা </h4>
    </div>
</div>
<div class=""col-12"" style=""width:98%"">
    <div class=""card "">
        <div class=""card-body"">
            <table class=""table table-striped table-bordered table-sm"" id=""tblItem"">
                <thead>
                    <tr>
                        <th>সিরিয়াল নং </th>
                        <th>স্পেসিফিকেশন নাম </th>
                        <th>আগ্নেয়াস্ত্রের কোড</th>
                        <th>আগ্নেয়াস্ত্রের ধরন</th>
                        <th>আগ্নেয়াস্ত্রের মডেল</th>
                        <th>সম্পাদনা করুন </th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 28 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\ItemInfo\ItemListByDealer.cshtml"
                       int sl = 1;

#line default
#line hidden
            BeginContext(1011, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 29 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\ItemInfo\ItemListByDealer.cshtml"
                     foreach (var data in Model.itemSpecifications)
                    {

#line default
#line hidden
            BeginContext(1103, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1166, 2, false);
#line 32 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\ItemInfo\ItemListByDealer.cshtml"
                           Write(sl);

#line default
#line hidden
            EndContext();
            BeginContext(1168, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1208, 22, false);
#line 33 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\ItemInfo\ItemListByDealer.cshtml"
                           Write(data.specificationName);

#line default
#line hidden
            EndContext();
            BeginContext(1230, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1270, 13, false);
#line 34 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\ItemInfo\ItemListByDealer.cshtml"
                           Write(data.itemCode);

#line default
#line hidden
            EndContext();
            BeginContext(1283, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1323, 25, false);
#line 35 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\ItemInfo\ItemListByDealer.cshtml"
                           Write(data.ArmType?.ArmTypeName);

#line default
#line hidden
            EndContext();
            BeginContext(1348, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1388, 18, false);
#line 36 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\ItemInfo\ItemListByDealer.cshtml"
                           Write(data.costingMethod);

#line default
#line hidden
            EndContext();
            BeginContext(1406, 99, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                <a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1505, "\"", 1556, 2);
            WriteAttributeValue("", 1512, "/FAMSDEALER/ItemInfo/AddItem?itemid=", 1512, 36, true);
#line 38 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\ItemInfo\ItemListByDealer.cshtml"
WriteAttributeValue("", 1548, data.Id, 1548, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1557, 90, true);
            WriteLiteral("><i class=\"fa fa-edit\"></i></a>\r\n                                <a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1647, "\"", 1673, 3);
            WriteAttributeValue("", 1657, "Remove(", 1657, 7, true);
#line 39 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\ItemInfo\ItemListByDealer.cshtml"
WriteAttributeValue("", 1664, data.Id, 1664, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1672, ")", 1672, 1, true);
            EndWriteAttribute();
            BeginContext(1674, 113, true);
            WriteLiteral(" href=\"#\"><i class=\"fa fa-trash-alt\"></i></a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 42 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\ItemInfo\ItemListByDealer.cshtml"
                        sl++;
                    }

#line default
#line hidden
            BeginContext(1841, 84, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1942, 788, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#tblItem').DataTable();
        });

        function Edit(id, name, code, type, model, desc) {
            $('#itemId').val(id);
            $('#itemCode').val(code);
            $('#itemName').val(name);
            $('#armsTypeId').val(type);
            $('#costingMethod').val(model);
            $('#itemDescription').val(desc);
        }
        function Remove(id) {
             swal({
                title: 'Are you sure?', text: 'Do you want to delete this record!', type: 'warning', showCancelButton: true, confirmButtonColor: '#3085d6', cancelButtonColor: '#d33', confirmButtonText: 'Yes, delete it!'
            }).then(function () {
                $.ajax({
                    url: '");
                EndContext();
                BeginContext(2731, 37, false);
#line 68 "F:\ARIF\FAMS Dealer\Project\Fire_Arms_Dealer_Management_System\FAMS\Areas\FAMSDEALER\Views\ItemInfo\ItemListByDealer.cshtml"
                     Write(Url.Action("DeleteItems", "ItemInfo"));

#line default
#line hidden
                EndContext();
                BeginContext(2768, 517, true);
                WriteLiteral(@"',
                    data: { Id: id },
                    type: 'GET',
                })
                    .done(function (res) {
                        console.log(res);
                        swal('', 'Deleted Successfully!', 'success').then(function () {
                            location.reload();
                        })
					
                })
                .fail(function () {
					swal('', 'Unable to Delete!', 'warning');
                });
				});
        }
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FADMS.Areas.FAMSDEALER.Models.ItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591