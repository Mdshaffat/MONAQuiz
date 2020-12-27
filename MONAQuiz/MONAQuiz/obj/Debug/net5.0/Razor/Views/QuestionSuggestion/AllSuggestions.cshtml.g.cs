#pragma checksum "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1415a26a41164edfc73b8afdbf73719af97c967"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuestionSuggestion_AllSuggestions), @"mvc.1.0.view", @"/Views/QuestionSuggestion/AllSuggestions.cshtml")]
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
#line 1 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\_ViewImports.cshtml"
using MONAQuiz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\_ViewImports.cshtml"
using MONAQuiz.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\_ViewImports.cshtml"
using MONAQuiz.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\_ViewImports.cshtml"
using MONAQuiz.Common.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1415a26a41164edfc73b8afdbf73719af97c967", @"/Views/QuestionSuggestion/AllSuggestions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"696d78649cae5d7e354910fe4b1dd8afd76b740a", @"/Views/_ViewImports.cshtml")]
    public class Views_QuestionSuggestion_AllSuggestions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MONAQuiz.Common.ViewModels.AllQuestionSuggestionsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApproveSuggestedQuestion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "QuestionSuggestion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Approve"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveSuggestedQuestion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Remove"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml"
  
    ViewData["Title"] = "AllSuggestions";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""mx-auto"">
            <div class=""mx-auto card-holder"">
                <div class=""quizCard text-center"" style=""width: 20em;"">
                    <p>There are no suggestions for approving.</p>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 18 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml"
     foreach (var question in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-6 mx-auto card-holder"">
            <div class=""suggestionsFlip-card"">
                <div class=""suggestionsFlip-card-inner"">
                    <div class=""suggestionsFlip-card-front"">
                        <h5 class=""text-left"">Suggestion ");
#nullable restore
#line 27 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml"
                                                    Write(question.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\n                        <h3 class=\"text-center\">");
#nullable restore
#line 28 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml"
                                           Write(question.Quiz.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                        <hr />\n                        <h5>");
#nullable restore
#line 30 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml"
                       Write(question.QuestionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                        <div");
            BeginWriteAttribute("class", " class=\"", 992, "\"", 1000, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            <h5>Option A: ");
#nullable restore
#line 32 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml"
                                     Write(question.FirstOption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                            <h5>Option B: ");
#nullable restore
#line 33 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml"
                                     Write(question.SecondOption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                            <h5>Option C: ");
#nullable restore
#line 34 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml"
                                     Write(question.ThirdOption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                            <h5>Option D: ");
#nullable restore
#line 35 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml"
                                     Write(question.FourthOption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                            <br />\n                            <h4>Correct Answer: ");
#nullable restore
#line 37 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml"
                                           Write(question.CorrectAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                        </div>\n                    </div>\n                    <div class=\"suggestionsFlip-card-back\">\n                        <div style=\"margin-top: 150px;\">\n                            <h5>Suggested by ");
#nullable restore
#line 42 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml"
                                        Write(question.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" on ");
#nullable restore
#line 42 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml"
                                                                   Write(question.SuggestedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                            <br />\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1415a26a41164edfc73b8afdbf73719af97c96710499", async() => {
                WriteLiteral("<i class=\"icon fas fa-check fa-2x\" style=\"color: white\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml"
                                                                                                                                  WriteLiteral(question.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 45 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml"
                             if (User.IsInRole("Admin"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1415a26a41164edfc73b8afdbf73719af97c96713483", async() => {
                WriteLiteral("<i class=\"icon fas fa-trash fa-2x\" style=\"color: white\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml"
                                                                                                                                     WriteLiteral(question.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 48 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 54 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "P:\ProjectQuiz\MONAQuiz\MONAQuiz\Views\QuestionSuggestion\AllSuggestions.cshtml"
     
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MONAQuiz.Common.ViewModels.AllQuestionSuggestionsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
