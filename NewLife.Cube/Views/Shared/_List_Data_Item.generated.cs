﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    
    #line 1 "..\..\Views\Shared\_List_Data_Item.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\_List_Data_Item.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Data_Item.cshtml")]
    public partial class _Views_Shared__List_Data_Item_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Data_Item_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\_List_Data_Item.cshtml"
  
    var pair = Model as Pair;
    var entity = pair.First as IEntity;
    var item = pair.Second as FieldItem;

    var value = entity[item.Name];

    // 第二名称，去掉后面的数字，便于模式匹配
    var name2 = item.Name;
    while (name2.Length > 1 && Char.IsDigit(name2[name2.Length - 1])) { name2 = name2.Substring(0, name2.Length - 1); }


            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 15 "..\..\Views\Shared\_List_Data_Item.cshtml"
 if (item.IsIdentity)
{

            
            #line default
            #line hidden
WriteLiteral("    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 17 "..\..\Views\Shared\_List_Data_Item.cshtml"
                       Write(value);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 18 "..\..\Views\Shared\_List_Data_Item.cshtml"
}
else
{
    switch (Type.GetTypeCode(item.Type))
    {
        case TypeCode.Boolean:
            if ((Boolean)value)
            {

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"glyphicon glyphicon-ok\"");

WriteLiteral(" style=\"color: green;\"");

WriteLiteral("></i>\r\n                </td>\r\n");

            
            #line 29 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"glyphicon glyphicon-remove\"");

WriteLiteral(" style=\"color: red;\"");

WriteLiteral("></i>\r\n                </td>\r\n");

            
            #line 35 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            break;
        case TypeCode.DateTime:
            var dt = (DateTime)value;
            if (name2.EndsWith("Date"))
            {

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 41 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                   Write(dt.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 42 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 45 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                   Write(dt.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 46 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            break;
        case TypeCode.Decimal:
            var dc = (Decimal)value;

            
            #line default
            #line hidden
WriteLiteral("            <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 50 "..\..\Views\Shared\_List_Data_Item.cshtml"
                              Write(dc.ToString("n2"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 51 "..\..\Views\Shared\_List_Data_Item.cshtml"
            break;
        case TypeCode.Single:
        case TypeCode.Double:
            if (name2.EndsWith("Rate"))
            {
                var dd = (Double)value;
                var des = item.Description + "";
                if (des.Contains("百分之一")) { dd /= 100; }
                if (des.Contains("万分之一")) { dd /= 10000; }


            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 61 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                   Write(dd.ToString("p2"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 62 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            else
            {
                var dd = (Double)value;

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 66 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                  Write(dd.ToString("n2"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 67 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            break;
        case TypeCode.Byte:
        case TypeCode.Int16:
        case TypeCode.Int32:
        case TypeCode.Int64:
        case TypeCode.UInt16:
        case TypeCode.UInt32:
        case TypeCode.UInt64:
            //特殊处理枚举
            if (item.Type.IsEnum)
            {
                var val = "";
                try
                {
                    val = System.EnumHelper.GetDescription((Enum)value) ?? value + "";
                }
                catch { }

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 85 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                   Write(val);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 86 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            else if (item.Name.EqualIgnoreCase("CreateUserID", "UpdateUserID"))
            {
                var provider = ViewData["Provider"] as IManageProvider;

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 90 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                   Write(provider.FindByID(value));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 91 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            else if (name2.EndsWith("Rate"))
            {
                var dd = (Double)value;
                var des = item.Description + "";
                if (des.Contains("百分之一")) { dd /= 100; }
                if (des.Contains("万分之一")) { dd /= 10000; }


            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 99 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                   Write(dd.ToString("p2"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 100 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 103 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                  Write(Convert.ToInt64(value).ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 104 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            break;
        case TypeCode.String:
        default:
            {
                var val = value;
                var map = item.Map;
                if (map != null && val + "" != "")
                {
                    if (map.Provider != null)
                    {
                        var dic = new RouteValueDictionary();
                        var key = map.Provider.Key;
                        if (!key.IsNullOrEmpty() && item.OriField != null) { dic[key] = entity[item.OriField.Name]; }

            
            #line default
            #line hidden
WriteLiteral("                        <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 118 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                           Write(Html.ActionLink(value + "", "Edit", map.Provider.EntityType.Name, dic, null));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 119 "..\..\Views\Shared\_List_Data_Item.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 122 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                           Write(value);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 123 "..\..\Views\Shared\_List_Data_Item.cshtml"
                    }
                }
                else if (item.Name.EqualIgnoreCase("CreateIP", "UpdateIP"))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteAttribute("title", Tuple.Create(" title=\"", 4326), Tuple.Create("\"", 4361)
            
            #line 127 "..\..\Views\Shared\_List_Data_Item.cshtml"
, Tuple.Create(Tuple.Create("", 4334), Tuple.Create<System.Object, System.Int32>((value+"").IPToAddress()
            
            #line default
            #line hidden
, 4334), false)
);

WriteLiteral(">");

            
            #line 127 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                                                           Write(value);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 128 "..\..\Views\Shared\_List_Data_Item.cshtml"
                }
                else if (item.Name.EqualIgnoreCase("Remark", "Description"))
                {
                    //防止内容过长

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" style=\"max-width:600px;overflow:hidden;white-space: nowrap;text-overflow: ellips" +
"is;\"");

WriteAttribute("title", Tuple.Create(" title=\"", 4630), Tuple.Create("\"", 4644)
            
            #line 132 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                    , Tuple.Create(Tuple.Create("", 4638), Tuple.Create<System.Object, System.Int32>(value
            
            #line default
            #line hidden
, 4638), false)
);

WriteLiteral(">");

            
            #line 132 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                                                                                                       Write(value);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 133 "..\..\Views\Shared\_List_Data_Item.cshtml"
                }
                else if (item.Length >= 500)
                {
                    //防止内容过长

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" style=\"max-width:400px;overflow:hidden;white-space: nowrap;text-overflow: ellips" +
"is;\"");

WriteAttribute("title", Tuple.Create(" title=\"", 4881), Tuple.Create("\"", 4895)
            
            #line 137 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                    , Tuple.Create(Tuple.Create("", 4889), Tuple.Create<System.Object, System.Int32>(value
            
            #line default
            #line hidden
, 4889), false)
);

WriteLiteral(">");

            
            #line 137 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                                                                                                       Write(value);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 138 "..\..\Views\Shared\_List_Data_Item.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td>");

            
            #line 141 "..\..\Views\Shared\_List_Data_Item.cshtml"
                   Write(value);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 142 "..\..\Views\Shared\_List_Data_Item.cshtml"
                }
            }
            break;
            
            
            #line default
            #line hidden
            
            #line 147 "..\..\Views\Shared\_List_Data_Item.cshtml"
                        
    }
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
