#pragma checksum "TagHelpersInHelper.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "864bdf0afabc2aecf57904d5793a20bb6d12a6a3"
namespace TestOutput
{
    using Microsoft.AspNet.Razor.Runtime.TagHelpers;
    using System;
    using System.Threading.Tasks;

    public class TagHelpersInHelper
    {
public static Template 
#line 3 "TagHelpersInHelper.cshtml"
MyHelper(string val)
{

#line default
#line hidden
        return new Template((__razor_helper_writer) => {
#line 4 "TagHelpersInHelper.cshtml"
 

#line default
#line hidden

            Instrumentation.BeginContext(62, 19, true);
            WriteLiteralTo(__razor_helper_writer, "    <div>\r\n        ");
            Instrumentation.EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("mytaghelper", async() => {
                Instrumentation.BeginContext(184, 52, true);
                WriteLiteralTo(__razor_helper_writer, "\r\n            In None ContentBehavior.\r\n            ");
                Instrumentation.EndContext();
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nestedtaghelper", async() => {
                    Instrumentation.BeginContext(253, 37, true);
                    WriteLiteralTo(__razor_helper_writer, "Some buffered values with a value of ");
                    Instrumentation.EndContext();
                    Instrumentation.BeginContext(291, 3, false);
#line 8 "TagHelpersInHelper.cshtml"
                   WriteTo(__razor_helper_writer, val);

#line default
#line hidden
                    Instrumentation.EndContext();
                }
                , StartWritingScope, EndWritingScope);
                __NestedTagHelper = CreateTagHelper<NestedTagHelper>();
                __tagHelperExecutionContext.Add(__NestedTagHelper);
                __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
                WriteLiteralTo(__razor_helper_writer, __tagHelperExecutionContext.Output.GenerateStartTag());
                WriteLiteralTo(__razor_helper_writer, __tagHelperExecutionContext.Output.GeneratePreContent());
                if (__tagHelperExecutionContext.Output.ContentSet)
                {
                    WriteLiteralTo(__razor_helper_writer, __tagHelperExecutionContext.Output.GenerateContent());
                }
                else if (__tagHelperExecutionContext.ChildContentRetrieved)
                {
                    WriteLiteralTo(__razor_helper_writer, __tagHelperExecutionContext.Output.GetChildContentAsync().Result);
                }
                else
                {
                    __tagHelperExecutionContext.ExecuteChildContentAsync().Result;
                }
                WriteLiteralTo(__razor_helper_writer, __tagHelperExecutionContext.Output.GeneratePostContent());
                WriteLiteralTo(__razor_helper_writer, __tagHelperExecutionContext.Output.GenerateEndTag());
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                Instrumentation.BeginContext(312, 10, true);
                WriteLiteralTo(__razor_helper_writer, "\r\n        ");
                Instrumentation.EndContext();
            }
            , StartWritingScope, EndWritingScope);
            __MyTagHelper = CreateTagHelper<MyTagHelper>();
            __tagHelperExecutionContext.Add(__MyTagHelper);
            StartWritingScope();
            WriteLiteral("Current Time: ");
#line 6 "TagHelpersInHelper.cshtml"
Write(DateTime.Now);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWritingScope();
            __MyTagHelper.BoundProperty = __tagHelperStringValueBuffer.ToString();
            __tagHelperExecutionContext.AddTagHelperAttribute("BoundProperty", __MyTagHelper.BoundProperty);
            StartWritingScope();
            WriteLiteral("Current Time: ");
#line 6 "TagHelpersInHelper.cshtml"
Write(DateTime.Now);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWritingScope();
            __tagHelperExecutionContext.AddHtmlAttribute("unboundproperty", __tagHelperStringValueBuffer.ToString());
            __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
            WriteLiteralTo(__razor_helper_writer, __tagHelperExecutionContext.Output.GenerateStartTag());
            WriteLiteralTo(__razor_helper_writer, __tagHelperExecutionContext.Output.GeneratePreContent());
            if (__tagHelperExecutionContext.Output.ContentSet)
            {
                WriteLiteralTo(__razor_helper_writer, __tagHelperExecutionContext.Output.GenerateContent());
            }
            else if (__tagHelperExecutionContext.ChildContentRetrieved)
            {
                WriteLiteralTo(__razor_helper_writer, __tagHelperExecutionContext.Output.GetChildContentAsync().Result);
            }
            else
            {
                __tagHelperExecutionContext.ExecuteChildContentAsync().Result;
            }
            WriteLiteralTo(__razor_helper_writer, __tagHelperExecutionContext.Output.GeneratePostContent());
            WriteLiteralTo(__razor_helper_writer, __tagHelperExecutionContext.Output.GenerateEndTag());
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            Instrumentation.BeginContext(336, 14, true);
            WriteLiteralTo(__razor_helper_writer, "\r\n    </div>\r\n");
            Instrumentation.EndContext();
#line 11 "TagHelpersInHelper.cshtml"

#line default
#line hidden

        }
        );
#line 11 "TagHelpersInHelper.cshtml"
}

#line default
#line hidden

        #line hidden
        private System.IO.TextWriter __tagHelperStringValueBuffer = null;
        private TagHelperExecutionContext __tagHelperExecutionContext = null;
        private TagHelperRunner __tagHelperRunner = new TagHelperRunner();
        private TagHelperScopeManager __tagHelperScopeManager = new TagHelperScopeManager();
        private MyTagHelper __MyTagHelper = null;
        private NestedTagHelper __NestedTagHelper = null;
        #line hidden
        public TagHelpersInHelper()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            Instrumentation.BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            Instrumentation.EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("mytaghelper", async() => {
                Instrumentation.BeginContext(367, 9, false);
#line 12 "TagHelpersInHelper.cshtml"
Write(MyHelper(item => new Template((__razor_template_writer) => {
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nestedtaghelper", async() => {
        Instrumentation.BeginContext(394, 12, true);
        WriteLiteralTo(__razor_template_writer, "Custom Value");
        Instrumentation.EndContext();
    }
    , StartWritingScope, EndWritingScope);
    __NestedTagHelper = CreateTagHelper<NestedTagHelper>();
    __tagHelperExecutionContext.Add(__NestedTagHelper);
    __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
    WriteLiteralTo(__razor_template_writer, __tagHelperExecutionContext.Output.GenerateStartTag());
    WriteLiteralTo(__razor_template_writer, __tagHelperExecutionContext.Output.GeneratePreContent());
    if (__tagHelperExecutionContext.Output.ContentSet)
    {
        WriteLiteralTo(__razor_template_writer, __tagHelperExecutionContext.Output.GenerateContent());
    }
    else if (__tagHelperExecutionContext.ChildContentRetrieved)
    {
        WriteLiteralTo(__razor_template_writer, __tagHelperExecutionContext.Output.GetChildContentAsync().Result);
    }
    else
    {
        __tagHelperExecutionContext.ExecuteChildContentAsync().Result;
    }
    WriteLiteralTo(__razor_template_writer, __tagHelperExecutionContext.Output.GeneratePostContent());
    WriteLiteralTo(__razor_template_writer, __tagHelperExecutionContext.Output.GenerateEndTag());
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
}
)
));

#line default
#line hidden
                Instrumentation.EndContext();
            }
            , StartWritingScope, EndWritingScope);
            __MyTagHelper = CreateTagHelper<MyTagHelper>();
            __tagHelperExecutionContext.Add(__MyTagHelper);
            __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
            WriteLiteral(__tagHelperExecutionContext.Output.GenerateStartTag());
            WriteLiteral(__tagHelperExecutionContext.Output.GeneratePreContent());
            if (__tagHelperExecutionContext.Output.ContentSet)
            {
                WriteLiteral(__tagHelperExecutionContext.Output.GenerateContent());
            }
            else if (__tagHelperExecutionContext.ChildContentRetrieved)
            {
                WriteLiteral(__tagHelperExecutionContext.Output.GetChildContentAsync().Result);
            }
            else
            {
                __tagHelperExecutionContext.ExecuteChildContentAsync().Result;
            }
            WriteLiteral(__tagHelperExecutionContext.Output.GeneratePostContent());
            WriteLiteral(__tagHelperExecutionContext.Output.GenerateEndTag());
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            Instrumentation.BeginContext(439, 2, true);
            WriteLiteral("\r\n");
            Instrumentation.EndContext();
        }
        #pragma warning restore 1998
    }
}
