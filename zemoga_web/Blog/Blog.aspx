<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="zemoga_web.Blog.Blog" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div class="form-group">
            <label for="txt_tittle">Post Tittle</label>
            <asp:TextBox ID="txt_tittle" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txt_content">Content</label>
            <asp:TextBox ID="txt_content" runat="server"  CssClass="form-control"  TextMode="MultiLine" Rows="5" ></asp:TextBox>
        </div>
        <div>

            <div class="col-md-12">
                <asp:Button ID="btn_save" runat="server" Text="Save" OnClick="Save_Click" class="btn btn-labeled btn-success" />
            </div>
        </div>
    </div>
</asp:Content>
