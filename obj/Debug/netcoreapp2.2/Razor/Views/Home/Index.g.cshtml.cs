#pragma checksum "C:\Users\Babafemi\Documents\c#Workspace\invoice\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf237f5f419f5ec55a70f3cd2b19092a7620fbfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Babafemi\Documents\c#Workspace\invoice\Views\_ViewImports.cshtml"
using invoice;

#line default
#line hidden
#line 2 "C:\Users\Babafemi\Documents\c#Workspace\invoice\Views\_ViewImports.cshtml"
using invoice.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf237f5f419f5ec55a70f3cd2b19092a7620fbfd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d023a7be06e4e6cdde586b015b049239886d9d50", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Babafemi\Documents\c#Workspace\invoice\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout=null;

#line default
#line hidden
            BeginContext(63, 231, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<!--\r\nItem Name: Elisyam - Web App & Admin Dashboard Template\r\nVersion: 1.5\r\nAuthor: SAEROX\r\n\r\n** A license must be purchased in order to legally use this template for your project **\r\n-->\r\n<html lang=\"en\">\r\n    ");
            EndContext();
            BeginContext(294, 1624, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf237f5f419f5ec55a70f3cd2b19092a7620fbfd4348", async() => {
                BeginContext(300, 1611, true);
                WriteLiteral(@"
        <meta charset=""utf-8"">
        <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
        <title>Isiat - Login</title>
        <meta name=""description"" content=""Isiat is a Web App and Admin Dashboard Template built with Bootstrap 4"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
        <!-- Google Fonts -->
        <script src=""https://ajax.googleapis.com/ajax/libs/webfont/1.6.26/webfont.js""></script>
        <script>
          WebFont.load({
            google: {""families"":[""Montserrat:400,500,600,700"",""Noto+Sans:400,700""]},
            active: function() {
                sessionStorage.fonts = true;
            }
          });
        </script>
        <!-- Favicon -->
        <link rel=""apple-touch-icon"" sizes=""180x180"" href=""AppAsset/assets/img/apple-touch-icon.png"">
        <link rel=""icon"" type=""image/png"" sizes=""32x32"" href=""AppAsset/assets/img/favicon-32x32.png"">
        <link rel=""icon"" type=""image/png"" sizes=""16x16"" hr");
                WriteLiteral(@"ef=""AppAsset/assets/img/favicon-16x16.png"">
        <!-- Stylesheet -->
        <link rel=""stylesheet"" href=""AppAsset/assets/vendors/css/base/bootstrap.min.css"">
        <link rel=""stylesheet"" href=""AppAsset/assets/vendors/css/base/elisyam-1.5.min.css"">
        <link rel=""stylesheet"" href=""AppAsset/assets/css/animate/animate.min.css"">
        <!-- Tweaks for older IEs--><!--[if lt IE 9]>
        <script src=""https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js""></script>
        <script src=""https://oss.maxcdn.com/respond/1.4.2/respond.min.js""></script><![endif]-->
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1918, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1924, 7529, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf237f5f419f5ec55a70f3cd2b19092a7620fbfd7243", async() => {
                BeginContext(1947, 2468, true);
                WriteLiteral(@"
        <!-- Begin Preloader -->
        <div id=""preloader"">
            <div class=""canvas"">
                <img src=""AppAsset/assets/img/logo.png"" alt=""logo"" class=""loader-logo"">
                <div class=""spinner""></div>   
            </div>
        </div>
        <!-- End Preloader -->
        <!-- Begin Container -->
        <div class=""container-fluid no-padding h-100"">
            <div class=""row flex-row h-100 bg-white"">
                <!-- Begin Left Content -->
                <div class=""col-xl-3 col-lg-5 col-md-5 col-sm-12 col-12 no-padding"">
                    <div class=""elisyam-bg background-03"">
                        <div class=""elisyam-overlay overlay-08""></div>
                        <div class=""authentication-col-content-2 mx-auto text-center"">
                            <div class=""logo-centered"">
                                <a href=""#"">
                                    <img src=""AppAsset/assets/img/logo.png"" alt=""logo"">
                               ");
                WriteLiteral(@" </a>
                            </div>
                            <h1> Quick Invoice</h1>
                            <span class=""description"">
                               Maintain contacts, Managa Invoice, Generate Reports
                            </span>
                            <ul class=""login-nav nav nav-tabs mt-5 justify-content-center"" role=""tablist"" id=""animate-tab"">
                                <li><a class=""active"" data-toggle=""tab"" href=""#singin"" role=""tab"" id=""singin-tab"" data-easein=""zoomInUp"">Sign In</a></li>
                                <li><a data-toggle=""tab"" href=""#signup"" role=""tab"" id=""signup-tab"" data-easein=""zoomInRight"">Sign Up</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <!-- End Left Content -->
                <!-- Begin Right Content -->
                <div class=""col-xl-9 col-lg-7 col-md-7 col-sm-12 col-12 my-auto no-padding"">
                    <!-- B");
                WriteLiteral(@"egin Form -->
                    <div class=""authentication-form-2 mx-auto"">
                        <div class=""tab-content"" id=""animate-tab-content"">
                            <!-- Begin Sign In -->
                            <div role=""tabpanel"" class=""tab-pane show active"" id=""singin"" aria-labelledby=""singin-tab"">
                                <h3>Sign In To Isiat</h3>
                                ");
                EndContext();
                BeginContext(4415, 662, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf237f5f419f5ec55a70f3cd2b19092a7620fbfd10245", async() => {
                    BeginContext(4421, 649, true);
                    WriteLiteral(@"
                                    <div class=""group material-input"">
        							    <input type=""text"" required>
        							    <span class=""highlight""></span>
        							    <span class=""bar""></span>
        							    <label>Email</label>
                                    </div>
                                    <div class=""group material-input"">
        							    <input type=""password"" required>
        							    <span class=""highlight""></span>
        							    <span class=""bar""></span>
        							    <label>Password</label>
                                    </div>
                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5077, 821, true);
                WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col text-left"">
                                        <div class=""styled-checkbox"">
                                            <input type=""checkbox"" name=""checkbox"" id=""remeber"">
                                            <label for=""remeber"">Remember me</label>
                                        </div>
                                    </div>
                                    <div class=""col text-right"">
                                        <a href=""pages-forgot-password.html"">Forgot Password ?</a>
                                    </div>
                                </div>
                                <div class=""sign-btn text-center"">
                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5898, "\"", 5936, 1);
#line 111 "C:\Users\Babafemi\Documents\c#Workspace\invoice\Views\Home\Index.cshtml"
WriteAttributeValue("", 5905, Url.Action("Dashboard","Home"), 5905, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5937, 508, true);
                WriteLiteral(@" class=""btn btn-lg btn-gradient-01"">
                                        Sign In
                                    </a>
                                </div>
                            </div>
                            <!-- End Sign In -->
                            <!-- Begin Sign Up -->
                            <div role=""tabpanel"" class=""tab-pane"" id=""signup"" aria-labelledby=""signup-tab"">
                                <h3>Create An Account</h3>
                                ");
                EndContext();
                BeginContext(6445, 1233, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf237f5f419f5ec55a70f3cd2b19092a7620fbfd14235", async() => {
                    BeginContext(6451, 1220, true);
                    WriteLiteral(@"
                                    <div class=""group material-input"">
                                        <input type=""text"" required>
                                        <span class=""highlight""></span>
                                        <span class=""bar""></span>
                                        <label>Email</label>
                                    </div>
                                    <div class=""group material-input"">
                                        <input type=""password"" required>
                                        <span class=""highlight""></span>
                                        <span class=""bar""></span>
                                        <label>Password</label>
                                    </div>
                                    <div class=""group material-input"">
                                        <input type=""password"" required>
                                        <span class=""highlight""></span>
                    ");
                    WriteLiteral("                    <span class=\"bar\"></span>\r\n                                        <label>Confirm Password</label>\r\n                                    </div>\r\n                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7678, 641, true);
                WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col text-left"">
                                        <div class=""styled-checkbox"">
                                            <input type=""checkbox"" name=""checkbox"" id=""agree"">
                                            <label for=""agree"">I Accept <a href=""#"">Terms and Conditions</a></label>
                                        </div>
                                    </div>
                                </div>
                                <div class=""sign-btn text-center"">
                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 8319, "\"", 8357, 1);
#line 149 "C:\Users\Babafemi\Documents\c#Workspace\invoice\Views\Home\Index.cshtml"
WriteAttributeValue("", 8326, Url.Action("Dashboard","Home"), 8326, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8358, 1088, true);
                WriteLiteral(@" class=""btn btn-lg btn-gradient-01"">
                                        Sign Up
                                    </a>
                                </div>
                            </div>
                            <!-- End Sign Up -->
                        </div>
                    </div>
                    <!-- End Form -->                        
                </div>
                <!-- End Right Content -->
            </div>
            <!-- End Row -->
        </div>
        <!-- End Container -->    
        <!-- Begin Vendor Js -->
        <script src=""AppAsset/assets/vendors/js/base/jquery.min.js""></script>
        <script src=""AppAsset/assets/vendors/js/base/core.min.js""></script>
        <!-- End Vendor Js -->
        <!-- Begin Page Vendor Js -->
        <script src=""AppAsset/assets/vendors/js/app/app.min.js""></script>
        <!-- End Page Vendor Js -->
        <!-- Begin Page Snippets -->
        <script src=""AppAsset/assets/js/components/tabs/animated-");
                WriteLiteral("tabs.min.js\"></script>\r\n        <!-- End Page Snippets -->\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9453, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
