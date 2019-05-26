<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="gallery.aspx.cs" Inherits="gallery" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <% if(Session["IsAdmin"]!=null)
   {
     Response.Write("<div style=\"text-align:left\">For interesting videos:</div>");
                Response.Write("<p style=\"text-align:left\">");
                Response.Write("<a href=\"https://www.youtube.com/watch?v=B3OV3o_MpuE \">https://www.youtube.com/watch?v=B3OV3o_MpuE </a><br />");
                Response.Write("<a href=\"https://www.youtube.com/watch?v=ibg98OTBnkY\">https://www.youtube.com/watch?v=ibg98OTBnkY</a> <br />");
                Response.Write("<a href=\"https://www.youtube.com/watch?v=Mi-4POYhSik\">https://www.youtube.com/watch?v=Mi-4POYhSik</a> <br />");
                Response.Write("<a href=\"https://www.youtube.com/watch?v=m9z0OXGYMWw\">https://www.youtube.com/watch?v=m9z0OXGYMWw</a> <br />");
                Response.Write("<a href=\"https://www.youtube.com/watch?v=_Jxg3E6f9CU\">https://www.youtube.com/watch?v=_Jxg3E6f9CU</a> <br /><br /></p>");

                Response.Write("<div style=\"text-align:left\">For more information:</div>");
                Response.Write("<p style=\"text-align:left\">");
                Response.Write("<a href=\"http://www.uefa.com/uefachampionsleague/\">http://www.uefa.com/uefachampionsleague/</a><br />");
                Response.Write("<a href=\"https://en.wikipedia.org/wiki/UEFA_Champions_League\">https://en.wikipedia.org/wiki/UEFA_Champions_League</a><br />");
                Response.Write("<a href=\"http://www.bbc.com/sport/football/champions-league/fixtures\">http://www.bbc.com/sport/football/champions-league/fixtures</a><br />");
                Response.Write("<a href=\"https://en.wikipedia.org/wiki/2016%E2%80%9317_UEFA_Champions_League\">https://en.wikipedia.org/wiki/2016%E2%80%9317_UEFA_Champions_League</a><br />");
                Response.Write("<a href=\"https://www.facebook.com/uefachampionsleague/?fref=ts\">https://www.facebook.com/uefachampionsleague/?fref=ts</a><br />");

             }
       else
           Response.Write(" Only members can view this page <br /> <br /> <a href='register.aspx'>sign up now</a> ");
    %>
           
    </asp:Content>

       
   

