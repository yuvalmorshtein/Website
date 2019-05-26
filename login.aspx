<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <% if (Request.Form["submit"] == null)
                {
                    Response.Write("<div>Logging In Form:</div><br />");
                    Response.Write("<form name=\"myForm\" runat=\"server\" method=\"post\">");
                    Response.Write("Insert your Username: <input type=\"text\" name=\"username\" id=\"username\" /> </br>");
                    Response.Write("Insert your Password: <input type=\"password\" name=\"password\" id=\"password\" /> </br> </br>");
                    Response.Write("<input type=\"submit\" name=\"submit\" id=\"submit\" value=\"submit\" />");
                    Response.Write("</form>"); 
                }
                   
                %>    
                <%=RegStatus %>
  
    
    <br />
   

    
                
</asp:Content>

