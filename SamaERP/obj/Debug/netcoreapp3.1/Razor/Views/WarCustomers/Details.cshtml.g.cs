#pragma checksum "C:\Users\hp\Documents\SamaERP\SamaERP\Views\WarCustomers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20c3540637a5f4b86e118397bfceaacec4620804"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WarCustomers_Details), @"mvc.1.0.view", @"/Views/WarCustomers/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\hp\Documents\SamaERP\SamaERP\Views\_ViewImports.cshtml"
using SamaERP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Documents\SamaERP\SamaERP\Views\_ViewImports.cshtml"
using SamaERP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c3540637a5f4b86e118397bfceaacec4620804", @"/Views/WarCustomers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44153f8c27fb906c48d6d8ddf4fa17d626e0d761", @"/Views/_ViewImports.cshtml")]
    public class Views_WarCustomers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SamaERP.Models.WarCustomer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hp\Documents\SamaERP\SamaERP\Views\WarCustomers\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container body"">
    <div class=""main_container"">
        <div class=""right_col"" role=""main"">
            <div>
                <div class=""x_panel bg-transparent"">
                    <div class=""x_content"">
                        <div>
                            <h4>");
#nullable restore
#line 15 "C:\Users\hp\Documents\SamaERP\SamaERP\Views\WarCustomers\Details.cshtml"
                           Write(Html.DisplayFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                            <hr />
                            <dl class=""row"">
                                <dt class=""col-sm-2"">
                                    Customer Name
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 22 "C:\Users\hp\Documents\SamaERP\SamaERP\Views\WarCustomers\Details.cshtml"
                               Write(Html.DisplayFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </dd>
                                <dt class=""col-sm-2"">
                                    Customer Type
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 28 "C:\Users\hp\Documents\SamaERP\SamaERP\Views\WarCustomers\Details.cshtml"
                               Write(Html.DisplayFor(model => model.CustomerType));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </dd>
                                <dt class=""col-sm-2"">
                                    Customer Department
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 34 "C:\Users\hp\Documents\SamaERP\SamaERP\Views\WarCustomers\Details.cshtml"
                               Write(Html.DisplayFor(model => model.CustomerDepartment));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </dd>
                                <dt class=""col-sm-2"">
                                    Customer Description
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 40 "C:\Users\hp\Documents\SamaERP\SamaERP\Views\WarCustomers\Details.cshtml"
                               Write(Html.DisplayFor(model => model.CustomerDecription));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </dd>
                                <dt class=""col-sm-2"">
                                    Customer PhoneNo.
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 46 "C:\Users\hp\Documents\SamaERP\SamaERP\Views\WarCustomers\Details.cshtml"
                               Write(Html.DisplayFor(model => model.CustomerPhoneNo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </dd>
                                <dt class=""col-sm-2"">
                                    Customer Email
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 52 "C:\Users\hp\Documents\SamaERP\SamaERP\Views\WarCustomers\Details.cshtml"
                               Write(Html.DisplayFor(model => model.CustomerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </dd>
                                <dt class=""col-sm-2"">
                                    Customer Address
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 58 "C:\Users\hp\Documents\SamaERP\SamaERP\Views\WarCustomers\Details.cshtml"
                               Write(Html.DisplayFor(model => model.CustomerAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </dd>
                                <dt class=""col-sm-2"">
                                    Customer Country
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 64 "C:\Users\hp\Documents\SamaERP\SamaERP\Views\WarCustomers\Details.cshtml"
                               Write(Html.DisplayFor(model => model.CustomerCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </dd>
                                <dt class=""col-sm-2"">
                                    Customer City
                                </dt>
                                <dd class=""col-sm-10"">
                                    ");
#nullable restore
#line 70 "C:\Users\hp\Documents\SamaERP\SamaERP\Views\WarCustomers\Details.cshtml"
                               Write(Html.DisplayFor(model => model.CustomerCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                            </dl>\r\n                        </div>\r\n                        <div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20c3540637a5f4b86e118397bfceaacec46208049761", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\hp\Documents\SamaERP\SamaERP\Views\WarCustomers\Details.cshtml"
                                                   WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20c3540637a5f4b86e118397bfceaacec462080411943", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SamaERP.Models.WarCustomer> Html { get; private set; }
    }
}
#pragma warning restore 1591
