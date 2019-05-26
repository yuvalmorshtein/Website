<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="select.aspx.cs" Inherits="select" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <%  if (Request.Form["user"] == null && Request.Form["f"] == null && Request.Form["l"] == null)
        {
            Response.Write("<div>Selecting:</div><br />");
            Response.Write("<form id=\"simpleEdit\" action=\"select.aspx\" method=\"post\">");
            Response.Write("Insert the Username:");
            Response.Write("<input type='text' name='username'/>");
            Response.Write("<br />");
            Response.Write("Insert the first name:");
            Response.Write("<input type='text' name='fname'/>");
            Response.Write("<br />");
            Response.Write("Insert the last name:");
            Response.Write("<input type='text' name='lname'/>");
            Response.Write("<br />");
            Response.Write("<input type='submit' name='user' id=\"select\" value=\"By username\" />");
            Response.Write("<input type='submit' name='f' id=\"select\" value=\"By firstname\" />");
            Response.Write("<input type='submit' name='l' id=\"select\" value=\"By lastname\" />");
            Response.Write("</form>");
        }
        else
         {
             if (Request.Form["user"] != null)
             {
                 column1 = Request.Form["username"];
                 column2 = "username";
             }

             else
                 if (Request.Form["f"] != null)
                 {
                     column1 = Request.Form["fname"];
                     column2 = "fname";
                 }
                 else
                     if (Request.Form["l"] != null)
                     {
                         column1 = Request.Form["lname"];
                         column2 = "lname";
                     }
                

             if (column1 != null)
                 Response.Write(setTable(column2, column1));
         
             
          
                     
         }
         %>
    
</asp:Content>

