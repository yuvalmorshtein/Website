<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="update.aspx.cs" Inherits="update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <% 
        if (Request.Form["update"] == null)
        {
            Response.Write("<div>Password updating:</div><br />");
            Response.Write("<form id=\"simpleEdit\" action=\"Update.aspx\" method=\"post\">");
            Response.Write("Insert the Username:");
            Response.Write("<input type='text' name='username' value=\"" + Request.QueryString["username"] + "\"/>");
            Response.Write("<br />");
            Response.Write("Insert the new first name:");
            Response.Write("<input type='text' name='fnameedit'/>");
            Response.Write("<br />");
            Response.Write("Insert the new last name:");
            Response.Write("<input type='text' name='lnameedit'/>");
            Response.Write("<br />");
            Response.Write("Insert the new age:");
            Response.Write("<input type='text' name='ageedit' />");
            Response.Write("<br />");
            Response.Write("<input type='submit' name='update' id=\"update\" value=\"update\" />");
            Response.Write("</form>");
        }
        else
            Response.Write(userMsg);
        %>
</asp:Content>

