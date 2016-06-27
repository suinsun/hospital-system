<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="admin_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>后台登陆-酥梨新闻发布系统</title>
    <link href="../css/login.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="loginfrm" class ="round1">
        <h3>
            后台登陆-酥梨新闻发布系统</h3>
        <div id="login">
            <img src="../images/mainlogo.jpg" alt="LOGO"/>
            <p>
                用户名:<asp:TextBox ID="txtUserName" runat="server" CssClass ="textbox"></asp:TextBox></p>
            <p>
                密　码:<asp:TextBox ID="txtPasswword" runat="server" TextMode="Password" CssClass ="textbox"></asp:TextBox></p>
            <p>
                验证码:123456<asp:TextBox ID="txtCode" runat="server" CssClass ="textcode"></asp:TextBox></p>
            <p>
                <asp:Button ID="btnlogin" runat="server" Text="登陆" /></p>
        </div>
        <div id="footer">
            版权所有 &copy;<a href="http://niunan.javaeve.com" target="_blank">酥梨</a> &amp;<a href="http://www.tg029.com" target="_blank">众志网 </a>
        </div>
    </div>
    </form>
</body>
</html>
