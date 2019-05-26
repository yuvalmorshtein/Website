<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="insert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <%   
        if (Request.Form["submit"] == null)
        {
            Response.Write("<div>registration form:</div><br />");
            Response.Write(" <form runat='server' name=\"Uefa's Form\" id=\"Uefa's Form\" method=\"post\" action='register.aspx'>");
            Response.Write(" User name:<input type=\"text\" name=\"username\" id=\"username\" /><br />");
            Response.Write("First name:<input type=\"text\" name=\"fname\" id=\"fname\" /><br />");
            Response.Write("Last name:<input type=\"text\" name=\"lname\" id=\"lname\" /><br />");
            Response.Write("State:<input type=\"text\" name=\"state\" id=\"state\" /><br />");
            Response.Write("E-mail:<input type=\"text\" name=\"mail\" id=\"mail\" /><br />");
            Response.Write("Phone number:<input type=\"text\" name=\"pnum\" id=\"pnum\" /><br />");
            Response.Write("Age:<input type=\"number\" name=\"age\" id=\"age\" /><br />");
            Response.Write("Gender: male <input type=\"radio\" name=\"gender\" id=\"gender1\" value=\"male\" checked />");
            Response.Write("female<input type=\"radio\"name=\"gender\" id=\"gender2\" value=\"female\" /><br />");
            Response.Write("marital status:");
            Response.Write("<select name=\"mstatus\" id=\"mstatus\" size=\"1\">");
            Response.Write("<option value=\"single\" selected>single</option>");
            Response.Write("<option value=\"married\">married</option>");
            Response.Write("<option value=\"divorcee\">divorcee</option>");
            Response.Write("<option value=\"widower\">widower</option>");
            Response.Write("</select><br />");
            Response.Write(" password:<input type=\"password\" name=\"password\" id=\"password\" /><br />");
            Response.Write("Special requests:<br />");
            Response.Write("<textarea cols=\"50\" rows=\"5\" name=\"special\" id=\"special\"></textarea><br />");
            Response.Write(" <input type=\"submit\" name=\"submit\" id=\"submit\" value=\"submit\" />");
            Response.Write("<input type=\"reset\" value=\"reset\" /> </form>");
        } %>
    <h3><%=RegStatus %></h3>
</asp:Content>

