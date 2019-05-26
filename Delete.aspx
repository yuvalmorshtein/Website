<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="delete.aspx.cs" Inherits="Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"> 
   <% if (Request.Form["Delete"] == null)
      {
          Response.Write("<div>Deleting form:</div> <br />");
          Response.Write(" <form id=\"simpleEdit\" action=\"Delete.aspx\" method=\"post\">");
          Response.Write("Insert your Username:");
          Response.Write("<input type='text' name='user' id=\"user\" value ='"+Request.QueryString["username"]+"' /> <br />");
          Response.Write("<input type='submit' name='Delete' id=\"Delete\" value=\"Delete\" />");
          Response.Write("</form>");

      }
      else
          Response.Write(userMsg);
          %>
  
   
  
   
  

</asp:Content>

