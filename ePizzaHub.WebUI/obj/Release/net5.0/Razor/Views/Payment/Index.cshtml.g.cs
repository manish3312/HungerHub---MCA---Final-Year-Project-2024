#pragma checksum "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f5a0bc06544f0907569a7cf3b2803a5e2a12ee6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Index), @"mvc.1.0.view", @"/Views/Payment/Index.cshtml")]
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
#line 1 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\_ViewImports.cshtml"
using ePizzaHub.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\_ViewImports.cshtml"
using ePizzaHub.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\_ViewImports.cshtml"
using ePizzaHub.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\_ViewImports.cshtml"
using ePizzaHub.WebUI.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f5a0bc06544f0907569a7cf3b2803a5e2a12ee6", @"/Views/Payment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f6c2151b50d34e51dad0fb018e547f0aab3d83d", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_Index : ePizzaHub.WebUI.Helpers.BaseViewPage<PaymentModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
  
    ViewData["Title"] = "Payment | ePizza Hub";
    Address address = TempData.Peek<Address>("Address");

#line default
#line hidden
#nullable disable
            WriteLiteral("<section>\r\n");
#nullable restore
#line 7 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row mt-3\">\r\n            <div class=\"col-lg-8\">\r\n                <div class=\"card mb-3\">\r\n                    <div class=\"col-sm-12\">\r\n                        <h5 class=\"mt-3\">Order Details <span class=\"float-right\"> Item(s): ");
#nullable restore
#line 13 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                                                                                      Write(Model.Cart.Items.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n                    </div>\r\n                    <hr />\r\n                    <div class=\"card-body pt-0 pb-0\">\r\n");
#nullable restore
#line 17 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                         foreach (var item in Model.Cart.Items)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""row"">
                                <div class=""col-md-5 col-lg-3 col-xl-3"">
                                    <div class=""rounded mb-3 mb-md-0"">
                                        <img class=""rounded w-100""");
            BeginWriteAttribute("src", "\r\n                                             src=\"", 924, "\"", 990, 1);
#nullable restore
#line 23 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
WriteAttributeValue("", 976, item.ImageUrl, 976, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Sample"">
                                    </div>
                                </div>
                                <div class=""col-md-7 col-lg-9 col-xl-9"">
                                    <div class=""d-flex justify-content-between"">
                                        <div>
                                            <h5>");
#nullable restore
#line 29 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <p class=\"mb-2 text-muted small\">Size: Regular</p>\r\n                                            <p class=\"mb-2 text-muted small\">\r\n                                                Unit Price: ₹");
#nullable restore
#line 32 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                                                        Write(item.UnitPrice.ToString("##.#"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </div>
                                        <div>
                                            <div class=""def-number-input number-input safari_only mb-0 w-100"">
                                                <div class=""input-group mb-3"">
                                                    <input class=""form-control sm-control"" size=""2"" min=""0"" name=""quantity""");
            BeginWriteAttribute("value", " value=\"", 2089, "\"", 2111, 1);
#nullable restore
#line 38 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
WriteAttributeValue("", 2097, item.Quantity, 2097, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly />
                                                </div>
                                            </div>
                                            <span id=""spanTotal"" class=""form-text text-muted text-center"">
                                                Total : ₹");
#nullable restore
#line 42 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                                                     Write((item.UnitPrice * @item.Quantity).ToString("##.#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </span>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 48 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                             if (Model.Cart.Items.IndexOf(item) < Model.Cart.Items.Count - 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <hr class=\"mb-4\">\r\n");
#nullable restore
#line 51 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <div class=""col-sm-12"">
                        <h5 class=""mt-2"">Delivery Address</h5>
                    </div>
                    <hr />
                    <div class=""card-body pb-0"">
                        <dl class=""row"">
                            <dt class=""col-sm-2"">
                                Street
                            </dt>
                            <dd class=""col-sm-4"">
                                ");
#nullable restore
#line 64 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                           Write(address.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                Locality\r\n                            </dt>\r\n                            <dd class=\"col-sm-4\">\r\n                                ");
#nullable restore
#line 70 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                           Write(address.Locality);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                Zip Code\r\n                            </dt>\r\n                            <dd class=\"col-sm-4\">\r\n                                ");
#nullable restore
#line 76 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                           Write(address.ZipCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-2\">\r\n                                Contact No.\r\n                            </dt>\r\n                            <dd class=\"col-sm-4\">\r\n                                ");
#nullable restore
#line 82 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                           Write(address.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </dd>
                        </dl>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""card mb-3"">
                    <div class=""col-sm-12"">
                        <h5 class=""mt-3"">Order Summary</h5>
                    </div>
                    <hr />
                    <div class=""card-body pt-0"">
                        <ul class=""list-group list-group-flush"">
                            <li class=""list-group-item d-flex justify-content-between align-items-center border-0 px-0"">
                                Amount
                                <span>₹");
#nullable restore
#line 98 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                                  Write(Model.Cart.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n                            <li class=\"list-group-item d-flex justify-content-between align-items-center border-0 px-0\">\r\n                                Tax (5%)\r\n                                <span>+₹");
#nullable restore
#line 102 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                                   Write(Model.Cart.Tax);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center  px-0 mb-3"">
                                <strong>Total Amount</strong>
                                <span><strong>₹");
#nullable restore
#line 106 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                                          Write(Model.Cart.GrandTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span>\r\n                            </li>\r\n                        </ul>\r\n");
#nullable restore
#line 109 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                         if (CurrentUser != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button id=\"rzp-button\" hidden>Pay</button>\r\n");
#nullable restore
#line 112 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                             using (Html.BeginForm("Status", "Payment", FormMethod.Post, new { id = "PaymentForm", name = "PaymentForm" }))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                           Write(Html.Hidden("Receipt", Model.Receipt));

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                                                                      ;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                           Write(Html.Hidden("Currency", "INR"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                                                               ;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                           Write(Html.Hidden("rzp_signature"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                           Write(Html.Hidden("rzp_paymentid"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                           Write(Html.Hidden("rzp_orderid"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"submit\" id=\"rzp-paymentresponse\" hidden style=\"display: none;\">Submit</button>\r\n");
#nullable restore
#line 121 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a href=\"#\" class=\"btn btn-primary btn-block\" onclick=\"submitToPayment()\">Pay Now</a>\r\n");
#nullable restore
#line 123 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 128 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n<script src=\"https://checkout.razorpay.com/v1/checkout.js\"></script>\r\n<script>\r\n    var options = {\r\n        \"key\": \"");
#nullable restore
#line 133 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
           Write(Model.RazorpayKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n        \"amount\": \"");
#nullable restore
#line 134 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
               Write(Model.GrandTotal*100);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n        \"currency\": \"");
#nullable restore
#line 135 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                Write(Model.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n        \"name\": \"");
#nullable restore
#line 136 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
            Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n        \"description\": \"");
#nullable restore
#line 137 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n        \"image\": \"https://www.dotnettricks.com/images/d-icon.png\",\r\n        //\"image\": \"/images/icon.png\",\r\n        \"order_id\": \"");
#nullable restore
#line 140 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                Write(Model.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
        ""handler"": function (response){
            document.getElementById('rzp_paymentid').value = response.razorpay_payment_id;
            document.getElementById('rzp_orderid').value = response.razorpay_order_id;
            $(""#rzp_signature"").val(response.razorpay_signature);
            $('#PaymentForm').submit();
        },
        ""prefill"": {
            ""name"": """);
#nullable restore
#line 148 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                Write(CurrentUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n            \"email\": \"");
#nullable restore
#line 149 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                 Write(CurrentUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n            \"contact\": \"");
#nullable restore
#line 150 "C:\Code\Weekdays\ePizzaHub\ePizzaHub.WebUI\Views\Payment\Index.cshtml"
                   Write(CurrentUser.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
        },
        ""notes"": {
            ""address"": ""NA""
        },
        ""theme"": {
            ""color"": ""#4285F4""
        }
    };
    var rzp = new Razorpay(options);

    window.onload = function(){
        document.getElementById('rzp-button').click();
    };

    document.getElementById('rzp-button').onclick = function (e) {
        rzp.open();
        e.preventDefault();
    };

    function submitToPayment() {
       rzp.open();
       e.preventDefault();
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaymentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
