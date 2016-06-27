<%@ Page Title="新闻内容-众志新闻网" Language="C#" MasterPageFile="~/common.master" AutoEventWireup="true"
    CodeFile="newscontent.aspx.cs" Inherits="newscontent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--搜索结果-->
    <div id="newscontent" class="commonfrm">
        <h4>
            新闻标题</h4>
        <p class="con">
            新闻内容部分新闻内容部分新闻内容部分新闻内容部分新闻内容部分新闻内容部分新闻内容部分 新闻内容部分新闻内容部分新闻内容部分新闻内容部分新闻内容部分新闻内容部分新闻内容部分新闻内容部分新闻内容部分
            新闻内容部分新闻内容部分新闻内容部分新闻内容部分新闻内容部分新闻内容部分新闻内容部分新闻内容部分新闻内容部分新闻内容部分新闻内容部分 新闻内容部分新闻内容部分新闻内容部分新闻内容部分新闻内容部分新闻内容部分新闻内容部分</p>
        <p class="con_time">
            发布时间：2012-6-7</p>
        <a href="#">我要评论</a>
    </div>
    <div id="newreplay" class="commonfrm">
        <h4>
            新闻评论</h4>
        <div class="replay">
            <p class="con ">
                回复内容回复内容回复内容回复内容回复内容回复内容回复内容回复内容</p>
            <p class="replay_info">
                评论者:210.38.111.* 评论时间：2012-6-8</p>
                <hr />
        </div>
         <div class="replay">
            <p class="con ">
                回复内容1回复内容回复内容回复内容回复内容回复内容回复内容回复内容</p>
            <p class="replay_info">
                评论者:210.38.111.* 评论时间：2012-6-8</p>
                <hr />
        </div> 
        <div class="replay">
            <p class="con ">
                回复内容2回复内容回复内容回复内容回复内容回复内容回复内容回复内容</p>
            <p class="replay_info">
                评论者:210.38.111.* 评论时间：2012-6-8</p>
                <hr />
        </div> 
        <div class="replay">
            <p class="con ">
                回复内容3回复内容回复内容回复内容回复内容回复内容回复内容回复内容</p>
            <p class="replay_info">
                评论者:210.38.111.* 评论时间：2012-6-8</p>
        <hr />
        </div>
         <div class="replay">
            <p class="con ">
                回复内容4回复内容回复内容回复内容回复内容回复内容回复内容回复内容</p>
            <p class="replay_info">
                评论者:210.38.111.* 评论时间：2012-6-8</p>
        </div>
    </div> 
    <div class="addcomment">
        <asp:TextBox ID="txtComment" runat="server" TextMode ="MultiLine"  Text ="请再次输入评论内容"  CssClass ="comment_con"></asp:TextBox>
    <p>
    验证码：123456
        <asp:TextBox ID="txtCode" runat="server" CssClass ="txtcode"></asp:TextBox>
<asp:Button ID="butSub" runat="server" Text="提交" />
    </p>
    </div>
</asp:Content>
