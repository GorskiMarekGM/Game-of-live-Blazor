#pragma checksum "C:\Marek\WSB\blazorserver01\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19529b93c1b0431c4fa0f2cad08e695ceae6025d"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorserver01.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Marek\WSB\blazorserver01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Marek\WSB\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Marek\WSB\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Marek\WSB\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Marek\WSB\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Marek\WSB\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Marek\WSB\blazorserver01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Marek\WSB\blazorserver01\_Imports.razor"
using blazorserver01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Marek\WSB\blazorserver01\_Imports.razor"
using blazorserver01.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Game of Live</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " and current radio ");
            __builder.AddContent(5, 
#nullable restore
#line 5 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                                                   theRadio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n<hr>\r\n");
#nullable restore
#line 7 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
  
    //initial pattern
    //dotnet watch run
    if(currentCount == 0){
        e.put_pattern(6,6,"pentadecathlon");
    }
    int svgh = e.total_of_rows()*9+2;
    int svgw = e.total_of_cols()*9+2;


#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "svg");
            __builder.AddAttribute(8, "width", 
#nullable restore
#line 17 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
             svgw

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "height", 
#nullable restore
#line 17 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                            svgh

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 18 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
     for(var i=0; i< @e.total_of_rows(); i++){
        for(var j=0; j< @e.total_of_cols();j++){
            int cy = (i*9+4+1);
            int cx = (j*9+4+1);
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
             if(e.biounit(i,j)!=null){

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "circle");
            __builder.AddAttribute(13, "cx", 
#nullable restore
#line 23 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                             cx

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "cy", 
#nullable restore
#line 23 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                                      cy

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "r", "4");
            __builder.AddAttribute(16, "fill", "#90FA90");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 24 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
            }else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                ");
            __builder.OpenElement(19, "circle");
            __builder.AddAttribute(20, "cx", 
#nullable restore
#line 25 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                             cx

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "cy", 
#nullable restore
#line 25 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                                      cy

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "r", "4");
            __builder.AddAttribute(23, "fill", "#909090");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 26 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
             
        }
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.OpenElement(26, "p");
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "radio");
            __builder.AddAttribute(30, "name", "myradiobtn");
            __builder.AddAttribute(31, "checked", 
#nullable restore
#line 46 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                   theRadio.Equals("step")

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "value", "step");
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 48 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                   ClickRadio

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(34, " Step by step\r\n\r\n    ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "type", "radio");
            __builder.AddAttribute(37, "name", "myradiobtn");
            __builder.AddAttribute(38, "checked", 
#nullable restore
#line 51 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                   theRadio.Equals("many")

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(39, "value", "many");
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 53 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                   ClickRadio

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(41, " Several steps\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "style", "display:" + (
#nullable restore
#line 56 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                      theRadio.Equals("many")?"":"none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.AddMarkupContent(46, "<h5>Cycles specification</h5>\r\n    Number of Cycles\r\n    ");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                  cyclesPerTime

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cyclesPerTime = __value, cyclesPerTime));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(50, " (internal value: ");
            __builder.AddContent(51, 
#nullable restore
#line 59 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                                                     cyclesPerTime

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(52, "))\r\n    <br>\r\n    ");
            __builder.OpenElement(53, "select");
            __builder.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                   option

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => option = __value, option));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "option");
            __builder.AddAttribute(58, "value", "1");
            __builder.AddContent(59, "1 st ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.OpenElement(61, "option");
            __builder.AddAttribute(62, "value", "2");
            __builder.AddContent(63, "2 st ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.OpenElement(65, "option");
            __builder.AddAttribute(66, "value", "3");
            __builder.AddContent(67, "3 st ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n    <br>\r\n    Our option is ");
            __builder.AddContent(70, 
#nullable restore
#line 67 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                   option

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(71, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n<hr>\r\n");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "class", "btn btn-primary");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(76, "Next");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
            __builder.OpenElement(78, "button");
            __builder.AddAttribute(79, "class", "btn btn-primary");
            __builder.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                                          PatternManagement

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(81, 
#nullable restore
#line 71 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                                                              title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n");
            __builder.AddMarkupContent(83, "<a class=\"btn btn-primary\" href=\"https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life\" target=\"_blank\">\r\n    Look for Patterns in Wikipedia\r\n\r\n</a>\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "PentaPatt");
            __builder.AddAttribute(86, "style", "display:" + " " + (
#nullable restore
#line 81 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                                         pentaDisplay

#line default
#line hidden
#nullable disable
            ) + ";" + " width:" + " 45em;" + " height:3em;" + " border:" + " 1px" + " solid" + " #000;" + " margin-bottom:" + " 10px;" + " text-align:center;" + " padding:5px;");
            __builder.AddMarkupContent(87, "\r\n    row ");
            __builder.OpenElement(88, "input");
            __builder.AddAttribute(89, "type", "text");
            __builder.AddAttribute(90, "style", "width: 10em;");
            __builder.AddAttribute(91, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 82 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                                                       xVal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => xVal = __value, xVal));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n    col ");
            __builder.OpenElement(94, "input");
            __builder.AddAttribute(95, "type", "text");
            __builder.AddAttribute(96, "style", "width: 10em;");
            __builder.AddAttribute(97, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                                                       yVal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(98, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => yVal = __value, yVal));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n    \r\n    ");
            __builder.OpenElement(100, "select");
            __builder.AddAttribute(101, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 85 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                   patternName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => patternName = __value, patternName));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(103, "\r\n        ");
            __builder.OpenElement(104, "option");
            __builder.AddAttribute(105, "value", "pentadecathlon");
            __builder.AddContent(106, "pentadecathlon ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n        ");
            __builder.OpenElement(108, "option");
            __builder.AddAttribute(109, "value", "mypattern");
            __builder.AddContent(110, "mypattern");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n        ");
            __builder.OpenElement(112, "option");
            __builder.AddAttribute(113, "value", "LWSS");
            __builder.AddContent(114, "LWSS ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n\r\n    ");
            __builder.OpenElement(117, "button");
            __builder.AddAttribute(118, "class", "btn btn-primary");
            __builder.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
                                              AddPattern

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(120, "Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "C:\Marek\WSB\blazorserver01\Pages\Counter.razor"
       
    private int currentCount = 0;
    private Data.BioUnit u;
    private Data.Environment e = new Data.Environment(30,30);
    private string theRadio ="";
    private int cyclesPerTime = 0;
    private string option = "";
    private string title = "Add pattern...";
    private string pentaDisplay ="none";
    private int xVal;
    private int yVal;
    private string patternName ="";



    private void IncrementCount()
    {
        currentCount++;
        e.nextConwayStep();
    }

    private void ClickRadio(ChangeEventArgs args){
        theRadio = args.Value.ToString();
        currentCount++;
    }

    private void PatternManagement(){
        if(title=="Add pattern..."){
            pentaDisplay ="block";
            title = "Add pattern(-)";
        }else{
            pentaDisplay="none";
            title="Add pattern...";
        }
    }

    private void AddPattern(){
        e.put_pattern(xVal,yVal,patternName);
        xVal=0;
        yVal=0;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
