#pragma checksum "C:\Users\TylerN\Coding\BankAccount\Views\Home\UserHome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ef755da3de94aced9ac4de485033b51d37848fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserHome), @"mvc.1.0.view", @"/Views/Home/UserHome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserHome.cshtml", typeof(AspNetCore.Views_Home_UserHome))]
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
#line 1 "C:\Users\TylerN\Coding\BankAccount\Views\_ViewImports.cshtml"
using BankAccount;

#line default
#line hidden
#line 2 "C:\Users\TylerN\Coding\BankAccount\Views\_ViewImports.cshtml"
using BankAccount.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ef755da3de94aced9ac4de485033b51d37848fc", @"/Views/Home/UserHome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b20f887a8df0d276701ac0f260ce405b9af56dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserHome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Transaction.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 39, true);
            WriteLiteral("<div class=\"jumbotron\">\r\n    <h1>Hello ");
            EndContext();
            BeginContext(53, 15, false);
#line 3 "C:\Users\TylerN\Coding\BankAccount\Views\Home\UserHome.cshtml"
         Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(68, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(70, 14, false);
#line 3 "C:\Users\TylerN\Coding\BankAccount\Views\Home\UserHome.cshtml"
                          Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(84, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 4 "C:\Users\TylerN\Coding\BankAccount\Views\Home\UserHome.cshtml"
      decimal sum = 0;

#line default
#line hidden
            BeginContext(116, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 5 "C:\Users\TylerN\Coding\BankAccount\Views\Home\UserHome.cshtml"
     foreach (var i in Model.Histories)
    {   
        sum += i.Amount;
    }

#line default
#line hidden
            BeginContext(200, 20, true);
            WriteLiteral("    <h3>Balanace: $ ");
            EndContext();
            BeginContext(221, 3, false);
#line 9 "C:\Users\TylerN\Coding\BankAccount\Views\Home\UserHome.cshtml"
               Write(sum);

#line default
#line hidden
            EndContext();
            BeginContext(224, 21, true);
            WriteLiteral("</h3>\r\n    <p>count: ");
            EndContext();
            BeginContext(246, 21, false);
#line 10 "C:\Users\TylerN\Coding\BankAccount\Views\Home\UserHome.cshtml"
         Write(Model.Histories.Count);

#line default
#line hidden
            EndContext();
            BeginContext(267, 54, true);
            WriteLiteral("</p>\r\n    <p><a href=\"logout\">Logout</a></p>\r\n</div>\r\n");
            EndContext();
            BeginContext(321, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2ef755da3de94aced9ac4de485033b51d37848fc5355", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 13 "C:\Users\TylerN\Coding\BankAccount\Views\Home\UserHome.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new History(){UserId = @Model.UserId};

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(402, 174, true);
            WriteLiteral("</partial>\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>Amount</th>\r\n            <th>Date</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 22 "C:\Users\TylerN\Coding\BankAccount\Views\Home\UserHome.cshtml"
         foreach (var record in @Model.Histories)
        {

#line default
#line hidden
            BeginContext(638, 32, true);
            WriteLiteral("        <tr>\r\n            <td>$ ");
            EndContext();
            BeginContext(671, 13, false);
#line 25 "C:\Users\TylerN\Coding\BankAccount\Views\Home\UserHome.cshtml"
             Write(record.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(684, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(708, 11, false);
#line 26 "C:\Users\TylerN\Coding\BankAccount\Views\Home\UserHome.cshtml"
           Write(record.Date);

#line default
#line hidden
            EndContext();
            BeginContext(719, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 28 "C:\Users\TylerN\Coding\BankAccount\Views\Home\UserHome.cshtml"
        }

#line default
#line hidden
            BeginContext(752, 28, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
